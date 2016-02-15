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
    public partial class FormPEM2InstructionSet : Form
    {
        public FormPEM2InstructionSet()
        {
            InitializeComponent();
            DataSet ds = new DataSet();
            using (ds)
            {
                string xmlpath = @"instructionsets/pem2.xml";
                try
                {
                    ds.ReadXml(xmlpath);
                    grid.DataSource = ds;
                    grid.DataMember = "instruction";
                    grid.Dock = DockStyle.Fill;
                    grid.Font = new Font(FontFamily.GenericMonospace, 10);
                    grid.AutoResizeColumns();
                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    grid.RowHeadersVisible = false;
                    grid.ReadOnly = true;
                    this.Controls.Add(grid);
                }
                catch
                {
                    MessageBox.Show("Instruction set file pem2.xml cannot be found.\nTo solve this issue, contact the vendor.","PEM 2 instruction set not found");
                }
            }
        }

        
    }
}
