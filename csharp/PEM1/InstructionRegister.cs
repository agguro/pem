using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;

namespace PEM1
{
    [ToolboxItem(true)]
    public partial class InstructionRegister : IC
    {
        private Connection _load = new Connection();
        private Connection _enable = new Connection();
        private Connection _clk = new Connection();
        private Connection _clr = new Connection();
        private Databus _outcon = new Databus();
        private Databus _in = new Databus();
        private Databus _out = new Databus();

        public Connection LOAD{
            get
            {
                return _load;
            }
            set
            {
                _load = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Connection CLK
        {
            get
            {
                return _clk;
            }
            set
            {
                _clk = value;
                if (value != null)
                {
                    _clk.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Connection CLR
        {
            get
            {
                return _clr;
            }
            set
            {
                _clr = value;
                if (value != null)
                {
                    _clr.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Connection ENABLE
        {
            get
            {
                return _enable;
            }
            set
            {
                _enable = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus IN
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

        public Databus CON
        {
            get
            {
                return _outcon;
            }
            set
            {
                _outcon = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OUT
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

        public InstructionRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            Active = _clr.Active | _clk.Active;
            _outcon.Active = Active;
            _out.Active = _enable.Active & _clk.Active;
            _in.Active = _load.Active & _clk.Active;
        }

    }
}
