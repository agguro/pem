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
    public partial class PROM : IC
    {
        private Connection _me = new Connection();
        private Databus _memory = new Databus();
        private Databus _out = new Databus();

        public Connection ME
        {
            get
            {
                return _me;
            }
            set
            {
                _me = value;
                if (value != null)
                {
                    _me.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus MAR
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

        public PROM()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            Active = _me.Active;
            _out.Active = _me.Active;
        }
    }
}
