using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;
using PEM1;

namespace PEM2
{
    public partial class Accumulator : PEM1.Accumulator
    {
        private PEM.Connection _minus = new PEM.Connection();
        private PEM.Connection _zero = new PEM.Connection();

        public PEM.Connection MINUS
        {
            get
            {
                return _minus;
            }
            set
            {
                _minus = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public PEM.Connection ZERO
        {
            get
            {
                return _zero;
            }
            set
            {
                _zero = value;
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
        }
    }
}
