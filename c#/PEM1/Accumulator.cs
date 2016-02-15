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
    public partial class Accumulator : IC
    {
        private Connection _clk = new Connection();
        private Connection _load = new Connection();
        private Connection _enable = new Connection();
        private Databus _in = new Databus();
        private Databus _out = new Databus();
        private Databus _alu = new Databus();

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

        public Connection LOAD
        {
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

        public Databus ALU
        {
            get
            {
                return _alu;
            }
            set
            {
                _alu = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Accumulator()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            Active = _clk.Active;
            _alu.Active = Active;
            _out.Active = _clk.Active & _enable.Active;
            _in.Active = _clk.Active & _load.Active;
        }
    }
}
