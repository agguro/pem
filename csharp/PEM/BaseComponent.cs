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
    [ToolboxItem(false)]
    public partial class BaseComponent : UserControl
    {
        public delegate void OnStateChangedHandler(EventArgs e);


        private Color _borderColor = Color.Black;
        private Color _activeColor = Color.Red;
        private Color _inactiveColor = Color.Black;
        private bool _active = false;
        int _borderWidth = 3;

        public event EventHandler StateChanged;
        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                Invalidate();
                PerformLayout();
            }
        }

        public Color ActiveColor
        {
            get { return _activeColor; }
            set { _activeColor = value; Invalidate(); }
        }

        public Color InactiveColor
        {
            get { return _inactiveColor; }
            set { _inactiveColor = value; Invalidate(); }
        }

        public bool Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    Invalidate();
                    StateChangedHandler(EventArgs.Empty);
                }
            }
        }

        public Color CurrentColor
        {
            get
            {
                Color c;
                if (Active)
                {
                    c = ActiveColor;
                }
                else
                {
                    c = InactiveColor;
                }
                return c;
            }
        }

        public BaseComponent()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            if (_active)
            {
                _borderColor = _activeColor;
            }
            else
            {
                _borderColor = _inactiveColor;
            }

            DrawComponent(e, _borderColor, _borderWidth);

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected virtual void DrawComponent(PaintEventArgs e, Color _borderColor, int _borderWidth)
        {
            //throw new NotImplementedException();
        }

        protected virtual void StateChangedHandler(EventArgs e)
        {
            // Raise the event
            if (StateChanged != null)
                StateChanged(this, e);
        }

    }
}
