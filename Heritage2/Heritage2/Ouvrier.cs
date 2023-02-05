using System;
namespace Heritage2
{
	class Ouvrier : Employe
    {
		protected DateTime _enterDate;

		public DateTime enterDate
		{
			get
			{
				return _enterDate;
			}
			set
			{
				_enterDate=value;
			}
		}

        public Ouvrier(DateTime enterDate,double matricule,string nom,string prenom, DateTime bornDate) : base ( matricule, nom, prenom, bornDate)
        {
			this._enterDate=enterDate;
            this._matricule = matricule;
            this._nom = nom;
			this._prenom = prenom;
            this._bornDate = bornDate;
        }

        public double CalculSalaire()
        {
			double Salaire;
			double Ancienneté=2023-_enterDate.Year;
			if(Ancienneté>25)
			{
				Salaire=5000;
			}
			else{
				Salaire=2500+100*Ancienneté;
			}
            return Salaire;
        }
    }
}

