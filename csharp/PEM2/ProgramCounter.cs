using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEM2
{
    public partial class ProgramCounter : PEM1.ProgramCounter
    {
        private PEM.Connection _ls = new PEM.Connection();
        private PEM.Databus _in = new PEM.Databus();

        public PEM.Connection LOAD
        {
            get
            {
                return _ls;
            }
            set
            {
                _ls = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Databus IN
        {
            get
            {
                return _in;
            }
            set
            {
                _in = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public ProgramCounter()
        {
            InitializeComponent();
            
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            Active =  Active | CLK.Active & LOAD.Active;
            OUT.Active = ENABLE.Active & CLK.Active;
            IN.Active = CLK.Active & LOAD.Active;
        }

    }
}
