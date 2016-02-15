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
    public partial class Stack : PEM2.ProgramCounter
    {
        private PEM.Connection _pu = new PEM.Connection();
        private PEM.Connection _pd = new PEM.Connection();
        private PEM.Connection _ipl = new PEM.Connection();
        private PEM.Databus _io = new PEM.Databus();
        
        [Browsable(false)]
        [ReadOnly(true)]
        public new PEM.Databus IN
        {
            get;
            set;
        }

        [Browsable(false)]
        [ReadOnly(true)]
        public new PEM.Databus OUT
        {
            get;
            set;
        }
        
        public PEM.Databus IO
        {
            get
            {
                return _io;
            }
            set
            {
                _io = value;
                IN = _io;
                OUT = _io;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }
        public PEM.Connection PU
        {
            get
            {
                return _pu;
            }
            set
            {
                _pu = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Connection PD
        {
            get
            {
                return _pd;
            }
            set
            {
                _pd = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

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

        public Stack()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            _io.Active = CLK.Active & LOAD.Active | CLK.Active & ENABLE.Active;
            Active = Active | CLK.Active & PU.Active | CLK.Active & PD.Active | CLK.Active & IPL.Active;

        }
    }
}
