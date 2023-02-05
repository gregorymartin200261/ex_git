using System;
namespace Heritage2
{
	public class Directeur : Employe
    {
		protected double _chiffreAffaires;

		public double chiffreAffaires
		{
			get
			{
				return _chiffreAffaires;
			}
			set
			{
				_chiffreAffaires=value;
			}
		}
		
        public Directeur(double chiffreAffaires,double matricule,string nom,string prenom, DateTime bornDate) : base ( matricule, nom, prenom, bornDate)
        {
            this._chiffreAffaires = chiffreAffaires;
            this._matricule = matricule;
            this._nom = nom;
			this._prenom = prenom;
            this._bornDate = bornDate;
        }

        public double CalculSalaire()
        {
            return _chiffreAffaires*0.1;//0.1 = 10%;
        }
    }
}

