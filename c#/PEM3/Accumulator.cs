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
    public partial class Accumulator : PEM2.Accumulator
    {
        private PEM.Connection _shl = new PEM.Connection();
        private PEM.Connection _shr = new PEM.Connection();
        private PEM.Connection _ral = new PEM.Connection();
        private PEM.Connection _rar = new PEM.Connection();
        private PEM.Databus _io = new PEM.Databus();

        [Browsable(false)]
        [ReadOnly(true)]
        public new Databus IN
        {
            get;
            set;
        }
        
        [Browsable(false)]
        [ReadOnly(true)]
        public new Databus OUT
        {
            get;
            set;
        }

        public PEM.Connection SHL
        {
            get
            {
                return _shl;
            }
            set
            {
                _shl = value;
                //_shl.StateChanged += Execute;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Connection SHR
        {
            get
            {
                return _shr;
            }
            set
            {
                _shr = value;
                //_shr.StateChanged += Execute;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Connection RAL
        {
            get
            {
                return _ral;
            }
            set
            {
                _ral = value;
                //_ral.StateChanged += Execute;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
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

        public PEM.Connection RAR
        {
            get
            {
                return _rar;
            }
            set
            {
                _rar = value;
                //_rar.StateChanged += Execute;
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
            base.Execute(sender, e);
            //Active = Active | _shl.Active | _shr.Active | _ral.Active | _rar.Active;
            _io.Active = Active & (LOAD.Active | ENABLE.Active);
            ALU.Active = Active;
        }
    }
}
