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
    public partial class IndexRegister : PEM2.IndexRegister
    {

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

        public IndexRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
            _io.Active = Active;
        }
    }
}
