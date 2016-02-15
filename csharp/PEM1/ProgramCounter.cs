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
    public partial class ProgramCounter : IC
    {

        private Connection _enable = new Connection();
        private Connection _count = new Connection();
        private Connection _clk = new Connection();
        private Connection _clr = new Connection();
        private Databus _out = new Databus();
        private uint _addresslines;
        private uint _address = 0;

        public string AddressAsBinary
        {
            get
            {
                string result = Convert.ToString(_address, 2);
                string binary = string.Empty;
                for(int i = 0; i < _addresslines; i++)
                {
                    binary = binary + "0";
                }
                result = binary.Substring(0, (int)_addresslines - result.Length) + result;
                return result;
            }
            
        }

        public uint Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                // check if the given value is to big, if so then we subtract the max number from this value.
                // the new number will be the new address.
                uint maxaddress = (uint)(Math.Pow(2, (double)_addresslines) - 1);
                if (_address > maxaddress)
                {
                    _address -= maxaddress;
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

        public Connection COUNT
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
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

        public virtual Connection CLR
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
                    //Execute(this, EventArgs.Empty);
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

        public ProgramCounter()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {    
            if (_clr.Active)
            {
                _address = 0;
            }
            else
            {
                if (_clk.Active & _count.Active)
                {
                    _address++;
                    if (_address > (Math.Pow((double)2,(double)_addresslines) - 1))
                    {
                        _address = 0;
                    };
                }
            }
            Active = _clr.Active | _clk.Active;
            _out.Active = _enable.Active & _clk.Active;
        }

        [Browsable(false)]
        public uint AddressLines
        {
            get
            {
                return _addresslines;
            }
            set
            {
                _addresslines = value;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.Invalidate();
            base.OnResize(e);
        }

    }
}
