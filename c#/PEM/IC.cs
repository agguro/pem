using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEM
{
    [ToolboxItem(true)]
    public partial class IC : BaseComponent
    {
        public enum Positions { Left, Right }
        private bool _clocked;
        private Positions _clockposition;
        private string _caption;
        private Font _captionfont;
        private Databus _tobus;
        

        public bool Clocked
        {
            get
            {
                return _clocked;
            }
            set
            {
                if (_clocked != value)
                {
                    _clocked = value;
                    Invalidate();
                }
            }
        }

        public Positions ClockPosition
        {
            get
            {
                return _clockposition;
            }
            set
            {
                if (_clockposition != value)
                {
                    _clockposition = value;
                    Invalidate();
                }
            }
        }

        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                Invalidate();
            }
        }

        public Font CaptionFont
        {
            get
            {
                return _captionfont;
            }
            set
            {
                _captionfont = value;
                Invalidate();
            }
        }

        public Databus ConnectedWith {
            get
            {
                return _tobus;
            }
            set
            {
                _tobus = value;
                Invalidate();
            }
        }

        public IC()
        {
            InitializeComponent();
            captionLabel.Width = Width;
            captionLabel.Top   = (Height - captionLabel.Height) / 2;
        }

        protected override void DrawComponent(PaintEventArgs e, Color _borderColor, int _borderWidth)
        {
            BorderStyle = BorderStyle.None;
            
            using (Pen p = new Pen(_borderColor, 1))
            {
                for (int i = 0; i <= _borderWidth - 1; i++)
                {
                    e.Graphics.DrawLine(p, 0, i, Width, i);
                    e.Graphics.DrawLine(p, Width - i - 1, 0, Width - i - 1, Height - 1);
                    e.Graphics.DrawLine(p, 1, Height - i - 1, Width, Height - i - 1);
                    e.Graphics.DrawLine(p, i, 0, i, Height - 1);
                    if (_clocked)
                    {
                        switch (_clockposition)
                        {
                            case Positions.Left:
                                e.Graphics.DrawLine(p, 0, Height / 2 - 7 - i, 7 + i, Height / 2);
                                e.Graphics.DrawLine(p, 0, Height / 2 + 7 + i, 7 + i, Height / 2);
                                break;
                            case Positions.Right:
                                e.Graphics.DrawLine(p, Width - 1, Height / 2 - 7 - i, Width - 8 - i, Height / 2);
                                e.Graphics.DrawLine(p, Width - 1, Height / 2 + 7 + i, Width - 8 - i, Height / 2);
                                break;
                        }
                    }
                }

            }
            if (_caption != string.Empty)
            {
                captionLabel.Width = Width;
                captionLabel.Top = (Height - captionLabel.Height) / 2;
                captionLabel.TextAlign = ContentAlignment.MiddleCenter;
                captionLabel.Text = _caption;
                captionLabel.Font = CaptionFont;
                captionLabel.ForeColor = _borderColor;
            }
            if (_tobus != null)
            {
                _tobus.Active = Active;
            }

        }

        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
        }

        protected override void StateChangedHandler(EventArgs e)
        {
            base.StateChangedHandler(e);
        }

        private void captionLabel_Click(object sender, EventArgs e)
        {
            Active = !Active;
        }

        protected virtual void Execute(object sender, EventArgs e)
        {

        }
    }
}

