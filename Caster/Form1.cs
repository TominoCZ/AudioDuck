using Caster.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Caster
{
    public partial class Form1 : Form
    {
        List<AudioSessionControl> _audioSessionControls;

        MMDevice speaker;
        MMDevice mic;

        Average micAvg, speakerAvg;

        Thread updateThread;

        double step;

        bool loadedSettings;

        public Form1()
        {
            InitializeComponent();

            micAvg = new Average();
            speakerAvg = new Average();

            updateThread = new Thread(() =>
            {
                bool caught = false;

                while (true)
                {
                    if (IsHandleCreated)
                    {
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            try
                            {
                                //load devices
                                var session = new MMDeviceEnumerator();
                                speaker = session.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                                mic = session.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

                                var sessions = speaker.AudioSessionManager.Sessions;

                                _audioSessionControls = getControls(sessions);

                                double peakIn = mic.AudioMeterInformation.MasterPeakValue * (double)nudMicBoost.Value;
                                double peakOut = speaker.AudioMeterInformation.MasterPeakValue;

                                micAvg.Add(Clamp(peakIn, 0, 1));

                                if (micAvg.isReady())
                                    barMicIn.Value = (int)(micAvg.getAverage() * 100);

                                speakerAvg.Add(peakOut);

                                if (speakerAvg.isReady())
                                    barOut.Value = (int)(speakerAvg.getAverage() * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar * GetTopSession().SimpleAudioVolume.Volume);

                                barOut.ThresholdValue = (int)(GetTopSession().SimpleAudioVolume.Volume * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar);

                                caught = false;
                            }
                            catch
                            {
                                caught = true;
                            }
                        }));

                        if (caught)
                            Thread.Sleep(100);
                    }

                    Thread.Sleep(TimeSpan.FromMilliseconds(1000.0 / 60 / 3.0)); //get 3 samples while maintaining 60 FPS
                }
            })
            { IsBackground = true };

            updateThread.Start();
        }

        private List<AudioSessionControl> getControls(SessionCollection sessions)
        {
            object[] ex = new object[lbExceptions.Items.Count];

            lbExceptions.Items.CopyTo(ex, 0);

            List<AudioSessionControl> controls = new List<AudioSessionControl>();

            for (int i = 0; i < sessions.Count; i++)
            {
                var session = sessions[i];
                var text = (session.GetSessionIdentifier + session.GetSessionInstanceIdentifier).ToLower();

                bool inExceptions = false;

                foreach (string e in ex)
                {
                    if (text.Contains(e))
                    {
                        inExceptions = true;
                        break;
                    }
                }

                if (!inExceptions)
                    controls.Add(session);
            }

            return controls;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Settings.Default.Reload();

            if (Settings.Default.Exceptions != null)
            {
                foreach (var ex in Settings.Default.Exceptions)
                {
                    lbExceptions.Items.Add(ex);
                }
            }

            nudMicBoost.Value = (decimal)Settings.Default.MicBoost;
            barMicIn.ThresholdValue = (int)(nudMicThreshold.Value = Settings.Default.MicThreshold);
            nudMin.Value = Settings.Default.MinVolume;
            nudMax.Value = Settings.Default.MaxVolume;
            nudIncTime.Value = Settings.Default.IncreaseTime;
            nudDecTime.Value = Settings.Default.DecreaseTime;
            nudIncDelay.Value = Settings.Default.IncreaseDelay;

            loadedSettings = true;

            nud_ValueChanged(null, null);
        }

        private void barMicIn_ReachedThreshold(object sender, EventArgs e)
        {
            increaseDelayTimer.Stop();

            if (!volumeDecreaseTimer.Enabled)
            {
                step = Math.Abs(GetTopSession().SimpleAudioVolume.Volume - (double)nudMin.Value / 100) / 4;

                volumeIncreaseTimer.Stop();

                volumeDecreaseTimer.Interval = (int)(nudDecTime.Value / 4);
                volumeDecreaseTimer.Start();
            }
        }

        private void volumeIncreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _audioSessionControls.Count; i++)
                _audioSessionControls[i].SimpleAudioVolume.Volume = (float)Clamp(_audioSessionControls[i].SimpleAudioVolume.Volume + step, 0, (double)nudMax.Value / 100);

            if (GetTopSession().SimpleAudioVolume.Volume >= (float)(nudMax.Value / 100))
                volumeIncreaseTimer.Stop();
        }

        private void volumeDecreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _audioSessionControls.Count; i++)
                _audioSessionControls[i].SimpleAudioVolume.Volume = (float)Clamp(_audioSessionControls[i].SimpleAudioVolume.Volume - step, (double)nudMin.Value / 100, 1);

            if (GetTopSession().SimpleAudioVolume.Volume <= (float)(nudMin.Value / 100))
            {
                volumeDecreaseTimer.Stop();

                beginIncrease();
            }
        }

        private void increaseDelayTimer_Tick(object sender, EventArgs e)
        {
            step = Math.Abs((double)nudMax.Value / 100 - GetTopSession().SimpleAudioVolume.Volume) / 12;

            volumeIncreaseTimer.Interval = (int)(nudIncTime.Value / 12);
            volumeIncreaseTimer.Start();

            increaseDelayTimer.Stop();
        }

        private void beginIncrease()
        {
            if (!increaseDelayTimer.Enabled)
            {
                increaseDelayTimer.Interval = (int)(nudIncDelay.Value);
                increaseDelayTimer.Enabled = true;
            }
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!loadedSettings)
                return;

            loadedSettings = false;

            if (sender == nudMicThreshold)
                barMicIn.ThresholdValue = (int)nudMicThreshold.Value;

            Settings.Default.MicBoost = (double)nudMicBoost.Value;
            Settings.Default.MicThreshold = (int)nudMicThreshold.Value;

            Settings.Default.MinVolume = (int)nudMin.Value;
            Settings.Default.MaxVolume = (int)nudMax.Value;

            Settings.Default.IncreaseTime = (int)nudIncTime.Value;
            Settings.Default.DecreaseTime = (int)nudDecTime.Value;

            Settings.Default.IncreaseDelay = (int)nudIncDelay.Value;

            Settings.Default.Save();

            loadedSettings = true;
        }

        private void lbExceptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lbExceptions.SelectedItem is string s)
                {
                    var dr = MessageBox.Show($"Remove '{s}' from the exceptions?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                        lbExceptions.Items.Remove(s);
                }
            }
        }

        private void btnAddException_Click(object sender, EventArgs e)
        {
            lbExceptions.Items.Add(tbProcessName.Text.Replace(" ", "").ToLower().Split('.')[0]);
            tbProcessName.Text = "";

            var sc = new StringCollection();
            for (int i = 0; i < lbExceptions.Items.Count; i++)
            {
                sc.Add((string)lbExceptions.Items[i]);
            }

            Settings.Default.Exceptions = sc;
            Settings.Default.Save();
        }

        private void tbProcessName_TextChanged(object sender, EventArgs e)
        {
            btnAddException.Enabled = !String.IsNullOrWhiteSpace(tbProcessName.Text);

            string text = tbProcessName.Text.Replace(" ", "").ToLower().Split('.')[0];

            for (int i = 0; i < lbExceptions.Items.Count; i++)
            {
                var item = (string)lbExceptions.Items[i];

                if (item.Contains(text))
                {
                    btnAddException.Enabled = false;
                    break;
                }
            }
        }

        private void tbProcessName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnAddException.Enabled)
                btnAddException_Click(sender, null);
        }

        AudioSessionControl GetTopSession()
        {
            float level = float.MinValue;
            AudioSessionControl asc = null;

            for (int i = 0; i < _audioSessionControls.Count; i++)
            {
                var session = _audioSessionControls[i];

                if (session.SimpleAudioVolume.Volume > level)
                {
                    level = session.SimpleAudioVolume.Volume;
                    asc = session;
                }
            }

            return asc;
        }

        private double Clamp(double d, double min, double max)
        {
            return d < min ? min : (d > max ? max : d);
        }
    }

    class Average
    {
        double[] Values;

        public Average()
        {
            Values = new double[] { -1, -1, -1 };
        }

        public bool isReady()
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == -1)
                    return false;
            }

            return true;
        }

        public void Add(double d)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == -1)
                {
                    Values[i] = d;
                    break;
                }
            }
        }

        public double getAverage()
        {
            double avg = (Values[0] + Values[1] + Values[2]) / 3;

            Values = new double[] { -1, -1, -1 };

            return avg;
        }
    }
}
