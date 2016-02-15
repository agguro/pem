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
    public partial class FormPEM1Blockdiagram : Form
    {
        public FormPEM1Blockdiagram()
        {
            InitializeComponent();
        }

        private void labelconcp_Click(object sender, EventArgs e)
        {
            PC.COUNT.Active = !PC.COUNT.Active;
            
        }

        private void labelconep_Click(object sender, EventArgs e)
        {
            PC.ENABLE.Active = !PC.ENABLE.Active;
        }

        private void labelconlm_Click(object sender, EventArgs e)
        {
            MAR.LOAD.Active = !MAR.LOAD.Active;
        }

        private void labelconer_Click(object sender, EventArgs e)
        {
            PROM.ME.Active = !PROM.ME.Active;
        }

        private void labelconli_Click(object sender, EventArgs e)
        {
            IR.LOAD.Active = !IR.LOAD.Active;
        }

        private void labelconei_Click(object sender, EventArgs e)
        {
            IR.ENABLE.Active = !IR.ENABLE.Active;
        }

        private void labelconla_Click(object sender, EventArgs e)
        {
            A.LOAD.Active = !A.LOAD.Active;
        }

        private void labelconea_Click(object sender, EventArgs e)
        {
            A.ENABLE.Active = !A.ENABLE.Active;
        }

        private void labelconsu_Click(object sender, EventArgs e)
        {
            ALU.SUBTRACT.Active = !ALU.SUBTRACT.Active;
        }

        private void labelconeu_Click(object sender, EventArgs e)
        {
            ALU.ENABLE.Active = !ALU.ENABLE.Active;
        }

        private void labelconlb_Click(object sender, EventArgs e)
        {
            B.LOAD.Active = !B.LOAD.Active;
        }

        private void labelconlo_Click(object sender, EventArgs e)
        {
            O.LOAD.Active = !O.LOAD.Active;
        }

        private void labelconclk_Click(object sender, EventArgs e)
        {
            CON.CLK.Active = !CON.CLK.Active;
            PC.CLK.Active = CON.CLK.Active;
            MAR.CLK.Active = CON.CLK.Active;
            IR.CLK.Active = CON.CLK.Active;
            A.CLK.Active = CON.CLK.Active;
            B.CLK.Active = CON.CLK.Active;
            O.CLK.Active = CON.CLK.Active;
        }

        private void labelconclr_Click(object sender, EventArgs e)
        {
            CON.CLR.Active = !CON.CLR.Active;
            PC.CLR.Active = CON.CLR.Active;
            IR.CLR.Active = CON.CLR.Active;
        }
        private void Cp_StateChanged(object sender, EventArgs e)
        {
            if (PC.COUNT.Active)
            {
                labelconcp.ForeColor = PC.COUNT.ActiveColor;
                labelpccp.ForeColor = PC.COUNT.ActiveColor;
            }
            else
            {
                labelconcp.ForeColor = PC.COUNT.InactiveColor;
                labelpccp.ForeColor = PC.COUNT.InactiveColor;
            }
        }

        private void Ep_StateChanged(object sender, EventArgs e)
        {
            if (PC.ENABLE.Active)
            {
                labelconep.ForeColor = PC.ENABLE.ActiveColor;
                labelpcep.ForeColor = PC.ENABLE.ActiveColor;
            }
            else
            {
                labelconep.ForeColor = PC.ENABLE.InactiveColor;
                labelpcep.ForeColor = PC.ENABLE.InactiveColor;
            }
        }

        private void Lm_StateChanged(object sender, EventArgs e)
        {
            if (MAR.LOAD.Active)
            {
                labelconlm.ForeColor = MAR.LOAD.ActiveColor;
                labelmarlm.ForeColor = MAR.LOAD.ActiveColor;
            }
            else
            {
                labelconlm.ForeColor = MAR.LOAD.InactiveColor;
                labelmarlm.ForeColor = MAR.LOAD.InactiveColor;
            }
        }

        private void Er_StateChanged(object sender, EventArgs e)
        {
            if (PROM.ME.Active)
            {
                labelconer.ForeColor = PROM.ME.ActiveColor;
                labelpromer.ForeColor = PROM.ME.ActiveColor;
            }
            else
            {
                labelconer.ForeColor = PROM.ME.InactiveColor;
                labelpromer.ForeColor = PROM.ME.InactiveColor;
            }
        }

        private void Li_StateChanged(object sender, EventArgs e)
        {
            if (IR.LOAD.Active)
            {
                labelconli.ForeColor = IR.LOAD.ActiveColor;
                labelirli.ForeColor = IR.LOAD.ActiveColor;
            }
            else
            {
                labelconli.ForeColor = IR.LOAD.InactiveColor;
                labelirli.ForeColor = IR.LOAD.InactiveColor;
            }
        }

        private void Ei_StateChanged(object sender, EventArgs e)
        {
            if (IR.ENABLE.Active)
            {
                labelconei.ForeColor = IR.ENABLE.ActiveColor;
                labelirei.ForeColor = IR.ENABLE.ActiveColor;
            }
            else
            {
                labelconei.ForeColor = IR.ENABLE.InactiveColor;
                labelirei.ForeColor = IR.ENABLE.InactiveColor;
            }
        }

        private void clock_StateChanged(object sender, EventArgs e)
        {
            if (CON.CLK.Active)
            {
                labelconclk.ForeColor = CON.CLK.ActiveColor;
                labelpcclk.ForeColor = PC.CLK.ActiveColor;
                labelmarclk.ForeColor = MAR.CLK.ActiveColor;
                labelirclk.ForeColor = IR.CLK.ActiveColor;
                labelaclk.ForeColor = A.CLK.ActiveColor;
                labelbclk.ForeColor = B.CLK.ActiveColor;
                labeloclk.ForeColor = O.CLK.ActiveColor;
            }
            else
            {
                labelconclk.ForeColor = CON.CLK.InactiveColor;
                labelpcclk.ForeColor = PC.CLK.InactiveColor;
                labelmarclk.ForeColor = MAR.CLK.InactiveColor;
                labelirclk.ForeColor = IR.CLK.InactiveColor;
                labelaclk.ForeColor = A.CLK.InactiveColor;
                labelbclk.ForeColor = B.CLK.InactiveColor;
                labeloclk.ForeColor = O.CLK.InactiveColor;
            }
        }

        private void CLRCON_StateChanged(object sender, EventArgs e)
        {
            if (CON.CLR.Active)
            {
                labelconclr.ForeColor = CON.CLR.ActiveColor;
                labelpcclr.ForeColor = PC.CLR.ActiveColor;
                labelirclr.ForeColor = IR.CLR.ActiveColor;
            }
            else
            {
                labelconclr.ForeColor = CON.CLR.InactiveColor;
                labelpcclr.ForeColor = PC.CLR.InactiveColor;
                labelirclr.ForeColor = IR.CLR.InactiveColor;
            }
        }

        private void La_StateChanged(object sender, EventArgs e)
        {
            if (A.LOAD.Active)
            {
                labelconla.ForeColor = CON.La.ActiveColor;
                labelala.ForeColor = A.LOAD.ActiveColor;
            }
            else
            {
                labelconla.ForeColor = CON.La.InactiveColor;
                labelala.ForeColor = A.LOAD.InactiveColor;
            }
        }

        private void Ea_StateChanged(object sender, EventArgs e)
        {
            if (A.ENABLE.Active)
            {
                labelconea.ForeColor = CON.Ea.ActiveColor;
                labelaea.ForeColor = A.ENABLE.ActiveColor;
            }
            else
            {
                labelconea.ForeColor = CON.Ea.InactiveColor;
                labelaea.ForeColor = A.ENABLE.InactiveColor;
            }
        }

        private void Su_StateChanged(object sender, EventArgs e)
        {
            if (ALU.SUBTRACT.Active)
            {
                labelconsu.ForeColor = CON.Su.ActiveColor;
                labelalusu.ForeColor = ALU.SUBTRACT.ActiveColor;
            }
            else
            {
                labelconsu.ForeColor = CON.Su.InactiveColor;
                labelalusu.ForeColor = ALU.SUBTRACT.InactiveColor;
            }
        }

        private void Eu_StateChanged(object sender, EventArgs e)
        {
            if (ALU.ENABLE.Active)
            {
                labelconeu.ForeColor = CON.Eu.ActiveColor;
                labelalueu.ForeColor = ALU.ENABLE.ActiveColor;
            }
            else
            {
                labelconeu.ForeColor = CON.Eu.InactiveColor;
                labelalueu.ForeColor = ALU.ENABLE.InactiveColor;
            }
        }

        private void Lb_StateChanged(object sender, EventArgs e)
        {
            if (B.LOAD.Active)
            {
                labelconlb.ForeColor = CON.Lb.ActiveColor;
                labelblb.ForeColor = B.LOAD.ActiveColor;
            }
            else
            {
                labelconlb.ForeColor = CON.Lb.InactiveColor;
                labelblb.ForeColor = B.LOAD.InactiveColor;
            }
        }

        private void Lo_StateChanged(object sender, EventArgs e)
        {
            if (O.LOAD.Active)
            {
                labelconlo.ForeColor = CON.Lo.ActiveColor;
                labelolo.ForeColor = O.LOAD.ActiveColor;
            }
            else
            {
                labelconlo.ForeColor = CON.Lo.InactiveColor;
                labelolo.ForeColor = O.LOAD.InactiveColor;
            }
        }

        private void PC_StateChanged(object sender, EventArgs e)
        {
            labelpccounter.Text = PC.AddressAsBinary;
        }

        private void CLKA_Load(object sender, EventArgs e)
        {

        }

        private void A_Load(object sender, EventArgs e)
        {

        }
    }
}
