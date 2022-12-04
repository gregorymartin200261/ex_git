using System;

namespace Sandwichs_aléatoires
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Continuer = true;

            do
            {
                Console.Clear();
                SandwichMaker SandwichMaker = new SandwichMaker();
                Console.WriteLine("Votre sandwish contient: " + SandwichMaker.RndmProteine() +" ; "+ SandwichMaker.RndmCondiments() + " ; " + SandwichMaker.RndmPain() + " ; " + SandwichMaker.RndmCrudites());
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
