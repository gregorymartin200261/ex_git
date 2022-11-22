using System;

namespace Cercle
{
    class Program
    {
        static void Main(string[] args)
        {
            string recommencer;

            do
            {
                Console.WriteLine("quel est le rayon du cercle?");
                Cercle rayon = new Cercle(int.Parse(Console.ReadLine()));
                Console.Clear();

                double Air = rayon.CalculeAire();
                double Perimetre = rayon.CalculePerimetre();
                string phrase = rayon.Affiche();
                //double Phrase = rayon.AfficheCaracteristique

                Console.WriteLine(phrase +"une air de " +Air);
                Console.WriteLine(phrase+"un perimettre de " +Perimetre);
                Console.WriteLine("--------------------------------------");

                rayon.Rayon /= 2;
                double moitAir = rayon.CalculeAire();
                double moitPerimetre = rayon.CalculePerimetre();
                string phrase2 = rayon.Affiche();
                Console.WriteLine(phrase2+"une air de " + moitAir);
                Console.WriteLine(phrase2+"un perimettre de " + moitPerimetre);

                Console.WriteLine("un nouveau cerlce?(oui/enter)");
                recommencer = Console.ReadLine();
            }
            while (recommencer=="oui");
        }

    }
}

