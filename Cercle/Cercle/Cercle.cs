using System;
using System.Collections.Generic;
using System.Text;

namespace Cercle
{
    class Cercle
    {
        private int _rayon;
        public Cercle(int rayon)
        {
            this._rayon = rayon;

        }
        public int Rayon
        {
            get
            {
                return _rayon;
            }
            set
            {
                _rayon = value;
            }
        }

        public double CalculePerimetre()
        {
            double value = 2* Math.PI * this._rayon;
            return value;
        }
        public double CalculeAire()
        {
            double value = Math.PI * this._rayon * this._rayon;
            return value;
        }
    }
}
