using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caster
{
    public partial class Bar : UserControl
    {
        private Color _barColor, _outlineColor, _thresholdValueColor;
        private int _value, _thresholdValue;
        private bool _showThresholdValue, _reachedThreshold;

        public event EventHandler ReachedThreshold;

        public Color BarColor
        {
            get => _barColor;

            set
            {
                _barColor = value;
                Invalidate();
            }
        }

        public Color ThresholdValueColor
        {
            get => _thresholdValueColor;

            set
            {
                _thresholdValueColor = value;
                Invalidate();
            }
        }

        public Color OutlineColor
        {
            get => _outlineColor;

            set
            {
                _outlineColor = value;
                Invalidate();
            }
        }

        public int Value
        {
            get => _value;

            set
            {
                if (value >= _thresholdValue)
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
                Invalidate();
            }
        }

        public int ThresholdValue
        {
            get => _thresholdValue;

            set
            {
                _thresholdValue = value;
                Invalidate();
            }
        }

        public bool ShowThresholdValue
        {
            get => _showThresholdValue;

            set
            {
                _showThresholdValue = value;
                Invalidate();
            }
        }

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
            int thresholdY = (int)(height - height * (_thresholdValue / 100f) + 1);

            e.Graphics.FillRectangle(new SolidBrush(_barColor), 1, height - barHeight + 1, width, barHeight);

            if (ShowThresholdValue)
                e.Graphics.DrawLine(new Pen(new SolidBrush(_thresholdValueColor), 3), 0, thresholdY, width, thresholdY);

            e.Graphics.DrawRectangle(new Pen(new SolidBrush(_outlineColor), 4), ClientRectangle);
        }
    }
}
