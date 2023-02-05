using System;
namespace Heritage2
{
	public class Employe
	{

		protected double _matricule;
        protected string _nom;
        protected string _prenom;
        protected DateTime _bornDate;
        public Employe(double matricule,string nom,string prenom, DateTime bornDate)
        {
            this._matricule = matricule;
            this._nom = nom;
			this._prenom = prenom;
            this._bornDate = bornDate;
        }

        public double matricule
        {
            get
            {
                return this._matricule;
            }
            set
            {
                this._matricule = value;
            }
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

		public string prenom
        {
            get
            {
                return this._prenom;
            }
            set
            {
                this._prenom = value;
            }
        }

		public DateTime bornDate
        {
            get
            {
                return this._bornDate;
            }
            set
            {
                this._bornDate = value;
            }
        }

        public string AfficheSpec()
        {
            return "Voici les caracteristique de "+_prenom+" "+_nom +" né le : "+_bornDate+" et qui a le matricule n° "+_matricule;
        }
	}
}

