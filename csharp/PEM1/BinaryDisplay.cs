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
    public partial class BinaryDisplay : IC
    {
        private Databus _in = new Databus();

        public Databus IN
        {
            get
            {
                return _in;
            }
            set
            {
                _in = value;
                if(value != null)
                {
                    _in.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public BinaryDisplay()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            Active = _in.Active;
        }
    }
}
