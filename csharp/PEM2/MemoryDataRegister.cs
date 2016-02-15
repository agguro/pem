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
    public partial class MemoryDataRegister : PEM2.MemoryAddressRegister
    {
        private PEM.Connection _enable = new PEM.Connection();
        private PEM.Databus _out = new PEM.Databus();

        public PEM.Connection ENABLE
        {
            get
            {
                return _enable;
            }
            set
            {
                _enable = value;
                if(value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Databus OUT
        {
            get
            {
                return _out;
            }
            set
            {
                _out = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public MemoryDataRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            Active = Active | (CLK.Active & ENABLE.Active);
            OUT.Active = Active & CLK.Active & ENABLE.Active;

        }
    }
}
