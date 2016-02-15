using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;
using PEM1;

namespace PEM2
{
    public partial class ALU : PEM1.ALU
    {
        private PEM.Connection _s0 = new PEM.Connection();
        private PEM.Connection _s2 = new PEM.Connection();
        private PEM.Connection _s3 = new PEM.Connection();

        [Browsable(false)]
        [ReadOnly(true)]
        public new PEM.Connection SUBTRACT
        {
            get;
            private set;
        }

        public PEM.Connection S0
        {
            get
            {
                return _s0;
            }
            set
            {
                _s0 = value;
                if (value != null)
                {
                    _s0.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public PEM.Connection S1
        {
            get
            {
                return base.SUBTRACT;
            }
            set
            {
                base.SUBTRACT = value;
            }
        }

        public PEM.Connection S2
        {
            get
            {
                return _s2;
            }
            set
            {
                _s2 = value;
                if (value != null)
                {
                    _s2.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public PEM.Connection S3
        {
            get
            {
                return _s3;
            }
            set
            {
                _s3 = value;
                if (value != null)
                {
                    _s3.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public ALU()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
        }
    }
}
