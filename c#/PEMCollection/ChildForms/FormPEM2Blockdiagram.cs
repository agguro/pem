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
    public partial class FormPEM2Blockdiagram : Form
    {
        public FormPEM2Blockdiagram()
        {
            InitializeComponent();
        }

        private void lblCLK_Click(object sender, EventArgs e)
        {
            connCLK.Active = !connCLK.Active;
        }

        private void lblCLR_Click(object sender, EventArgs e)
        {
            connCLR.Active = !connCLR.Active;
        }

        private void connCLK_StateChanged(object sender, EventArgs e)
        {
            if (connCLK.Active)
            {
                lblCLK.ForeColor = connCLK.ActiveColor;
                lblCLKa.ForeColor = connCLKa.ActiveColor;
                lblCLKb.ForeColor = connCLKb.ActiveColor;
                lblCLKi.ForeColor = connCLKi.ActiveColor;
                lblCLKir.ForeColor = connCLKir.ActiveColor;
                lblCLKmar.ForeColor = connCLKmar.ActiveColor;
                lblCLKmdr.ForeColor = connCLKmdr.ActiveColor;
                lblCLKo.ForeColor = connCLKo.ActiveColor;
                lblCLKpc.ForeColor = connCLKpc.ActiveColor;
                lblCLKsc.ForeColor = connCLKsc.ActiveColor;
                lblCLKx.ForeColor = connCLKx.ActiveColor;
            }
            else
            {
                lblCLK.ForeColor = connCLK.InactiveColor;
                lblCLKa.ForeColor = connCLKa.InactiveColor;
                lblCLKb.ForeColor = connCLKb.InactiveColor;
                lblCLKi.ForeColor = connCLKi.InactiveColor;
                lblCLKir.ForeColor = connCLKir.InactiveColor;
                lblCLKmar.ForeColor = connCLKmar.InactiveColor;
                lblCLKmdr.ForeColor = connCLKmdr.InactiveColor;
                lblCLKo.ForeColor = connCLKo.InactiveColor;
                lblCLKpc.ForeColor = connCLKpc.InactiveColor;
                lblCLKsc.ForeColor = connCLKsc.InactiveColor;
                lblCLKx.ForeColor = connCLKx.InactiveColor;
            }
        }

        private void connCLR_StateChanged(object sender, EventArgs e)
        {
            if (connCLR.Active)
            {
                lblCLR.ForeColor = connCLR.ActiveColor;
                lblCLRir.ForeColor = connCLRir.ActiveColor;
                lblCLRpc.ForeColor = connCLRpc.ActiveColor;
            }
            else
            {
                lblCLR.ForeColor = connCLR.InactiveColor;
                lblCLRir.ForeColor = connCLRir.InactiveColor;
                lblCLRpc.ForeColor = connCLRpc.InactiveColor;
            }
        }

        private void ToggleState(Label label, PEM.Connection connection)
        {
            connection.Active = !connection.Active;
            label.ForeColor = connection.CurrentColor;
        }

        private void lblIln_Click(object sender, EventArgs e)
        {
            connLN.Active = !connLN.Active;
            lblIln.ForeColor = connLN.CurrentColor;
        }

        private void lblLS_Click(object sender, EventArgs e)
        {
            ToggleState(lblLS, connLS);
        }

        private void lblCS_Click(object sender, EventArgs e)
        {
            ToggleState(lblCS, connCS);
        }

        private void lblES_Click(object sender, EventArgs e)
        {
            ToggleState(lblES, connES);
        }

        private void lblLP_Click(object sender, EventArgs e)
        {
            ToggleState(lblLP, connLP);
        }

        private void lblCP_Click(object sender, EventArgs e)
        {
            ToggleState(lblCP, connCP);
        }

        private void lblEP_Click(object sender, EventArgs e)
        {
            ToggleState(lblEP, connEP);
        }

        private void lblLM_Click(object sender, EventArgs e)
        {
            ToggleState(lblLM, connLM);
        }

        private void lblLD_Click(object sender, EventArgs e)
        {
            ToggleState(lblLD, connLD);
        }

        private void lblED_Click(object sender, EventArgs e)
        {
            ToggleState(lblED, connED);
        }

        private void lblWE_Click(object sender, EventArgs e)
        {
            ToggleState(lblWE, connWE);
        }

        private void lblME_Click(object sender, EventArgs e)
        {
            ToggleState(lblME, connME);
        }

        private void lblLI_Click(object sender, EventArgs e)
        {
            ToggleState(lblLI, connLI);
        }

        private void lblEI_Click(object sender, EventArgs e)
        {
            ToggleState(lblEI, connEI);
        }

        private void lblAMINUS_Click(object sender, EventArgs e)
        {
            ToggleState(lblAMINUScon, connAMINUScon);
            ToggleState(lblAMINUSa, connAMINUSa);
        }

        private void lblAZERO_Click(object sender, EventArgs e)
        {
            ToggleState(lblAZEROcon, connAZEROcon);
            ToggleState(lblAZEROa, connAZEROa);
        }

        private void lblXMINUS_Click(object sender, EventArgs e)
        {
            ToggleState(lblXMINUScon, connXMINUScon);
            ToggleState(lblXMINUSx, connXMINUSx);
        }

        private void lblXZERO_Click(object sender, EventArgs e)
        {
            ToggleState(lblXZEROcon, connXZEROcon);
            ToggleState(lblXZEROx, connXZEROx);
        }

        private void lblEN_Click(object sender, EventArgs e)
        {
            ToggleState(lblEN, connEN);
        }

        private void lblLA_Click(object sender, EventArgs e)
        {
            ToggleState(lblLA, connLA);
        }

        private void lblEA_Click(object sender, EventArgs e)
        {
            ToggleState(lblEA, connEA);
        }

        private void lblS3_Click(object sender, EventArgs e)
        {
            ToggleState(lblS3, connS3);
        }

        private void lblS2_Click(object sender, EventArgs e)
        {
            ToggleState(lblS2, connS2);
        }

        private void lblS1_Click(object sender, EventArgs e)
        {
            ToggleState(lblS1, connS1);
        }

        private void lblS0_Click(object sender, EventArgs e)
        {
            ToggleState(lblS0, connS0);
        }

        private void lblEU_Click(object sender, EventArgs e)
        {
            ToggleState(lblEU, connEU);
        }

        private void lblLB_Click(object sender, EventArgs e)
        {
            ToggleState(lblLB, connLB);
        }

        private void lblLX_Click(object sender, EventArgs e)
        {
            ToggleState(lblLX, connLX);
        }

        private void lblINX_Click(object sender, EventArgs e)
        {
            ToggleState(lblINX, connINX);
        }

        private void lblDEX_Click(object sender, EventArgs e)
        {
            ToggleState(lblDEX, connDEX);
        }

        private void lblEX_Click(object sender, EventArgs e)
        {
            ToggleState(lblEX, connEX);
        }

        private void lblLO_Click(object sender, EventArgs e)
        {
            ToggleState(lblLO, connLO);
        }

        private void SC_StateChanged(object sender, EventArgs e)
        {
            lblSCounter.Text = SC.AddressAsBinary;
        }

        private void PC_StateChanged(object sender, EventArgs e)
        {
            lblPCounter.Text = PC.AddressAsBinary;
        }




    }
}
