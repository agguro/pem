using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEM2
{
    public partial class ControlUnit : PEM1.ControlUnit
    {

        [Browsable(false)]
        public override PEM.Connection Ep
        {
            get;
            set;
        }

        [Browsable(false)]
        public override PEM.Connection Su
        {
            get;
            set;
        }

        private PEM.Connection _ls = new PEM.Connection();
        public PEM.Connection Ls
        {
            get; set;
        }

        private PEM.Connection _cs = new PEM.Connection();
        public PEM.Connection Cs
        {
            get; set;
        }

        private PEM.Connection _es = new PEM.Connection();
        public PEM.Connection Es
        {
            get; set;
        }

        private PEM.Connection _lp = new PEM.Connection();
        public PEM.Connection Lp
        {
            get; set;
        }

        private PEM.Connection _we = new PEM.Connection();
        public PEM.Connection WE
        {
            get; set;
        }

        private PEM.Connection _me = new PEM.Connection();
        public PEM.Connection ME
        {
            get; set;
        }

        private PEM.Connection _ld = new PEM.Connection();
        public PEM.Connection Ld
        {
            get; set;
        }

        private PEM.Connection _ed = new PEM.Connection();
        public PEM.Connection Ed
        {
            get; set;
        }

        private PEM.Connection _aminus = new PEM.Connection();
        public PEM.Connection AMinus
        {
            get; set;
        }

        private PEM.Connection _azero = new PEM.Connection();
        public PEM.Connection AZero
        {
            get; set;
        }
        private PEM.Connection _xminus = new PEM.Connection();
        public PEM.Connection XMinus
        {
            get; set;
        }
        private PEM.Connection _xzero = new PEM.Connection();
        public PEM.Connection XZero
        {
            get; set;
        }

        private PEM.Connection _ln = new PEM.Connection();
        public PEM.Connection Ln
        {
            get; set;
        }
        private PEM.Connection _en = new PEM.Connection();
        public PEM.Connection En
        {
            get; set;
        }

        private PEM.Connection _s0 = new PEM.Connection();
        public PEM.Connection S0
        {
            get; set;
        }
        private PEM.Connection _s1 = new PEM.Connection();
        public PEM.Connection S1
        {
            get; set;
        }
        private PEM.Connection _s2 = new PEM.Connection();
        public PEM.Connection S2
        {
            get; set;
        }
        private PEM.Connection _s3 = new PEM.Connection();
        public PEM.Connection S3
        {
            get; set;
        }
        private PEM.Connection _lx = new PEM.Connection();
        public PEM.Connection Lx
        {
            get; set;
        }
        private PEM.Connection _inx = new PEM.Connection();
        public PEM.Connection INX
        {
            get; set;
        }
        private PEM.Connection _dex = new PEM.Connection();
        public PEM.Connection DEX
        {
            get; set;
        }
        private PEM.Connection _ex = new PEM.Connection();
        public PEM.Connection Ex
        {
            get; set;
        }

        public ControlUnit()
        {
            InitializeComponent();
        }
    }
}
