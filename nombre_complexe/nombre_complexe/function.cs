using System;
using System.Collections.Generic;
using System.Text;

namespace nombre_complexe
{
    class Complexe
    {
        private double _reel1;
        private double _reel2;
        public Complexe(double reel1, double reel2)
        {
            this._reel1 = reel1;
            this._reel2 = reel2;

        }

        public double reel1
        {
            get
            {
                return this._reel1;
            }
            set
            {
                this._reel1 = value;
            }
        }
        public double reel2
        {
            get
            {
                return this._reel2;
            }
            set
            {
                this._reel2 = value;
            }
        }

        public double ajoute1(double reel1Ajoute) 
        {
            double Value = reel1 + reel1Ajoute;
            reel1 = Value;
            return reel1;
        }
        public double ajoute2(double reel2Ajoute)
        {
            double Value = reel2 + reel2Ajoute;
            reel2 = Value;
            return reel1;
        }
        public double CalculeModule()
        {
            double value = Math.Sqrt( this._reel1 * this._reel1 + this._reel2 * this._reel2);
            return value;
        }

        public string AfficheComplexe(double module)
        {
            return "le premier complexe : (" + this._reel1 + ",00;" + this._reel2 + ",00) a pour module : " + module;
        }

    }
}
