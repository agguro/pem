using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;

namespace PEM3
{
    public partial class IOPort : PEM.IC
    {
        private Databus _in = new Databus();
        private Databus _out = new Databus();
        private Connection _enable = new Connection();

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
                    _in.StateChanged += Execute;
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
                    _out.StateChanged += Execute;
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

        public IOPort()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            _out.Active = _in.Active & _enable.Active;
            Active = _enable.Active;
        }
        
    }
}
