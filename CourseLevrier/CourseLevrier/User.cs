using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLevrier
{
    internal class User
    {
        private string _name;
        private int _monnaie;
        public User(string name, int monnaie)
        {
            this._name = name;
            this._monnaie = monnaie;

        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int monnaie
        {
            get { return _monnaie; }
            set { _monnaie = value; }
        }
        public void placerPari(int somme)
        {

        }
        public void soustraireArgent()
        {

        }
        public void ajouterArgent()
        {

        }
    }
}
