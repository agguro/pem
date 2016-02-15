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
    public partial class FormPEM3Blockdiagram : Form
    {
        int aluOperationlines = 0;
        public FormPEM3Blockdiagram()
        {
            InitializeComponent();
        }

        private void ToggleState(Label label, PEM.Connection connection)
        {
            connection.Active = !connection.Active;
            label.ForeColor = connection.CurrentColor;
        }

        private void lblEOpO_Click(object sender, EventArgs e)
        {
            ToggleState(lblE0p0, connE0p0);
        }

        private void lblE1p1_Click(object sender, EventArgs e)
        {
            ToggleState(lblE1p1, connE1p1);
        }

        private void lblE2p2_Click(object sender, EventArgs e)
        {
            ToggleState(lblE2p2, connE2p2);
            
        }

        private void lblE3p3_Click(object sender, EventArgs e)
        {
            ToggleState(lblE3p3, connE3p3);
            
        }

        private void lblE4p4_Click(object sender, EventArgs e)
        {
            ToggleState(lblE4p4, connE4p4);
            
        }

        private void lblE5p5_Click(object sender, EventArgs e)
        {
            ToggleState(lblE5p5, connE5p5);
            
        }

        private void lblE6p6_Click(object sender, EventArgs e)
        {
            ToggleState(lblE6p6, connE6p6);
            
        }

        private void lblE7p7_Click(object sender, EventArgs e)
        {
            ToggleState(lblE7p7, connE7p7);
            
        }

        private void lblL8p8_Click(object sender, EventArgs e)
        {
            ToggleState(lblL8p8, connL8p8);
        }

        private void lblL9p9_Click(object sender, EventArgs e)
        {
            ToggleState(lblL9p9, connL9p9);
        }

        private void lblL10p10_Click(object sender, EventArgs e)
        {
            ToggleState(lblL10p10, connL10p10);
        }

        private void lblP11p11_Click(object sender, EventArgs e)
        {
            ToggleState(lblL11p11, connL11p11);
        }

        private void lblL11p11_Click(object sender, EventArgs e)
        {
            ToggleState(lblL11p11, connL11p11);
        }

        private void lblE0p0_Click(object sender, EventArgs e)
        {
            ToggleState(lblE0p0, connE0p0);
        }

        private void lblL12p12_Click(object sender, EventArgs e)
        {
            ToggleState(lblL12p12, connL12p12);
        }

        private void lblL13p13_Click(object sender, EventArgs e)
        {
            ToggleState(lblL13p13, connL13p13);
        }

        private void lblL14p14_Click(object sender, EventArgs e)
        {
            ToggleState(lblL14p14, connL14p14);
        }

        private void lblL15p15_Click(object sender, EventArgs e)
        {
            ToggleState(lblL15p15, connL15p15);
        }

        private void wbusIO2_Click(object sender, EventArgs e)
        {
            wbusIO1.Active = wbusIO2.Active;
            dbIO1.Active = wbusIO2.Active;
        }

        private void wbusIO2_StateChanged(object sender, EventArgs e)
        {
            wbusIO1.Active = wbusIO2.Active;
            dbIO1.Active = wbusIO2.Active;
            dbP8in.Active = wbusIO2.Active;
            dbP9in.Active = wbusIO2.Active;
            dbP10in.Active = wbusIO2.Active;
            dbP11in.Active = wbusIO2.Active;
            dbP12in.Active = wbusIO2.Active;
            dbP13in.Active = wbusIO2.Active;
            dbP14in.Active = wbusIO2.Active;
            dbP15in.Active = wbusIO2.Active;
        }
        private void wbusIO1_Click(object sender, EventArgs e)
        {
            wbusIO2.Active = wbusIO1.Active;
            dbIO2.Active = wbusIO1.Active;
        
        
        }
        private void wbusIO1_StateChanged(object sender, EventArgs e)
        {
            wbusIO2.Active = wbusIO1.Active;
            dbIO2.Active = wbusIO1.Active;
            dbinport2in.Active = wbusIO1.Active;
            //dbo2outport.Active = wbusIO1.Active;

        }

        private void lblCLK_Click(object sender, EventArgs e)
        {
            connCLKcon.Active = !connCLKcon.Active;
        }

        private void lblCLR_Click(object sender, EventArgs e)
        {
            connCLRcon.Active = !connCLRcon.Active;
        }

        private void connCLK_StateChanged(object sender, EventArgs e)
        {
            if (connCLKcon.Active)
            {
                lblCLKcon.ForeColor = connCLKcon.ActiveColor;
                lblCLKaccu.ForeColor = connCLKaccu.ActiveColor;
                lblCLKb.ForeColor = connCLKb.ActiveColor;
                lblCLKi.ForeColor = connCLKi.ActiveColor;
                lblCLKir.ForeColor = connCLKir.ActiveColor;
                lblCLKmar.ForeColor = connCLKmar.ActiveColor;
                lblCLKmdr.ForeColor = connCLKmdr.ActiveColor;
                lblCLKo.ForeColor = connCLKo.ActiveColor;
                lblCLKstack.ForeColor = connCLKstack.ActiveColor;
                lblCLKx.ForeColor = connCLKx.ActiveColor;
            }
            else
            {
                lblCLKcon.ForeColor = connCLKcon.InactiveColor;
                lblCLKaccu.ForeColor = connCLKaccu.InactiveColor;
                lblCLKb.ForeColor = connCLKb.InactiveColor;
                lblCLKi.ForeColor = connCLKi.InactiveColor;
                lblCLKir.ForeColor = connCLKir.InactiveColor;
                lblCLKmar.ForeColor = connCLKmar.InactiveColor;
                lblCLKmdr.ForeColor = connCLKmdr.InactiveColor;
                lblCLKo.ForeColor = connCLKo.InactiveColor;
                lblCLKstack.ForeColor = connCLKstack.InactiveColor;
                lblCLKx.ForeColor = connCLKx.InactiveColor;
            }
        }

        private void connCLR_StateChanged(object sender, EventArgs e)
        {
            if (connCLRcon.Active)
            {
                lblCLRcon.ForeColor = connCLRcon.ActiveColor;
                lblCLRir.ForeColor = connCLRir.ActiveColor;
                lblCLRstack.ForeColor = connCLRstack.ActiveColor;
            }
            else
            {
                lblCLRcon.ForeColor = connCLRcon.InactiveColor;
                lblCLRir.ForeColor = connCLRir.InactiveColor;
                lblCLRstack.ForeColor = connCLRstack.InactiveColor;
            }
        }

        private void lblCLKi_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKi, connCLKi);
        }

        private void lblLNi_Click(object sender, EventArgs e)
        {
            ToggleState(lblLNi, connLNi);
        }

        

        private void lblENi_Click(object sender, EventArgs e)
        {
            ToggleState(lblENi, connENi);
        }

        private void lblPUstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblPUstack, connPUstack);
        }

        private void lblPDstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblPDstack, connPDstack);
        }

        private void lblIPLstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblIPLstack, connIPLstack);
        }

        private void lblCLKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKstack, connCLKstack);
        }

        private void lblCLRstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRstack, connCLRstack);
        }

        private void lblLKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblLKstack, connLKstack);
        }

        private void lblCKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblCKstack, connCKstack);
        }

        private void lblEKstack_Click(object sender, EventArgs e)
        {
            ToggleState(lblEKstack, connEKstack);
        }

        private void lblLMmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblLMmar, connLMmar);
        }

        private void lblCLKmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKmar, connCLKmar);
        }

        private void lblIPLmar_Click(object sender, EventArgs e)
        {
            ToggleState(lblIPLmar, connIPLmar);
        }

        private void lblWEram_Click(object sender, EventArgs e)
        {
            ToggleState(lblWEram, connWEram);
        }

        private void lblMEram_Click(object sender, EventArgs e)
        {
            ToggleState(lblMEram, connMEram);
        }

        private void lblLDmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblLDmdr, connLDmdr);
        }

        private void lblCLKmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKmdr, connCLKmdr);
        }

        private void lblEDmdr_Click(object sender, EventArgs e)
        {
            ToggleState(lblEDmdr, connEDmdr);
        }

        private void lblLIir_Click(object sender, EventArgs e)
        {
            ToggleState(lblLIir, connLIir);
        }

        private void lblCLKir_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKir, connCLKir);
        }

        private void lblCLRir_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRir, connCLRir);
        }

        private void lblEIir_Click(object sender, EventArgs e)
        {
            ToggleState(lblEIir, connEIir);
        }

        private void lblAMINUScon_Click(object sender, EventArgs e)
        {
            ToggleState(lblAMINUScon, connAMINUScon);
            ToggleState(lblAMINUSa, connAMINUSaccu);
        }

        private void lblAZEROcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblAZEROcon, connAZEROcon);
            ToggleState(lblAZEROa, connAZEROaccu);
        }

        private void lblXMINUScon_Click(object sender, EventArgs e)
        {
            ToggleState(lblXMINUScon, connXMINUScon);
            ToggleState(lblXMINUSx, connXMINUSx);
        }

        private void lblXZEROcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblXZEROcon, connXZEROcon);
            ToggleState(lblXZEROx, connXZEROx);
        }

        private void lblCLRcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLRcon, connCLRcon);
        }

        private void lblCLKcon_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKcon, connCLKcon);
        }

        private void lblLOo_Click(object sender, EventArgs e)
        {
            ToggleState(lblLOo, connLOo);
        }

        private void lblCLKo_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKo, connCLKo);
        }

        private void lblEOo_Click(object sender, EventArgs e)
        {
            ToggleState(lblEOo, connEOo);
        }

        private void lblLAaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblLAaccu, connLAaccu);
        }

        private void lblSHLaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblSHLaccu, connSHLaccu);
        }

        private void lblSHRaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblSHRaccu, connSHRaccu);
        }

        private void lblCLKaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKaccu, connCLKaccu);
        }

        private void lblRALaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblRALaccu, connRALaccu);
        }

        private void lblRARaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblRARaccu, connRARaccu);
        }

        private void lblEAaccu_Click(object sender, EventArgs e)
        {
            ToggleState(lblEAaccu, connEAaccu);
        }

        private void lblS3alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS3alu, connS3alu);
        }

        private void lblS2alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS2alu, connS2alu);
        }

        private void lblS1alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS1alu, connS1alu);
        }

        private void lblS0alu_Click(object sender, EventArgs e)
        {
            ToggleState(lblS0alu, connS0alu);
        }

        private void lblEUalu_Click(object sender, EventArgs e)
        {
            ToggleState(lblEUalu, connEUalu);
        }

        private void lblLBb_Click(object sender, EventArgs e)
        {
            ToggleState(lblLBb, connLBb);
        }

        private void lblCLKb_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKb, connCLKb);
        }

        private void lblLXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblLXx, connLXx);
        }

        private void lblINXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblINXx, connINXx);
        }

        private void lblCLKx_Click(object sender, EventArgs e)
        {
            ToggleState(lblCLKx, connCLKx);
        }

        private void lblDEXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblDEXx, connDEXx);
        }

        private void lblEXx_Click(object sender, EventArgs e)
        {
            ToggleState(lblEXx, connEXx);
        }

        private void O_Load(object sender, EventArgs e)
        {

        }

        private void X_StateChanged(object sender, EventArgs e)
        {
            lblXoperation.Visible = X.Active;
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
            }
            else
            {
                lblXoperation.Visible = false;     // not allowed situation
            }
        }

        private void ALU_StateChanged(object sender, EventArgs e)
        {
            lblALUOperation.Visible = ALU.Active;
            if (ALU.Active)
            {
                AluOperation();
            }
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
    }
}
