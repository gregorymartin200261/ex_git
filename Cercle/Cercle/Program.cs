using System;

namespace Cercle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            bool continuer = true;

            while (continuer)
            {
                x++;
                Console.WriteLine("quel est le rayon du cercle?");
                Cercle rayon = new Cercle(int.Parse(Console.ReadLine()));
                Console.Clear();

                double Air = rayon.CalculeAire();
                double Perimetre = rayon.CalculePerimetre();
                //double Phrase = rayon.AfficheCaracteristique
            }

        }

    }
}

