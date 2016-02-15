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
    public partial class Databus : BaseComponent
    {
        private Databus _connectedwith;
        private WBUS _wbus;

        public Databus ConnectedWith
        {
            get
            {
                return _connectedwith;
            }
            set
            {
                _connectedwith = value;
            }
        }

        public WBUS WBUS
        {
            get
            {
                return _wbus;
            }
            set
            {
                _wbus = value;
            }
        }

        public Databus()
        {
            InitializeComponent();
        }

        private Directions _direction;
        private bool _closedarrow;

        public enum Directions { Left, Right, Up, Down }

        public Directions Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
                Invalidate();
            }
        }

        public bool ClosedArrow
        {
            get
            {
                return _closedarrow;
            }
            set
            {
                if (value != _closedarrow)
                {
                    _closedarrow = value;
                    Invalidate();
                }
            }
        }

        protected override void DrawComponent(PaintEventArgs e, Color _borderColor, int _borderWidth)
        {
            using (Pen p = new Pen(_borderColor, 1))
            {
                switch (_direction)
                {
                    case Directions.Left:
                        for (int i = 0; i < _borderWidth; i++)
                        {
                            e.Graphics.DrawLine(p, i, Height / 2, Height / 2, i);
                            e.Graphics.DrawLine(p, Height / 2, i, Width - 1, i);
                            if (_closedarrow)
                            {
                                e.Graphics.DrawLine(p, Width - i - 1, 0, Width - i - 1, Height - 1);
                            }
                            e.Graphics.DrawLine(p, Width - 1, Height - 1 - i, Height / 2, Height - i - 1);
                            e.Graphics.DrawLine(p, Height / 2, Height - i - 1, i, Height / 2);
                        }
                        break;
                    case Directions.Up:
                        for (int i = 0; i < _borderWidth; i++)
                        {
                            e.Graphics.DrawLine(p, i, Width / 2, Width / 2, i);
                            e.Graphics.DrawLine(p, Width / 2, i, Width - i - 1, Width / 2);
                            e.Graphics.DrawLine(p, Width - i - 1, Width / 2 - i, Width - i - 1, Height - 1);
                            if (_closedarrow)
                            {
                                e.Graphics.DrawLine(p, Width - 1, Height - 1 - i, 0, Height - i - 1);
                            }
                            e.Graphics.DrawLine(p, i, Height - 1, i, Width / 2);
                        }
                        break;
                    case Directions.Right:
                        for (int i = 0; i < _borderWidth; i++)
                        {
                            e.Graphics.DrawLine(p, 0, i, Width - 1 - Height / 2, i);
                            e.Graphics.DrawLine(p, Width - 1 - Height / 2, i, Width - 1 - i, Height / 2);
                            e.Graphics.DrawLine(p, Width - i - 1, Height / 2, Width - 1 - i - Height / 2, Height - 1);
                            e.Graphics.DrawLine(p, Width - 1 - Height / 2, Height - i - 1, 0, Height - i - 1);
                            if (_closedarrow)
                            {

                                e.Graphics.DrawLine(p, i, Height - 1, i, 0);
                            }
                        }
                        break;
                    case Directions.Down:
                        for (int i = 0; i < _borderWidth; i++)
                        {
                            if (_closedarrow)
                            {
                                e.Graphics.DrawLine(p, 0, i, Width - 1, i);
                            }
                            e.Graphics.DrawLine(p, Width - i - 1, 0, Width - i - 1, Height - 1 - Width / 2);
                            e.Graphics.DrawLine(p, i, Height - 1 - Width / 2, i, 0);
                            e.Graphics.DrawLine(p, Width - i - 1, Height - 1 - Width / 2, Width / 2, Height - i - 1);
                            e.Graphics.DrawLine(p, Width / 2, Height - i - 1, i, Height - 1 - Width / 2);
                        }
                        break;
                }

                if(_connectedwith != null)
                {
                    _connectedwith.Active = Active;
                }
                if (_wbus != null)
                {
                    _wbus.Active = Active;
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private void Databus_Click(object sender, EventArgs e)
        {
            Active = !Active;
        }
    }
}
