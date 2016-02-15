using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using PEM;

namespace PEM1
{
    [ToolboxItem(true)]
    public partial class WBUS : Databus
    {
        private Databus _dbpcin = new Databus();
        private Databus _dbmarout;
        private Databus _dbpromin = new Databus();
        private Databus _dbir;
        private Databus _dbirin = new Databus();
        private Databus _dbaccuout;
        private Databus _dbaccuin = new Databus();
        private Databus _dbaluin = new Databus();
        private Databus _dbbout;
        private Databus _dbouto;
        

        public Databus InPC
        {
            get
            {
                return _dbpcin;
            }
            set
            {
                _dbpcin = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OutMAR
        {
            get
            {
                return _dbmarout;
            }
            set
            {
                _dbmarout = value;
                Invalidate();
            }
        }

        public Databus InPROM
        {
            get
            {
                return _dbpromin;
            }
            set
            {
                _dbpromin = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OutIR
        {
            get
            {
                return _dbir;
            }
            set
            {
                _dbir = value;
                Invalidate();
            }
        }

        public Databus InIR
        {
            get
            {
                return _dbirin;
            }
            set
            {
                _dbirin = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OutACCU
        {
            get
            {
                return _dbaccuout;
            }
            set
            {
                _dbaccuout = value;
                Invalidate();
            }
        }

        public Databus InACCU
        {
            get
            {
                return _dbaccuin;
            }
            set
            {
                _dbaccuin = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus InALU
        {
            get
            {
                return _dbaluin;
            }
            set
            {
                _dbaluin = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OutB
        {
            get
            {
                return _dbbout;
            }
            set
            {
                _dbbout = value;
                Invalidate();
            }
        }

        public Databus OutO
        {
            get
            {
                return _dbouto;
            }
            set
            {
                _dbouto = value;
                Invalidate();

            }
        }

        public WBUS()
        {
            InitializeComponent();
        }

        protected override void DrawComponent(PaintEventArgs e, Color _borderColor, int _borderWidth)
        {
            BorderStyle = BorderStyle.None;
            using (Pen p = new Pen(_borderColor, 1))
            {
                for (int i = 0; i <= _borderWidth - 1; i++)
                {
                    e.Graphics.DrawLine(p, 0, i, Width, i);
                    e.Graphics.DrawLine(p, Width - i - 1, 0, Width - i - 1, Height - 1);
                    e.Graphics.DrawLine(p, 1, Height - i - 1, Width, Height - i - 1);
                    e.Graphics.DrawLine(p, i, 0, i, Height - 1);
                }

            }
            if (_dbpcin != null)
            {
                Active = Active | _dbpcin.Active;
            }
            if (_dbpromin != null)
            {
                Active = Active | _dbpromin.Active;
            }
            if (_dbirin != null)
            {
                Active = Active | _dbirin.Active;
            }
            if (_dbaccuin != null)
            {
                Active = Active | _dbaccuin.Active;
            }
            if (_dbaluin != null)
            {
                Active = Active | _dbaluin.Active;
            }
            if (_dbaccuout != null)
            {
                _dbaccuout.Active = Active;
            }
            if (_dbbout != null)
            {
                _dbbout.Active = Active;
            }
            if (_dbir != null)
            {
                _dbir .Active = Active;
            }
            if (_dbmarout != null)
            {
                _dbmarout.Active = Active;
            }
            if (_dbouto != null)
            {
                _dbouto.Active = Active;
            }
        }

        protected void Execute(object sender, EventArgs e)
        {
            Invalidate();
        }

    }
}
