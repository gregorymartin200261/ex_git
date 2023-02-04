using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
    class Lapin : Animal
    {
        private decimal _tailleOreilles;

        public Lapin(decimal tailleOreilles,string nom, DateTime dateDeNaissance, double numeroDePuce, double taille, bool animalDeConcours) : base ( nom,  dateDeNaissance,  numeroDePuce,  taille,  animalDeConcours)
        {
            this._tailleOreilles = tailleOreilles;
            this._nom = nom;
            this._dateDeNaissance = dateDeNaissance;
            this._numeroDePuce = numeroDePuce;
            this._taille = taille;
            this._animalDeConcours = animalDeConcours;
        }

        public decimal tailleOreilles{
            get{
                return _tailleOreilles;
            }
            set{
                _tailleOreilles=value;
            }
        }

        public string bonds()
        {
            return "BONG BONG BONG";
        }
    }
}
