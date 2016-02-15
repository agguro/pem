using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;

namespace PEMCollection.ChildForms
{
    public partial class FormPEM2Components : Form
    {
        string title = "PEM 2 - Components";
        int aluOperationlines = 0;

        public FormPEM2Components()
        {
            InitializeComponent();
        }

        private void SetFormTitle(Label destination)
        {
            Text = title + " - " + destination.Text;
            destination.Location = new Point(0, 10);
            destination.AutoSize = true;
            destination.Width = Width;
            destination.Height = 60;
            destination.AutoSize = false;
            destination.TextAlign = ContentAlignment.MiddleCenter;
            destination.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ToggleState(Label label, PEM.Connection connection)
        {
            connection.Active = !connection.Active;
            label.ForeColor = connection.CurrentColor;
        }

        private void tabPageSC_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelSCTitle);
        }

        private void tabPagePC_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelPCTitle);
        }

        private void tabPageMAR_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelMARTitle);
        }

        private void tabPageRAM_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelRAMTitle);
        }

        private void tabPageMDR_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelMDRTitle);
        }

        private void tabPageIR_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelIRTitle);
        }

        private void tabPageCON_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelCONTitle);
        }

        private void tabPageI_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelITitle);
        }

        private void tabPageA_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelATitle);
        }

        private void tabPageALU_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelALUTitle);
        }

        private void tabPageB_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelBTitle);
        }

        private void tabPageX_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelXTitle);
        }

        private void tabPageO_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelOTitle);
        }

        private void tabPagePC_Click(object sender, EventArgs e)
        {

        }

        private void tabPageRAM_Click(object sender, EventArgs e)
        {

        }

        private void btnLSsc_Click(object sender, EventArgs e)
        {
            ToggleState(lblLSsc, connLSsc);
        }

        private void btnCSsc_Click(object sender, EventArgs e)
        {
            ToggleState(lblCSsc, connCSsc);
        }

        private void btnCLKsc_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKsc, connCLKsc);
        }

        private void btnESsc_Click(object sender, EventArgs e)
        {
            ToggleState(lblESsc, connESsc);
        }

        private void SC_StateChanged(object sender, EventArgs e)
        {
            lblSCounter.Text = SC.AddressAsBinary;
        }
        private void PC_StateChanged(object sender, EventArgs e)
        {
            lblPCounter.Text = PC.AddressAsBinary;
        }

        private void btnLPpc_Click(object sender, EventArgs e)
        {
            ToggleState(lblLPpc, connLPpc);
        }

        private void btnCPpc_Click(object sender, EventArgs e)
        {
            ToggleState(lblCPpc, connCPpc);
        }

        private void btnCLKpc_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKpc, connCLKpc);
        }

        private void btnCLRpc_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRpc, connCLRpc);
        }

        private void btnEPpc_Click(object sender, EventArgs e)
        {
            ToggleState(lblEPpc, connEPpc);
        }

        private void btnLMmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblLMmar, connLMmar);
        }

        private void btnCLKmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKmar, connCLKmar);
        }

        private void btnWEram_Click(object sender, EventArgs e)
        {
            ToggleState(lblWEram, connWEram);
        }

        private void btnMEram_Click(object sender, EventArgs e)
        {
            ToggleState(lblMEram, connMEram);
        }

        private void btnLDmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblLDmdr, connLDmdr);
        }

        private void btnCLKmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKmdr, connCLKmdr);
        }

        private void btnEDmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblEDmdr, connEDmdr);
        }

        private void btnLIir_Click(object sender, EventArgs e)
        {
            ToggleState(lblLIir, connLIir);
        }

        private void btnCLKir_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKir, connCLKir);
        }

        private void btnCLRir_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRir, connCLRir);
        }

        private void btnEIir_Click(object sender, EventArgs e)
        {
            ToggleState(lblEIir, connEIir);
        }

        private void btnONcon_Click(object sender, EventArgs e)
        {
            if (CON.Active)
            {
                btnONcon.Text = "OFF";
                CON.Active = false;
                btnCLKcon.Enabled = false;
                btnCLRcon.Enabled = false;
            }
            else
            {
                btnONcon.Text = "ON";
                CON.Active = true;
                btnCLKcon.Enabled = true;
                btnCLRcon.Enabled = true;
            }
        }

        private void btnCLKcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKcon, connCLKcon);
            dbir2concon.Active = connCLKcon.Active;
        }

        private void btnCLRcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRcon, connCLRcon);
        }

        private void btnLNi_Click(object sender, EventArgs e)
        {
            ToggleState(lblLNi, connLNi);
        }

        private void btnCLKi_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKi, connCLKi);
        }

        private void btnENi_Click(object sender, EventArgs e)
        {
            ToggleState(lblENi, connENi);
        }

        private void btnLAa_Click(object sender, EventArgs e)
        {
            ToggleState(lblLAa, connLAa);
        }

        private void btnCLKa_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKa, connCLKa);
        }

        private void btnEAa_Click(object sender, EventArgs e)
        {
            ToggleState(lblEAa, connEAa);
        }






        private void btnLXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblLXx, connLXx);
        }

        private void btnCLKx_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKx, connCLKx);
            if (connCLKx.Active)
            {
                // exclusive OR one of both but not both or nothing
                if ((!connINXx.Active && connDEXx.Active) || (connINXx.Active && !connDEXx.Active))
                {
                    if (connDEXx.Active)
                    {
                        lblXoperation.Text = "X = X - 1";
                    }
                    if (connINXx.Active)
                    {
                        lblXoperation.Text = "X = X + 1";
                    }
                    lblXoperation.Visible = true;
                }
                else
                {
                    lblXoperation.Visible = false;     // not allowed situation
                }
            }
            else
            {
                lblXoperation.Visible = false;
            }
        }

        private void btnEXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblEXx, connEXx);
        }

        private void btnINXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblINXx, connINXx);
        }

        private void btnDEXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblDEXx, connDEXx);
        }

        private void btnEUalu_Click(object sender, EventArgs e)
        {
            ToggleState(lblEUalu, connEUalu);
        }

        private void btnS0alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS0alu, connS0alu);
            AluOperation();
        }

        private void btnS1alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS1alu, connS1alu);
            AluOperation();
        }

        private void btnS2alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS2alu, connS2alu);
            AluOperation();
        }

        private void btnS3alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS3alu, connS3alu);
            AluOperation();
        }

        private void AluOperation()
        {
            aluOperationlines = 0;
            string operation = string.Empty;
            if (connS0alu.Active) { aluOperationlines++; };
            if (connS1alu.Active) { aluOperationlines = aluOperationlines + 2; };
            if (connS2alu.Active) { aluOperationlines = aluOperationlines + 4; };
            if (connS3alu.Active) { aluOperationlines = aluOperationlines + 8; };
            if (aluOperationlines > 0 && aluOperationlines < 10)
            {
                switch (aluOperationlines)
                {
                    case 1:
                        {
                            operation = "ADD";
                            break;
                        }
                    case 2:
                        {
                            operation = "SUB";
                            break;
                        }
                    case 3:
                        {
                            operation = "CMA";
                            break;
                        }
                    case 4:
                        {
                            operation = "CMB";
                            break;
                        }
                    case 5:
                        {
                            operation = "IOR";
                            break;
                        }
                    case 6:
                        {
                            operation = "AND";
                            break;
                        }
                    case 7:
                        {
                            operation = "NOR";
                            break;
                        }
                    case 8:
                        {
                            operation = "NAN";
                            break;
                        }
                    case 9:
                        {
                            operation = "XOR";
                            break;
                        }
                }
            }
            else
            {
                operation = "Undefined";
            }
            lblALUOperation.Text = operation;
        }

        private void btnLBb_Click(object sender, EventArgs e)
        {
            ToggleState(lblLBb, connLBb);

        }

        private void btnCLKb_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKb, connCLKb);
        }

        private void btnLOo_Click(object sender, EventArgs e)
        {
            ToggleState(lblLOo, connLOo);

        }

        private void btnCLKo_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKo, connCLKo);
        }
    }
}
