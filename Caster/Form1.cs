﻿using Caster.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Caster
{
    public partial class Form1 : Form
    {
        SessionCollection sessions;

        MMDevice speaker;
        MMDevice mic;

        Average micAvg, speakerAvg;

        double step;

        bool loadedSettings;

        public Form1()
        {
            InitializeComponent();

            Settings.Default.Reload();

            nudMicBoost.Value = (decimal)Settings.Default.MicBoost;
            nudMicThreshold.Value = Settings.Default.MicThreshold;
            nudMin.Value = Settings.Default.MinVolume;
            nudMax.Value = Settings.Default.MaxVolume;
            nudIncTime.Value = Settings.Default.IncreaseTime;
            nudDecTime.Value = Settings.Default.DecreaseTime;
            nudIncDelay.Value = Settings.Default.IncreaseDelay;

            loadedSettings = true;

            var session = new MMDeviceEnumerator();

            speaker = session.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            sessions = speaker.AudioSessionManager.Sessions;
            mic = session.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);

            micAvg = new Average();
            speakerAvg = new Average();

            new Thread(() =>
            {
                while (true)
                {
                    if (IsHandleCreated)
                    {
                        BeginInvoke(new MethodInvoker(() =>
                        {
                            double peakIn = mic.AudioMeterInformation.MasterPeakValue * (double)nudMicBoost.Value;
                            double peakOut = speaker.AudioMeterInformation.MasterPeakValue;

                            double cancellation = peakOut / 100;

                            micAvg.Add(Clamp(peakIn - cancellation, 0, 1));

                            if (micAvg.isReady())
                                barMicIn.Value = (int)(micAvg.getAverage() * 100);

                            speakerAvg.Add(peakOut);

                            if (speakerAvg.isReady())
                                barOut.Value = (int)(speakerAvg.getAverage() * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar * GetTopSession().SimpleAudioVolume.Volume);

                            barOut.ThresholdValue = (int)(GetTopSession().SimpleAudioVolume.Volume * 100 * speaker.AudioEndpointVolume.MasterVolumeLevelScalar);
                        }));
                    }
                    Thread.Sleep(TimeSpan.FromMilliseconds(1000.0 / 60.0 / 3.0)); //get 5 samples while maintaining 60 FPS
                }
            })
            { IsBackground = true }.Start();
        }

        private void barMicIn_ReachedThreshold(object sender, EventArgs e)
        {
            increaseDelayTimer.Stop();

            if (!volumeDecreaseTimer.Enabled)
            {
                step = Math.Abs(GetTopSession().SimpleAudioVolume.Volume - (double)nudMin.Value / 100) / 10;

                volumeIncreaseTimer.Stop();

                volumeDecreaseTimer.Interval = (int)(nudDecTime.Value / 10);
                volumeDecreaseTimer.Start();
            }
        }

        private void volumeIncreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < sessions.Count; i++)
                sessions[i].SimpleAudioVolume.Volume = (float)Clamp(sessions[i].SimpleAudioVolume.Volume + step, 0, (double)nudMax.Value / 100);

            if (GetTopSession().SimpleAudioVolume.Volume >= (float)(nudMax.Value / 100))
                volumeIncreaseTimer.Stop();
        }

        private void volumeDecreaseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < sessions.Count; i++)
                sessions[i].SimpleAudioVolume.Volume = (float)Clamp(sessions[i].SimpleAudioVolume.Volume - step, (double)nudMin.Value / 100, 1);

            if (GetTopSession().SimpleAudioVolume.Volume <= (float)(nudMin.Value / 100))
            {
                volumeDecreaseTimer.Stop();

                beginIncrease();
            }
        }

        AudioSessionControl GetTopSession()
        {
            float level = float.MinValue;
            AudioSessionControl asc = null;

            for (int i = 0; i < sessions.Count; i++)
            {
                var session = sessions[i];

                if (session.SimpleAudioVolume.Volume > level)
                {
                    level = session.SimpleAudioVolume.Volume;
                    asc = session;
                }
            }

            return asc;
        }

        void beginIncrease()
        {
            if (!increaseDelayTimer.Enabled)
            {
                increaseDelayTimer.Interval = (int)nudIncDelay.Value;
                increaseDelayTimer.Enabled = true;
            }
        }

        private void btnUseCurrentMax_Click(object sender, EventArgs e)
        {
            nudMax.Value = (decimal)speaker.AudioEndpointVolume.MasterVolumeLevelScalar * 100;
        }

        private void btnUseCurrentMin_Click(object sender, EventArgs e)
        {
            nudMin.Value = (decimal)speaker.AudioEndpointVolume.MasterVolumeLevelScalar * 100;
        }

        private void nudMicThreshold_ValueChanged(object sender, EventArgs e)
        {
            barMicIn.ThresholdValue = (int)nudMicThreshold.Value;
        }

        private void valueChanged(object sender, EventArgs e)
        {
            if (!loadedSettings)
                return;

            Settings.Default.MicBoost = (double)nudMicBoost.Value;
            Settings.Default.MicThreshold = (int)nudMicThreshold.Value;

            Settings.Default.MinVolume = (int)nudMin.Value;
            Settings.Default.MaxVolume = (int)nudMax.Value;

            Settings.Default.IncreaseTime = (int)nudIncTime.Value;
            Settings.Default.DecreaseTime = (int)nudDecTime.Value;

            Settings.Default.IncreaseDelay = (int)nudIncDelay.Value;

            Settings.Default.Save();
        }

        private void increaseDelayTimer_Tick(object sender, EventArgs e)
        {
            step = Math.Abs((double)nudMax.Value / 100 - GetTopSession().SimpleAudioVolume.Volume) / 10;

            volumeIncreaseTimer.Interval = (int)(nudIncTime.Value / 10);
            volumeIncreaseTimer.Start();

            increaseDelayTimer.Stop();
        }

        double Clamp(double d, double min, double max)
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