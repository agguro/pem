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
    public partial class Connection : BaseComponent
    {
       
        private BaseComponent _connectedwith;
        private Orientation _orientation;
        
        public BaseComponent ConnectedWith
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

        public Orientation Orientation
        {
            get
            {
                return _orientation;
            }
            set
            {
                if (_orientation != value)
                {
                    Int32 dummy = Height;
                    Height = Width;
                    Width = dummy;
                    _orientation = value;
                    Invalidate();
                }
            }
        }

        public Connection()
        {
            InitializeComponent();
        }
       
        protected override void DrawComponent(PaintEventArgs e, Color _borderColor, int _borderWidth)
        {
            BorderStyle = BorderStyle.None;
            if (_orientation == Orientation.Horizontal)
            {
                Height = _borderWidth;
            }
            else
            {
                Width = _borderWidth;
            }
            
            using (Brush brush = new SolidBrush(_borderColor))
            {
                e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
            }

            if(_connectedwith != null)
            {
                _connectedwith.Active = Active;
            }

        }

        private void Connection_Click(object sender, EventArgs e)
        {
            Active = !Active;
        }
    }
}
