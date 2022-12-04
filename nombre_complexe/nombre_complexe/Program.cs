using System;

namespace nombre_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continuer = true;

            do
            {
                Console.Clear();
                Complexe[] Complexe = new Complexe[2];
                int i = 0;
                Console.WriteLine("quel est le reel n°1 du complexe de depart?");
                double reel1 = (int.Parse(Console.ReadLine()));
                Console.WriteLine("quel est le reel n°2 du complexe de depart?");
                double reel2 = (int.Parse(Console.ReadLine()));

                Complexe[i] = new Complexe(reel1, reel2);
                double module = Complexe[0].CalculeModule();

                Console.WriteLine(Complexe[i].AfficheComplexe(module));

                i++;

                Console.WriteLine("quel est le reel n°1 du second complexe?");
                reel1 = (int.Parse(Console.ReadLine()));
                Console.WriteLine("quel est le reel n°2 du second complexe?");
                reel2 = (int.Parse(Console.ReadLine()));

                Complexe[i] = new Complexe(reel1, reel2);

                double reel1Ajoute=Complexe[1].reel1;
                double ajouteFinal1 = Complexe[0].ajoute1(reel1Ajoute);

                double reel2Ajoute = Complexe[1].reel2;
                double ajouteFinal2 = Complexe[0].ajoute2(reel2Ajoute);

                Console.WriteLine("le complexe de base dedvient : ("+ajouteFinal1 + ","+ ajouteFinal2+")");
                Console.ReadLine();
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
