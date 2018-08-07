using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioDuck
{
    public partial class Bar : UserControl
    {
        private int _value;
        private bool _reachedThreshold;

        public event EventHandler ReachedThreshold;

        public Color BarColor { get; set; }

        public Color ThresholdValueColor { get; set; }

        public Color OutlineColor { get; set; }

        public int Value
        {
            get => _value;

            set
            {
                if (value >= ThresholdValue)
                {
                    if (!_reachedThreshold && ReachedThreshold != null)
                    {
                        _reachedThreshold = true;

                        ReachedThreshold(this, null);
                    }
                }
                else if (_reachedThreshold)
                    _reachedThreshold = false;

                _value = value;
            }
        }

        public int ThresholdValue { get; set; }

        public bool ShowThresholdValue { get; set; }

        public Bar()
        {
            InitializeComponent();
        }

        private void Bar_Paint(object sender, PaintEventArgs e)
        {
            int width = ClientSize.Width - 2;
            int height = ClientSize.Height - 2;

            float val = _value / 100f;

            int barHeight = (int)(height * val);
            int thresholdY = (int)(height - height * (ThresholdValue / 100f) + 1);

            e.Graphics.FillRectangle(new SolidBrush(BarColor), 1, height - barHeight + 1, width, barHeight);

            if (ShowThresholdValue)
                e.Graphics.DrawLine(new Pen(new SolidBrush(ThresholdValueColor), 1), 0, thresholdY, width, thresholdY);

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(OutlineColor), 4), ClientRectangle);
        }
    }
}
