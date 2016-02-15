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
    public partial class ALU : IC
    {
        Connection _s1 = new Connection();
        Connection _enable = new Connection();
        Databus _a = new Databus();
        Databus _b = new Databus();
        Databus _out = new Databus();

        public Connection SUBTRACT
        {
            get
            {
                return _s1;
            }
            set
            {
                _s1 = value;
                if (value != null)
                {
                    _s1.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
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
                    _enable.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public Databus A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
                if (value != null)
                {
                    _a.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public Databus B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
                if (value != null)
                {
                    _b.StateChanged += Execute;
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
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

        protected override void Execute(object sender,EventArgs e)
        {
            Active = _enable.Active;
            _out.Active = _enable.Active;
        }
    }
}
