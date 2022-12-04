using System;

namespace Personne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continuer = true;
            do
            {
                Console.Clear();
                Personne[] BDPersonne = new Personne[2];
                for (int i = 0; i <2; i++)
                {
                    int NPrsn = i + 1;
                    Console.WriteLine("quel est le nom de la personne" + NPrsn + " ?");
                    string nomPersonne = Console.ReadLine();
                    Console.WriteLine("quel est le nombre d'euro?");
                    uint argentPersonne = uint.Parse(Console.ReadLine());

                    BDPersonne[i] = new Personne(nomPersonne, argentPersonne);
                    Console.Clear();
                }
                for (int i = 0; i < 1; i++)
                {
                    int prsn = i + 1;
                    Console.WriteLine(BDPersonne[i].NomPrsn() + " combien voulez vous envoyer a "+ BDPersonne[prsn].NomPrsn() + "(en euro)");
                    uint Nbr = uint.Parse(Console.ReadLine());

                    uint ArgentPrsn1 = BDPersonne[i].ArgentPersonne;
                    ArgentPrsn1 = ArgentPrsn1 - Nbr;
                    BDPersonne[i].ArgentPersonne = ArgentPrsn1;

                    uint ArgentPrsn2 = BDPersonne[prsn].ArgentPersonne;
                    ArgentPrsn2 = ArgentPrsn2 + Nbr;
                    BDPersonne[prsn].ArgentPersonne = ArgentPrsn2;



                    prsn = i + 1;
                    Console.WriteLine(BDPersonne[prsn].NomPrsn() + " combien voulez vous envoyer a " + BDPersonne[i].NomPrsn() + "(en euro)");
                    Nbr = uint.Parse(Console.ReadLine());

                    ArgentPrsn1 = BDPersonne[prsn].ArgentPersonne;
                    ArgentPrsn1 = ArgentPrsn1 - Nbr;
                    BDPersonne[prsn].ArgentPersonne = ArgentPrsn1;

                    ArgentPrsn2 = BDPersonne[i].ArgentPersonne;
                    ArgentPrsn2 = ArgentPrsn2 + Nbr;
                    BDPersonne[i].ArgentPersonne = ArgentPrsn2;

                    for (int j = 0; j < 2; j++)
                    {
                        Console.WriteLine(BDPersonne[j].NomPrsn() + " vous avez " + BDPersonne[j].ArgentPersonne);
                    }
                    Console.ReadLine();
                }
                Console.WriteLine("Voulez vous recommencer?(oui/non)");
                string Recom = Console.ReadLine();
                if (Recom == "non")
                {
                    Continuer = false;
                }
            }
            while (Continuer);
            
        }
    }
}
