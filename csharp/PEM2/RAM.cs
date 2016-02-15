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
    public partial class RAM : PEM1.PROM
    {
        private PEM.Connection _we = new PEM.Connection();
        private PEM.Databus _mdr = new PEM.Databus();

        
        public PEM.Connection WE
        {
            get
            {
                return _we;
            }
            set
            {
                _we = value;
                if (value != null)
                {
                    _we.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Databus MDR
        {
            get
            {
                return _mdr;
            }
            set
            {
                _mdr = value;
            }
        }

        public RAM()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            Active = Active | _we.Active;
            OUT.Active = Active & !_we.Active;
            _mdr.Active = Active & _we.Active & ME.Active;
        }
    }
}
