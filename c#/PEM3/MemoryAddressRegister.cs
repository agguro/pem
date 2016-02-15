using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;
using PEM2;

namespace PEM3
{
    public partial class MemoryAddressRegister : PEM2.MemoryAddressRegister
    {
        private PEM.Connection _ipl = new PEM.Connection();

        public PEM.Connection IPL
        {
            get
            {
                return _ipl;
            }
            set
            {
                _ipl = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public MemoryAddressRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            Active = Active | CLK.Active & _ipl.Active;
        }
    }
}
