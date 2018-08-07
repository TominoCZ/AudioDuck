using AudioDuck.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace AudioDuck
{
    public partial class Form1 : Form
    {
        private List<AudioSessionControl> _audioSessionControls;

        private Thread _updateThread;
        private double _step;
        private bool _loadedSettings;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var si = Process.GetCurrentProcess().StartInfo;

            _updateThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        //load devices
                        var session = new MMDeviceEnumerator();
                        var speaker = session.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                        var mic = session.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

                        var sessions = speaker.AudioSessionManager.Sessions;

                        _audioSessionControls = GetControls(sessions);

                        double peakIn = Clamp(mic.AudioMeterInformation.MasterPeakValue * (double)nudMicBoost.Value, 0, 1);
                        double peakOut = speaker.AudioMeterInformation.MasterPeakValue;

                        int inValue = (int)(peakIn * 100);
                        int outValue = (int)(peakOut * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar *
                                              GetTopSession().SimpleAudioVolume.Volume);
                        int outThresholdValue = (int)(GetTopSession().SimpleAudioVolume.Volume * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar);

                        BeginInvoke(new MethodInvoker(() =>
                        {
                            barIn.Value = inValue;

                            barOut.Value = outValue;
                            barOut.ThresholdValue = outThresholdValue;

                            if (Visible && IsHandleCreated && Created)
                            {
                                try
                                {
                                    barIn.Invalidate();
                                    barOut.Invalidate();
                                }
                                catch
                                {

                                }
                            }
                        }));
                    }
                    catch
                    {
                        Thread.Sleep(100);
                    }

                    Thread.Sleep(TimeSpan.FromMilliseconds(1000.0 / 30));
                }
            })
            { IsBackground = true };

            _updateThread.Start();

            Settings.Default.Reload();

            if (Settings.Default.Exceptions != null)
            {
                foreach (var ex in Settings.Default.Exceptions)
                {
                    lbExceptions.Items.Add(ex);
                }
            }

            nudMicBoost.Value = (decimal)Settings.Default.MicBoost;
            barIn.ThresholdValue = (int)(nudMicThreshold.Value = Settings.Default.MicThreshold);
            nudMin.Value = Settings.Default.MinVolume;
            nudMax.Value = Settings.Default.MaxVolume;
            nudIncTime.Value = Settings.Default.IncreaseTime;
            nudDecTime.Value = Settings.Default.DecreaseTime;
            nudIncDelay.Value = Settings.Default.IncreaseDelay;

            _loadedSettings = true;
        }

        private void barMicIn_ReachedThreshold(object sender, EventArgs e)
        {
            increaseDelayTimer.Stop();

            if (!volumeDecreaseTimer.Enabled)
            {
                _step = Math.Abs(GetTopSession().SimpleAudioVolume.Volume - (double)nudMin.Value / 100) / 4;

                volumeIncreaseTimer.Stop();

                volumeDecreaseTimer.Interval = (int)(nudDecTime.Value / 4);
                volumeDecreaseTimer.Start();
            }
        }

        private void volumeIncreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _audioSessionControls.Count; i++)
                _audioSessionControls[i].SimpleAudioVolume.Volume = (float)Clamp(_audioSessionControls[i].SimpleAudioVolume.Volume + _step, 0, (double)nudMax.Value / 100);

            if (GetTopSession().SimpleAudioVolume.Volume >= (float)(nudMax.Value / 100))
                volumeIncreaseTimer.Stop();
        }

        private void volumeDecreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _audioSessionControls.Count; i++)
                _audioSessionControls[i].SimpleAudioVolume.Volume = (float)Clamp(_audioSessionControls[i].SimpleAudioVolume.Volume - _step, (double)nudMin.Value / 100, 1);

            if (GetTopSession().SimpleAudioVolume.Volume <= (float)(nudMin.Value / 100))
            {
                volumeDecreaseTimer.Stop();

                BeginIncrease();
            }
        }

        private void increaseDelayTimer_Tick(object sender, EventArgs e)
        {
            if (barIn.Value < nudMicThreshold.Value)
            {
                _step = Math.Abs((double)nudMax.Value / 100 - GetTopSession().SimpleAudioVolume.Volume) / 12;

                volumeIncreaseTimer.Interval = (int)(nudIncTime.Value / 12);

                volumeIncreaseTimer.Start();

                increaseDelayTimer.Stop();
            }
        }

        private void BeginIncrease()
        {
            if (!increaseDelayTimer.Enabled)
            {
                increaseDelayTimer.Interval = (int)nudIncDelay.Value;
                increaseDelayTimer.Enabled = true;
            }
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!_loadedSettings)
                return;

            _loadedSettings = false;

            if (sender == nudMicThreshold)
                barIn.ThresholdValue = (int)nudMicThreshold.Value;

            Settings.Default.MicBoost = (double)nudMicBoost.Value;
            Settings.Default.MicThreshold = (int)nudMicThreshold.Value;

            Settings.Default.MinVolume = (int)nudMin.Value;
            Settings.Default.MaxVolume = (int)nudMax.Value;

            Settings.Default.IncreaseTime = (int)nudIncTime.Value;
            Settings.Default.DecreaseTime = (int)nudDecTime.Value;

            Settings.Default.IncreaseDelay = (int)nudIncDelay.Value;

            Settings.Default.Save();

            _loadedSettings = true;
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

                    ExceptionsChanged();
                }
            }
        }

        private void btnAddException_Click(object sender, EventArgs e)
        {
            string process = tbProcessName.Text.Replace(" ", "").ToLower().Split('.')[0];
            lbExceptions.Items.Add(process);
            tbProcessName.Text = "";

            //set that process' volume level
            for (int i = 0; i < _audioSessionControls.Count; i++)
            {
                var session = _audioSessionControls[i];

                string text = session.GetSessionIdentifier + session.GetSessionInstanceIdentifier.ToLower();

                if (text.Contains(process))
                {
                    session.SimpleAudioVolume.Volume = (float)nudMax.Value / 100;
                    break;
                }
            }

            ExceptionsChanged();
        }

        private void ExceptionsChanged()
        {
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var sfd = new SaveFileDialog();

                sfd.Filter = "Caster Profile Files|*.cprofile";
                sfd.FileName = $"profile";

                try
                {
                    if (!Directory.Exists("profiles"))
                        Directory.CreateDirectory("profiles");

                    sfd.InitialDirectory = Directory.GetCurrentDirectory() + "\\profiles";

                    for (int i = 0; i < int.MaxValue; i++)
                    {
                        if (!File.Exists($"{sfd.InitialDirectory}\\profile_{i}.cprofile"))
                        {
                            sfd.FileName = $"profile_{i}";
                            break;
                        }
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Could not create the directory 'profiles': Access denied.\nRun this program as an Administrator to prevent this issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Could not create the directory 'profiles'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var result = sfd.ShowDialog();

                if (result != DialogResult.Cancel && sfd.CheckPathExists)
                {
                    var bf = new BinaryFormatter();
                    var profile = new Profile();

                    profile.MicBoost = Settings.Default.MicBoost;
                    profile.MicThreshold = Settings.Default.MicThreshold;
                    profile.MaxVolume = Settings.Default.MaxVolume;
                    profile.MinVolume = Settings.Default.MinVolume;
                    profile.IncreaseTime = Settings.Default.IncreaseTime;
                    profile.DecreaseTime = Settings.Default.DecreaseTime;
                    profile.IncreaseDelay = Settings.Default.IncreaseDelay;
                    profile.Exceptions = Settings.Default.Exceptions;

                    using (var fs = sfd.OpenFile())
                        bf.Serialize(fs, profile);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("An error has occured while writing the file: Access denied.\nRun this program as an Administrator to prevent this issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An error has occured while writing the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();

                ofd.Filter = "Caster Profile Files|*.cprofile";
                ofd.InitialDirectory = Directory.GetCurrentDirectory() + "\\profiles";

                var result = ofd.ShowDialog();

                if (result != DialogResult.Cancel && ofd.CheckPathExists && ofd.CheckFileExists)
                {
                    _loadedSettings = false;

                    var bf = new BinaryFormatter();
                    Profile profile;

                    using (var fs = ofd.OpenFile())
                        profile = (Profile)bf.Deserialize(fs);

                    lbExceptions.Items.Clear();

                    if (profile.Exceptions != null)
                    {
                        foreach (var ex in profile.Exceptions)
                        {
                            lbExceptions.Items.Add(ex);
                        }
                    }

                    nudMicBoost.Value = (decimal)profile.MicBoost;
                    nudMicThreshold.Value = barIn.ThresholdValue = profile.MicThreshold;
                    nudMin.Value = profile.MinVolume;
                    nudMax.Value = profile.MaxVolume;
                    nudIncTime.Value = profile.IncreaseTime;
                    nudDecTime.Value = profile.DecreaseTime;
                    nudIncDelay.Value = profile.IncreaseDelay;

                    _loadedSettings = true;
                }
            }
            catch
            {
                MessageBox.Show("An error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Clamp(double d, double min, double max)
        {
            return d < min ? min : (d > max ? max : d);
        }

        private List<AudioSessionControl> GetControls(SessionCollection sessions)
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
                    if (text.Contains($"\\{e}.exe"))
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

        private AudioSessionControl GetTopSession()
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Close();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                notifyIcon1.Visible = true;
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;

            Show();

            WindowState = FormWindowState.Normal;

            BringToFront();
        }
    }

    [Serializable]
    internal class Profile
    {
        public double MicBoost;

        public int MicThreshold;
        public int MaxVolume;
        public int MinVolume;
        public int IncreaseTime;
        public int DecreaseTime;
        public int IncreaseDelay;

        public StringCollection Exceptions;
    }
}
