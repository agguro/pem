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
    public partial class FormPEM3Components : Form
    {

        string title = "PEM 3 - Components";
        // this must be implemented in the stack component, for demonstration purposes I've put it here temporarly
        int aluOperationlines = 0;

        int pu = 0;
        uint addressC0 = 0;
        uint addressC1 = 0;
        uint addressC2 = 0;
        uint addressC3 = 0;

        public FormPEM3Components()
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

        private void tabPageINPORT_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelINPORTTitle);
        }

        private void tabPageOUTPORT_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelOUTPORTTitle);
        }

        private void tabPageIN_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelITitle);
        }

        private void tabPageO_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelOTitle);
        }

        private void tabPageStack_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelSTitle);
            labelCounter0.ForeColor = STACK.ActiveColor;
            labelC0iplstack.ForeColor = STACK.ActiveColor;
            labelC0noiplstack.ForeColor = STACK.ActiveColor;
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

        private void btnEinport_Click(object sender, EventArgs e)
        {
            ToggleState(lblEinport, connEinport);
        }

        private void btnWinport_Click(object sender, EventArgs e)
        {
            dbworld2inport.Active = !dbworld2inport.Active;
        }

        private void btnLoutport_Click(object sender, EventArgs e)
        {
            ToggleState(lblLoutport, connLoutport);
        }

        private void btnIOoutport_Click(object sender, EventArgs e)
        {
            dbiobus2outport.Active = !dbiobus2outport.Active;
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

        private void btnLOo_Click(object sender, EventArgs e)
        {
            ToggleState(lblLOo, connLOo);
        }

        private void btnCLKo_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKo, connCLKo);
        }

        private void btnEOo_Click(object sender, EventArgs e)
        {
            ToggleState(lblEOo, connEOo);
        }

        private void btnPUstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblPUstack, connPUstack);
        }

        private void btnPDstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblPDstack, connPDstack);
        }

        private void btnIPLstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblIPLstack, connIPLstack);
        }

        private void btnCLKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKstack, connCLKstack);
        }

        private void btnCLRstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRstack, connCLRstack);
        }

        private void btnLKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblLKstack, connLKstack);
        }

        private void btnCKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCKstack, connCKstack);
        }

        private void btnEKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblEKstack, connEKstack);
        }

        private void STACK_StateChanged(object sender, EventArgs e)
        {

            if (connPUstack.Active & connLKstack.Active & connCLKstack.Active)
            {
                pu++;
                if (pu > 3)
                {
                    pu = 0;
                }
                switch (pu)
                {
                    case 0:
                        {
                            addressC0 = STACK.Address;
                            STACK.Address = 1703;
                            labelC0iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                            labelC0noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                            break;
                        }
                    case 1:
                        {
                            addressC1 = STACK.Address;
                            STACK.Address = 2000;
                            labelC1iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                            labelC1noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                            break;
                        }
                    case 2:
                        {
                            addressC2 = STACK.Address;
                            STACK.Address = 3000;
                            labelC2iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                            labelC2noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                            break;
                        }
                    case 3:
                        {
                            addressC3 = STACK.Address;
                            STACK.Address = 4000;
                            labelC3iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                            labelC3noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                            break;
                        }
                }
            }

            if (connPDstack.Active & connCLKstack.Active)
            {
                pu--;

                if (pu < 0)
                {
                    pu = 3;
                }
                switch (pu)
                {
                    case 0:
                        {
                            STACK.Address = addressC1;
                            break;
                        }
                    case 1:
                        {
                            STACK.Address = addressC2;
                            break;
                        }
                    case 2:
                        {
                            STACK.Address = addressC3;
                            break;
                        }
                    case 3:
                        {
                            STACK.Address = addressC0;
                            break;
                        }
                }
            }
            switch (pu)
            {
                case 0:
                    {
                        labelC0iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                        labelC0noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                        break;
                    }
                case 1:
                    {
                        labelC1iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                        labelC1noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                        break;
                    }
                case 2:
                    {
                        labelC2iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                        labelC2noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                        break;
                    }
                case 3:
                    {
                        labelC3iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                        labelC3noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                        break;
                    }
            }
            HighLightCurrentCounter();
        }

        private void HighLightCurrentCounter()
        {
            labelCounter0.ForeColor = STACK.InactiveColor;
            labelCounter1.ForeColor = STACK.InactiveColor;
            labelCounter2.ForeColor = STACK.InactiveColor;
            labelCounter3.ForeColor = STACK.InactiveColor;

            labelC0iplstack.ForeColor = STACK.InactiveColor;
            labelC0noiplstack.ForeColor = STACK.InactiveColor;
            labelC1iplstack.ForeColor = STACK.InactiveColor;
            labelC1noiplstack.ForeColor = STACK.InactiveColor;
            labelC2iplstack.ForeColor = STACK.InactiveColor;
            labelC2noiplstack.ForeColor = STACK.InactiveColor;
            labelC3iplstack.ForeColor = STACK.InactiveColor;
            labelC3noiplstack.ForeColor = STACK.InactiveColor;
            switch (pu)
            {
                case 0:
                    {
                        labelCounter0.ForeColor = STACK.ActiveColor;
                        if (!connIPLstack.Active)
                        {
                            labelC0iplstack.ForeColor = STACK.ActiveColor;
                        }
                        labelC0noiplstack.ForeColor = STACK.ActiveColor;
                        break;
                    }
                case 1:
                    {
                        labelCounter1.ForeColor = STACK.ActiveColor;
                        if (!connIPLstack.Active)
                        {
                            labelC1iplstack.ForeColor = STACK.ActiveColor;
                        }
                        labelC1noiplstack.ForeColor = STACK.ActiveColor;
                        break;
                    }
                case 2:
                    {
                        labelCounter2.ForeColor = STACK.ActiveColor;
                        if (!connIPLstack.Active)
                        {
                            labelC2iplstack.ForeColor = STACK.ActiveColor;
                        }
                        labelC2noiplstack.ForeColor = STACK.ActiveColor;
                        break;
                    }
                case 3:
                    {
                        labelCounter3.ForeColor = STACK.ActiveColor;
                        if (!connIPLstack.Active)
                        {
                            labelC3iplstack.ForeColor = STACK.ActiveColor;
                        }
                        labelC3noiplstack.ForeColor = STACK.ActiveColor;
                        break;
                    }
            }
        }

        private void connCLRstack_StateChanged(object sender, EventArgs e)
        {
            if (STACK.CLR.Active)
            {
                pu = 0;
                STACK.Address = 0;
                addressC0 = addressC1 = addressC2 = addressC3 = 0;
                labelC0iplstack.Text = labelC1iplstack.Text = labelC2iplstack.Text = labelC3iplstack.Text = STACK.AddressAsBinary.Substring(0, 4);
                labelC0noiplstack.Text = labelC1noiplstack.Text = labelC2noiplstack.Text = labelC3noiplstack.Text = STACK.AddressAsBinary.Substring(4, 8);
                HighLightCurrentCounter();
            }
        }

        private void btnLMmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblLMmar, connLMmar);
        }

        private void btnCLKmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKmar, connCLKmar);
        }

        private void btnIPLmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblIPLmar, connIPLmar);
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

        private void tabPageA_Click(object sender, EventArgs e)
        {

        }

        private void btnLAaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblLAaccu, connLAaccu);
        }

        private void btnCLKaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKaccu, connCLKaccu);
        }

        private void btnEAaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblEAaccu, connEAaccu);
        }

        private void btnSHLaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblSHLaccu, connSHLaccu);
        }

        private void btnSHRaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblSHRaccu, connSHRaccu);
        }

        private void btnRALaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblRALaccu, connRALaccu);
        }

        private void btnRARaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblRARaccu, connRARaccu);
        }

        private void btnEUalu_Click(object sender, EventArgs e)
        {
            ToggleState(lblEUalu, connEUalu);
        }

        private void btnS0alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS0alu, connS0alu);
        }

        private void btnS1alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS1alu, connS1alu);
        }

        private void btnS2alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS2alu, connS2alu);
        }

        private void btnS3alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS3alu, connS3alu);
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
                operation = "Operation\r\nUndefined";
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

        private void ALU_StateChanged(object sender, EventArgs e)
        {
            lblALUOperation.Visible = ALU.Active;
            if (ALU.Active)
            {
                AluOperation();
            }
        }

    }
}
