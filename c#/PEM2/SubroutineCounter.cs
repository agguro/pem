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
    public partial class SubroutineCounter : PEM2.ProgramCounter
    {
        [Browsable(false)]
        [ReadOnly(true)]
        public override PEM.Connection CLR
        {
            get;
            set;
        }

        public SubroutineCounter()
        {
            InitializeComponent();
        }
    }
}
