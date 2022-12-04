using System;
using System.Collections.Generic;
using System.Text;

namespace Personne
{
    class Personne
    {
        private string _nomPersonne;
        private uint _argentPersonne;

        public Personne(string nomPersonne, uint argentPersonne)
        {
            this._nomPersonne = nomPersonne;
            this._argentPersonne = argentPersonne;
        }
        public string NomPrsn()
        {
            return this._nomPersonne;
        }



        public uint ArgentPersonne
        {
            get
            {
                return this._argentPersonne;
            }
            set
            {
                this._argentPersonne = value;
            }
        }
    }
}
