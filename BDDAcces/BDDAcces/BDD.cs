using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;

namespace BDDAcces
{
    class BDD
    {
        public string DefinirCheminBD()
        {
            // Début de chemin identique pour toute base de type ACCESS & chemin relatif vers la bdd

            string CheminBDRelatif = System.IO.Directory.GetCurrentDirectory() + "\\nomBdd.accdb";

            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + CheminBDRelatif;
        }

        public bool CreationSelect(string valeur,out DataSet ds)
        {
            OleDbConnection maConnexion = new OleDbConnection(DefinirCheminBD());
            ds = new DataSet();
            bool ok = false;


            string query = "SELECT * FROM Clients WHERE Société=\"" + valeur + "\";";


            try
            {
                maConnexion.Open();
                // déclaration et instanciation du dataAdapter avec la connexion et la requête
                OleDbDataAdapter da = new OleDbDataAdapter(query, maConnexion);
                // Remplissage du dataSet, “mesDonnees” est le nom attribué au contenu du dataSet
                da.Fill(ds, "mesDonnees");
                // on peut accéder au données du dataSet avec la syntaxe suivante : 
                if(ds.Tables[0].Rows.Count>=1)
                {
                    ok = true;
                }
                maConnexion.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return ok;

        }
    }
}
