using System;

namespace CalculMental
{
    class Program
    {
        static void Main(string[] args)
        {
            Random alea = new Random();
            Console.WriteLine("Bienvenue dans ce petit programme de calcul mental.");
            Calcul r = new Calcul((int)alea.Next(2) == 1);
            while (true)
            {
                Console.Write($"{r.N1}{r.Op}{r.N2} = ");
                string rep = Console.ReadLine();
                int repEntiere;
                // mauvaise entrée utilisateur
                if (!int.TryParse(rep, out repEntiere))
                {
                    Console.WriteLine("Merci d'avoir joué");
                    return;
                }
                // vérification de la réponse
                else if (r.VerifOpe(repEntiere))
                {
                    Console.WriteLine("Correct !");
                    r = new  Calcul((int)alea.Next(2) == 1);
                }
                // mauvaise réponse au calcul
                else
                {
                    Console.WriteLine("Erreur, recommencez !");
                }
            }
        }
    }
}
