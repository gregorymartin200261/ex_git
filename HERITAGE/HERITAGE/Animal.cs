using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
    class Animal
    {
        protected string _nom;
        protected DateTime _dateDeNaissance;
        protected double _numeroDePuce;
        protected double _taille;
        protected bool _animalDeConcours;
        public Animal(string nom, DateTime dateDeNaissance, double numeroDePuce, double taille,bool animalDeConcours)
        {
            this._nom = nom;
            this._dateDeNaissance = dateDeNaissance;
            this._numeroDePuce = numeroDePuce;
            this._taille = taille;
            this._animalDeConcours = animalDeConcours;

        }

        public string nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
            }
        }

        public DateTime dateDeNaissance
        {
            get
            {
                return this._dateDeNaissance;
            }
            set
            {
                this._dateDeNaissance = value;
            }
        }

        public double numeroDePuce
        {
            get
            {
                return this._numeroDePuce;
            }
            set
            {
                this._numeroDePuce = value;
            }
        }

        public double taille
        {
            get
            {
                return this._taille;
            }
            set
            {
                this._taille = value;
            }
        }

        public bool animalDeConcours{
            get{
                return this._animalDeConcours;
            }
            set{
                this._animalDeConcours=value;
            }
        }

        public string dormir()
        {
            return "ZZzz ZZzz";
        }

        public string manger()
        {
            return "Miam Maim Miam";
        }
    }
}
