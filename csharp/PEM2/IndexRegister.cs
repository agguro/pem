using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;

namespace PEM2
{
    public partial class IndexRegister : Accumulator
    {
        private PEM.Connection _dex = new PEM.Connection();
        private PEM.Connection _inx = new PEM.Connection();

        [Browsable(false)]
        [ReadOnly(true)]
        public new Databus ALU
        {
            get;
            set;
        }

        public PEM.Connection DEX
        {
            get
            {
                return _dex;
            }
            set
            {
                _dex = value;
                if (value != null)
                {
                    _dex.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public PEM.Connection INX
        {
            get
            {
                return _inx;
            }
            set
            {
                _inx = value;
                if (value != null)
                {
                    _inx.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public IndexRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
        }
    }
}
