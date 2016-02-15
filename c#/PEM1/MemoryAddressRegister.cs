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
    public partial class MemoryAddressRegister : IC
    {
        private Connection _load = new Connection();
        private Connection _clk = new Connection();
        private Databus _memory = new Databus();
        private Databus _in = new Databus();

        public virtual Connection LOAD
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

        public Databus MEMORY
        {
            get
            {
                return _memory;
            }
            set
            {
                _memory = value;
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
            Active = _clk.Active; // &_load.Active;
            _in.Active = _clk.Active & _load.Active;
            _memory.Active = _clk.Active;
        }
    }
}
