using System;
using System.Collections.Generic;
using System.Text;

namespace calculette_binaire
{
    class calculatrice
    {
        private ushort[] _t1 = new ushort[8];
        private ushort[] _t2 = new ushort[8];

        public calculatrice(ushort[] t1, ushort[] t2)
        {
            this._t1 = t1;
            this._t2 = t2;
        }

        static string check(ref ushort[] tRes)
        {
            string Resultat = "";
            for (int i = 0; i < tRes.Length; i++)
            {
                Resultat = Resultat + tRes[i].ToString();
            }
            return Resultat;
        }

        public ushort[] RemplirTableau(string nombreBinaire)
        {
            ushort[] tabBin = new ushort[8];
            for (int i = 0; i < 8; i++)
            {
                tabBin[i] = 0;
            }
            for (int i = 0; i <= nombreBinaire.Length-1; i++)
            {
                tabBin[7 - i] = ushort.Parse(nombreBinaire[nombreBinaire.Length - 1 - i].ToString());
            }
            return tabBin;
        }

        static bool Additionne(ref ushort[] tRes)
        {
            bool ok = true;
            ushort report = 0;
            ushort Res;

            for (int i = 0; i < 8; i++)
            {
                Res = (ushort)(_t1[i] + _t2[i] + report);
                if (Res/2 ==0)
                {
                    report = 0;
                }
                else { report = 1; }
                if (Res==1)
                {
                    tRes[i] = 1;
                }
                else
                {
                    if (Res % 2==1)
                    {
                        tRes[i] = 1;
                    }
                    else
                    {
                        tRes[i] = 0;
                    }
                }
            }
            if (report == 1)
            {
                ok = false;
            }
            return ok;
        }

        public bool Soustraire(ref ushort[] tRes)
        {
            tRes = new ushort[8];
            int[] tTemp = new int[8];
            bool ok = true;

            for (int i = 0; i <= 7; i++)
            {
                tTemp[i] = _t1[i] - _t2[i];
            }

            for (int i = 7; i >= 1; i--)
            {
                if (tTemp[i]==-1)
                {
                    _t2[i - 1] =(ushort)(_t2[i - 1] + 1);
                    _t1[i] =(ushort)( _t1[i] + 2);
                }
                if (_t1[i]<_t2[i])
                {
                    _t2[i - 1] = (ushort)(_t2[i - 1] + 1);
                    _t1[i] = (ushort)(_t1[i] + 2);
                    
                }
                tRes[i] = (ushort)(_t1[i] - _t2[i]);
            }
            if (_t1[0]>=_t2[0])
            {
                tRes[0] = (ushort)(_t1[0] - _t2[0]);
            }
            else { ok = false; }
            return ok;
        
        }
    }
}
