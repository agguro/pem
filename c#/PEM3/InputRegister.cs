using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM2;

namespace PEM3
{
    public partial class InputRegister : PEM2.InputRegister
    {
        public InputRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
        }
    }
}
