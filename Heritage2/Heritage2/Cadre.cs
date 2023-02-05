using System;
namespace Heritage2
{
	public class Cadre : Employe
    {
		protected int _indice;

		public int indice
		{
			get
			{
				return _indice;
			}
			set
			{
				_indice=value;
			}
		}
		
        public Cadre(int indice,double matricule,string nom,string prenom, DateTime bornDate) : base ( matricule, nom, prenom, bornDate)
        {
            this._indice = indice;
            this._matricule = matricule;
            this._nom = nom;
			this._prenom = prenom;
            this._bornDate = bornDate;
        }

        public double CalculSalaire()
        {
			double Salaire;
			if(_indice==4)
			{
				Salaire=20000;
			}
			else
			{
				Salaire=11000+_indice*2000;
			}
            return Salaire;
        }
    }
}

