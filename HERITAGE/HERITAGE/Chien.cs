using System;
using System.Collections.Generic;
using System.Text;

namespace HERITAGE
{
    class chien : Animal
    {
        public chien(string nom, DateTime dateDeNaissance, double numeroDePuce, double taille, bool animalDeConcours) : base ( nom,  dateDeNaissance,  numeroDePuce,  taille,  animalDeConcours)
        {
            this._nom = nom;
            this._dateDeNaissance = dateDeNaissance;
            this._numeroDePuce = numeroDePuce;
            this._taille = taille;
            this._animalDeConcours = animalDeConcours;
        }

        public string aboyer()
        {
            return "WOUF WOUF WOUF";
        }
    }
}
