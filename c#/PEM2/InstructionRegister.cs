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
    public partial class InstructionRegister : PEM1.InstructionRegister
    {
        public InstructionRegister()
        {
            InitializeComponent();
        }

        protected override void Execute(object sender, EventArgs e)
        {
            base.Execute(sender, e);
        }
    }
}
