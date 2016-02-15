using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEMCollection
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ShowChildForm(object form)
        {
            ((Form)form).MdiParent = this;
            ((Form)form).Show();
        }
        private void pem1ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM1Components());
        }
        private void pem1BlockdiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM1Blockdiagram());
        }

        private void pem2ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM2Components());
        }

        private void pem2BlockdiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM2Blockdiagram());
        }

        private void pem1InstructionsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM1InstructionSet());
        }

        private void pem2InstructionsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM2InstructionSet());
        }

        private void pem3IstructionsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM3InstructionSet());
        }

        private void pem3BlockdiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM3Blockdiagram());
        }

        private void pem3ComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowChildForm(new ChildForms.FormPEM3Components());
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://agguro.org/index.php/home/projects/microprocessor-simulation");
            }
            catch { }
        }
    }
}
