using System;

namespace HERITAGE
{
    class Program
    {
        static void Main(string[] args)
        {
            chien[] Dog = new chien[1];
            Dog[0] = new chien("Max", new DateTime(2015, 12, 25), 1234, 75, false);

            Chat[] Cat = new Chat[1];
            Cat[0] = new Chat("Clochette", new DateTime(2022, 12, 25), 5678, 50, false);

            Lapin[] Rabit = new Lapin[1];
            Rabit[0] = new Lapin(5,"PonPon", new DateTime(2021, 7, 25), 9012, 20, true);
                
            Console.WriteLine("Le chien qui s'appel "+ Dog[0].nom+" est entrain de dormir : "+Dog[0].dormir() + " ,ensuite il est parti manger : "+Dog[0].manger()+" et pour finir iles est parti aboyer : "+Dog[0].aboyer());
            Console.WriteLine("Le chien  s'appel "+ Dog[0].nom+" taille : "+Dog[0].taille+"cm N° de puce : "+Dog[0].numeroDePuce+" Age : "+Dog[0].dateDeNaissance+" Est un animal de concours? : "+Dog[0].animalDeConcours);
            
            Console.WriteLine("Le chat qui s'appel "+ Cat[0].nom+" est entrain de dormir : "+Cat[0].dormir() + " ,ensuite il est parti manger : "+Cat[0].manger()+" et pour finir iles est parti miauler : "+Cat[0].miauler()+" il s'est ensuite calmé et a ronronner "+Cat[0].ronronner());
            Console.WriteLine("Le chat  s'appel "+ Cat[0].nom+" taille : "+Cat[0].taille+"cm N° de puce : "+Cat[0].numeroDePuce+" Age : "+Cat[0].dateDeNaissance+" Est un animal de concours? : "+Cat[0].animalDeConcours);
            
            Console.WriteLine("Le lapin qui s'appel "+ Rabit[0].nom+" est entrain de dormir : "+Rabit[0].dormir() + " ,ensuite il est parti manger : "+Rabit[0].manger()+" et pour finir iles est parti bondir : "+Rabit[0].bonds());
            Console.WriteLine("Le lapin  s'appel "+ Rabit[0].nom+" taille : "+Rabit[0].taille+"cm taille d'oreilles : "+Rabit[0].tailleOreilles+" N° de puce : "+Rabit[0].numeroDePuce+" Age : "+Rabit[0].dateDeNaissance+" Est un animal de concours? : "+Rabit[0].animalDeConcours);

            Console.ReadLine();
        }
    }
}
