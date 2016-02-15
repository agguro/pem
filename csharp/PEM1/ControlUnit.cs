using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEM;

namespace PEM1
{
    [ToolboxItem(true)]
    public partial class ControlUnit : IC
    {
        private Connection _clk = new Connection();
        private Connection _clr = new Connection();
        private Databus _in = new Databus();
        private Databus _out = new Databus();
        private int cycle = 0;

        private Connection _cp = new Connection();
        private Connection _ep = new Connection();
        private Connection _lm = new Connection();
        private Connection _er = new Connection();
        private Connection _li = new Connection();
        private Connection _ei = new Connection();
        private Connection _la = new Connection();
        private Connection _ea = new Connection();
        private Connection _su = new Connection();
        private Connection _eu = new Connection();
        private Connection _lb = new Connection();
        private Connection _lo = new Connection();

        private int _instruction;
        private int _address;
        private int _opcode;

        public Connection Cp
        {
            get
            {
                return _cp;
            }
            set
            {
                _cp = value;
            }
        }
        public virtual Connection Ep
        {
            get
            {
                return _ep;
            }
            set
            {
                _ep = value;
            }
        }
        public Connection Lm
        {
            get
            {
                return _lm;
            }
            set
            {
                _lm = value;
            }
        }

        public Connection Er
        {
            get
            {
                return _er;
            }
            set
            {
                _er = value;
            }
        }

        public Connection Li
        {
            get
            {
                return _li;
            }
            set
            {
                _li = value;
            }
        }

        public Connection Ei
        {
            get
            {
                return _ei;
            }
            set
            {
                _ei = value;
            }
        }

        public Connection La
        {
            get
            {
                return _la;
            }
            set
            {
                _la = value;
            }
        }

        public Connection Ea
        {
            get
            {
                return _ea;
            }
            set
            {
                _ea = value;
            }
        }

        public virtual Connection Su
        {
            get
            {
                return _su;
            }
            set
            {
                _su = value;
            }
        }

        public Connection Eu
        {
            get
            {
                return _eu;
            }
            set
            {
                _eu = value;
            }
        }

        public Connection Lb
        {
            get
            {
                return _lb;
            }
            set
            {
                _lb = value;
            }
        }

        public Connection Lo
        {
            get
            {
                return _lo;
            }
            set
            {
                _lo = value;
            }
        }

        public Connection CLK
        {
            get
            {
                return _clk;
            }
            set
            {
                _clk = value;
                if (value != null)
                {
                    _clk.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Connection CLR
        {
            get
            {
                return _clr;
            }
            set
            {
                _clr = value;
                if (value != null)
                {
                    _clr.StateChanged += Execute;
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus IN
        {
            get
            {
                return _in;
            }
            set
            {
                _in = value;
                if (value != null)
                {
                    Execute(this, EventArgs.Empty);
                }
            }
        }

        public Databus OUT
        {
            get
            {
                return _out;
            }
            set
            {
                _out = value;
                if (value != null)
                {
                    if (DesignMode)
                    {
                        Execute(this, EventArgs.Empty);
                    }
                }
            }
        }

        public int Opcode
        {
            get
            {
                return _opcode;
            }
            set
            {
                _opcode = value;
                _instruction = value / 16;
                _address = value % 16;
            }
        }
        public int Interval
        {
            get
            {
                return timer.Interval;
            }
            set
            {
                timer.Interval = value;
            }
        }

        public virtual void On()
        {
            Active = true;
            _out.Active = false;
            _ep.Active = false;
            _lm.Active = false;
            _cp.Active = false;
            _er.Active = false;
            _li.Active = false;
            _ei.Active = false;
            _la.Active = false;
            _ea.Active = false;
            _su.Active = false;
            _eu.Active = false;
            _lb.Active = false;
            _lo.Active = false;
            _clk.Active = false;
            _clr.Active = true;
            cycle = 0;
        }

        public virtual void Off()
        {
            timer.Enabled = false;
            Active = false;
            _out.Active = false;
            _ep.Active = false;
            _lm.Active = false;
            _cp.Active = false;
            _er.Active = false;
            _li.Active = false;
            _ei.Active = false;
            _la.Active = false;
            _ea.Active = false;
            _su.Active = false;
            _eu.Active = false;
            _lb.Active = false;
            _lo.Active = false;
            _clr.Active = false;
            cycle = 0;
        }

        public void Pauze()
        {
            timer.Enabled = false;
        }

        public void Run()
        {
            _clr.Active = false;
            CLK.Active = true;
            cycle = 0;
            timer.Enabled = true;
        }

        public ControlUnit()
        {
            InitializeComponent();
        }


        #region Help functies
        protected override void Execute(object sender, EventArgs e)
        {
            if (!Active)                // if no power on, nothing will happen
            {
                _clk.Active = false;
                _clr.Active = false;
                _out.Active = false;
                _in.Active = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (_clk.Active & !_clr.Active)
            {
                // elke lage klok triggert een nieuwe cyclus, er zijn 6 cycli t0....t5
                if (cycle == 6)
                {
                    cycle = 0;
                }
                _la.Active = false;
                _eu.Active = false;
                _su.Active = false;
                switch (cycle)
                {
                    // ophaalroutine
                    case 0: // adresfase
                        _ep.Active = true;
                        _lm.Active = true;
                        break;
                    case 1: // geheugenfase
                        _ep.Active = false;
                        _lm.Active = false;
                        _er.Active = true;
                        _li.Active = true;
                        break;
                    case 2: // Incrementfase
                        _er.Active = false;
                        _li.Active = false;
                        _cp.Active = true;
                        break;
                    // uitvoeringsroutine afhankelijk van instructie op databus IN
                    case 3:
                        _cp.Active = false;
                        switch (_instruction)
                        {
                            case 0:
                                _lm.Active = true;
                                _ei.Active = true;
                                break;
                            case 1:
                                _lm.Active = true;
                                _ei.Active = true;
                                break;
                            case 2:
                                _lm.Active = true;
                                _ei.Active = true;
                                break;
                            case 14:
                                _ea.Active = true;
                                _lo.Active = true;
                                break;
                            case 15:
                                Off();
                                break;
                        }
                        break;
                    case 4:
                        _lm.Active = false;
                        _ei.Active = false;
                        _ea.Active = false;
                        _lo.Active = false;
                        switch (_instruction)
                        {
                            case 0:
                                _er.Active = true;
                                _la.Active = true;
                                break;
                            case 1:
                                _er.Active = true;
                                _lb.Active = true;
                                break;
                            case 2:
                                _er.Active = true;
                                _lb.Active = true;
                                break;
                            case 14:
                                // no operation
                                break;
                            case 15:
                                break;
                        }
                        break;
                    case 5:
                        _er.Active = false;
                        _la.Active = false;
                        _lb.Active = false;
                        switch (_instruction)
                        {
                            case 0:
                                // no operation
                                break;
                            case 1:
                                _la.Active = true;
                                _eu.Active = true;
                                break;
                            case 2:
                                _la.Active = true;
                                _eu.Active = true;
                                _su.Active = true;
                                break;
                            case 14:
                                // no operation
                                break;
                            case 15:
                                break;
                        }
                        break;
                }
                cycle++;
            }
            _clk.Active = !_clk.Active;
        }
        #endregion

        private void ControlUnit_StateChanged(object sender, EventArgs e)
        {
            _out.Active = Active;
        }
    }
}