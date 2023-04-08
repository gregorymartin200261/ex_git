using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SqlEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet Utilisateur;
            Console.WriteLine("Voici nos utilisateurs");
            if (AllUser(out Utilisateur))
            {
                string AllUser = AfficheDataUsers(Utilisateur);
                Console.WriteLine(AllUser);
            }
            else
            {
                Console.WriteLine("Erreur lors de la recherche,reesayez plus tard!");
            }


            Console.ReadLine();


        }

        static string AfficheDataUsers(DataSet save)
        {
            string data = "";
            for (int i = 0; i < save.Tables[0].Rows.Count; i++)
            {
                data += save.Tables[0].Rows[i]["nomUser"].ToString() + " " +
                         save.Tables[0].Rows[i]["prenomUser"].ToString() + " " +
                         save.Tables[0].Rows[i]["loginUser"].ToString() + " " +
                         save.Tables[0].Rows[i]["passWordUser"].ToString() + " ";
            }
            return data;
        }

        static string DefinirCheminBD()
        {
            return "server=localhost;database=bdd;port=3306;User Id=root;password=root";
        }

        static bool AllUser(out DataSet data)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "SELECT * FROM utilisateurs;";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                data = new DataSet();
                da.Fill(data, "infoUtilisateurs");

                if (data.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }
    }

}