using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM1;

namespace PEMCollection.ChildForms
{
    public partial class FormPEM1Components : Form
    {
        string title = "PEM 1 - Components";
        bool pauze = false;

        public FormPEM1Components()
        {
            InitializeComponent();
            comboBoxInstructie.SelectedIndex = 0;
        }

        private void tabPagePC_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelPCTitle);
        }

        private void tabPageMAR_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelMARTitle);
        }

        private void tabPagePROM_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelPROMTitle);
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

        private void tabPageO_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelOTitle);
        }

        private void tabPageD_Enter(object sender, EventArgs e)
        {
            SetFormTitle(labelDTitle);
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

        private void buttonCp_Click(object sender, EventArgs e)
        {
            PC.COUNT.Active = !PC.COUNT.Active;
        }

        private void buttonCLKp_Click(object sender, EventArgs e)
        {
            PC.CLK.Active = !PC.CLK.Active;
        }

        private void buttonCLRp_Click(object sender, EventArgs e)
        {
            PC.CLR.Active = !PC.CLR.Active;
        }

        private void buttonEp_Click(object sender, EventArgs e)
        {
            PC.ENABLE.Active = !PC.ENABLE.Active;
        }

        private void buttonLm_Click(object sender, EventArgs e)
        {
            MAR.LOAD.Active = !MAR.LOAD.Active;
        }

        private void buttonCLKmar_Click(object sender, EventArgs e)
        {
            MAR.CLK.Active = !MAR.CLK.Active;
        }

        private void buttonEr_Click(object sender, EventArgs e)
        {
            PROM.ME.Active = !PROM.ME.Active;
        }

        private void buttonMAR_Click(object sender, EventArgs e)
        {
            dbpromfrommar.Active = !dbpromfrommar.Active;
        }

        private void buttonLi_Click(object sender, EventArgs e)
        {
            IR.LOAD.Active = !IR.LOAD.Active;
        }

        private void buttonCLKir_Click(object sender, EventArgs e)
        {
            IR.CLK.Active = !IR.CLK.Active;
        }
        private void buttonCLRir_Click(object sender, EventArgs e)
        {
            IR.CLR.Active = !IR.CLR.Active;
        }
        private void buttonEi_Click(object sender, EventArgs e)
        {
            IR.ENABLE.Active = !IR.ENABLE.Active;
        }
        private void buttonWBUSir_Click(object sender, EventArgs e)
        {
            wbusir.Active = !wbusir.Active;
        }

        private void buttonCLKcon_Click(object sender, EventArgs e)
        {
            CON.CLK.Active = !CON.CLK.Active;
        }

        private void buttonCLRcon_Click(object sender, EventArgs e)
        {
            CON.CLR.Active = !CON.CLR.Active;
        }

        private void buttonBusINcon_Click(object sender, EventArgs e)
        {
            CON.IN.Active = !CON.IN.Active;
        }

        private void buttonCON_Click(object sender, EventArgs e)
        {
            CON.Active = !CON.Active;
            /*
            comboBoxInstructie.Enabled = !CON.Active;
            int opcode = comboBoxInstructie.SelectedIndex;
            if(opcode > 2)
            {
                opcode = comboBoxInstructie.SelectedIndex + 11;     // opcode aanpassing OUT = 14, HLT = 15
            }
            CON.Opcode = opcode * 16;
            buttonPauze.Enabled = CON.Active;*/
            if (CON.Active)
            {
                buttonCON.Text = "OFF";
                buttonCLKcon.Enabled = true;
                buttonCLRcon.Enabled = true;
                /*  labelconcp.Visible = false;
                  labelconea.Visible = false;
                  labelconei.Visible = false;
                  labelconep.Visible = false;
                  labelconer.Visible = false;
                  labelconeu.Visible = false;
                  labelconla.Visible = false;
                  labelconlb.Visible = false;
                  labelconli.Visible = false;
                  labelconlm.Visible = false;
                  labelconlo.Visible = false;
                  labelconsu.Visible = false; 
                  CON.On(); */
            }
            else
            {
                buttonCON.Text = "ON";
                buttonCLKcon.Enabled = false;
                buttonCLRcon.Enabled = false;
                /*CON.Off();
                labelconcp.Visible = true;
                labelconea.Visible = true;
                labelconei.Visible = true;
                labelconep.Visible = true;
                labelconer.Visible = true;
                labelconeu.Visible = true;
                labelconla.Visible = true;
                labelconlb.Visible = true;
                labelconli.Visible = true;
                labelconlm.Visible = true;
                labelconlo.Visible = true;
                labelconsu.Visible = true;
                pauze = false;
                buttonPauze.Text = "RUN"; */
            }
        }

        private void buttonPauze_Click(object sender, EventArgs e)
        {
            if (!pauze)
            {
                CON.Run();
                buttonPauze.Text = "STOP";
            }
            else
            {
                CON.Pauze();
                buttonPauze.Text = "RUN";
            }
            pauze = !pauze;
        }

        private void buttonLa_Click(object sender, EventArgs e)
        {
            ACCU.LOAD.Active = !ACCU.LOAD.Active;
        }

        private void buttonEa_Click(object sender, EventArgs e)
        {
            ACCU.ENABLE.Active = !ACCU.ENABLE.Active;
        }

        private void buttonCLKa_Click(object sender, EventArgs e)
        {
            ACCU.CLK.Active = !ACCU.CLK.Active;
        }

        private void buttonLb_Click(object sender, EventArgs e)
        {
            B.LOAD.Active = !B.LOAD.Active;
        }

        private void buttonCLKb_Click(object sender, EventArgs e)
        {
            B.CLK.Active = !B.CLK.Active;
        }

        private void buttonWbusa_Click(object sender, EventArgs e)
        {
            wbusAccu.Active = !wbusAccu.Active;
        }

        private void buttonwbusb_Click(object sender, EventArgs e)
        {
            wbusb.Active = !wbusb.Active;
        }

        private void buttonLo_Click(object sender, EventArgs e)
        {
            O.LOAD.Active = !O.LOAD.Active;
        }

        private void buttonCLKo_Click(object sender, EventArgs e)
        {
            O.CLK.Active = !O.CLK.Active;
        }

        private void buttonWbuso_Click(object sender, EventArgs e)
        {
            wbuso.Active = !wbuso.Active;
        }

        private void buttono2d_Click(object sender, EventArgs e)
        {
            dbind.Active = !dbind.Active;
        }

        private void buttonSu_Click(object sender, EventArgs e)
        {
            ALU.SUBTRACT.Active = !ALU.SUBTRACT.Active;
            if (ALU.SUBTRACT.Active)
            {
                labelAluResult.Text = "A - B";
            }
            else
            {
                labelAluResult.Text = "A + B";
            }
        }

        private void buttonEu_Click(object sender, EventArgs e)
        {
            ALU.ENABLE.Active = !ALU.ENABLE.Active;
        }

        private void PC_StateChanged(object sender, EventArgs e)
        {
            labelAddress.Text = PC.AddressAsBinary;
        }

        private void CONCLK_StateChanged(object sender, EventArgs e)
        {
            /* labelconcp.Visible = CON.Cp.Active;
            labelconea.Visible = CON.Ea.Active;
            labelconei.Visible = CON.Ei.Active;
            labelconep.Visible = CON.Ep.Active;
            labelconer.Visible = CON.Er.Active;
            labelconeu.Visible = CON.Eu.Active;
            labelconla.Visible = CON.La.Active;
            labelconlb.Visible = CON.Lb.Active;
            labelconli.Visible = CON.Li.Active;
            labelconlm.Visible = CON.Lm.Active;
            labelconlo.Visible = CON.Lo.Active;
            labelconsu.Visible = CON.Su.Active; */
        }

        private void CON_StateChanged(object sender, EventArgs e)
        {
            if (CON.Active)
            {
                buttonCON.Text = "OFF";
                buttonCLKcon.Enabled = true;
                buttonCLRcon.Enabled = true;
                /*  labelconcp.Visible = false;
                  labelconea.Visible = false;
                  labelconei.Visible = false;
                  labelconep.Visible = false;
                  labelconer.Visible = false;
                  labelconeu.Visible = false;
                  labelconla.Visible = false;
                  labelconlb.Visible = false;
                  labelconli.Visible = false;
                  labelconlm.Visible = false;
                  labelconlo.Visible = false;
                  labelconsu.Visible = false; 
                  CON.On(); */
            }
            else
            {
                buttonCON.Text = "ON";
                buttonCLKcon.Enabled = false;
                buttonCLRcon.Enabled = false;
                /*CON.Off();
                labelconcp.Visible = true;
                labelconea.Visible = true;
                labelconei.Visible = true;
                labelconep.Visible = true;
                labelconer.Visible = true;
                labelconeu.Visible = true;
                labelconla.Visible = true;
                labelconlb.Visible = true;
                labelconli.Visible = true;
                labelconlm.Visible = true;
                labelconlo.Visible = true;
                labelconsu.Visible = true;
                pauze = false;
                buttonPauze.Text = "RUN"; */
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == 10)
            {
                CON.Interval = 1;
            }
            else
            {
                CON.Interval = 1000 - trackBar1.Value * 100;
            }
        }

        private void buttonWBUSmar_Click(object sender, EventArgs e)
        {
            wbusmar.Active = !wbusmar.Active;
        }

        private void buttonCLKcon_Click_1(object sender, EventArgs e)
        {
            CON.CLK.Active = !CON.CLK.Active;
        }

        private void buttonCLRcon_Click_1(object sender, EventArgs e)
        {
            CON.CLR.Active = !CON.CLR.Active;
        }
    }
}
