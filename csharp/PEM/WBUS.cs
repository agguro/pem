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
    public partial class WBUS : Databus
    {
        public WBUS()
        {
            InitializeComponent();
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
                }

            }

        }

        protected void Execute(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
