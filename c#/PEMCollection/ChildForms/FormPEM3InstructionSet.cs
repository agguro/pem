using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEMCollection.ChildForms
{
    public partial class FormPEM3InstructionSet : Form
    {
        public FormPEM3InstructionSet()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            using (ds)
            {
                string xmlpath = @"instructionsets/pem3.xml";
                try
                {
                    ds.ReadXml(xmlpath);
                    grid.DataSource = ds;
                    grid.DataMember = "instruction";
                    grid.Dock = DockStyle.Fill;
                    grid.Font = new Font(FontFamily.GenericMonospace, 10);
                    grid.Enabled = true;
                    grid.AutoResizeColumns();
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    grid.RowHeadersVisible = false;
                    grid.ReadOnly = true;
                    this.Controls.Add(grid);
                }
                catch
                {
                    MessageBox.Show("Instruction set file pem3.xml cannot be found. To solve this issue, contact the vendor.", "PEM 3 instruction set not found");
                }
            }
        }

        
        
    }
}
