using System;

namespace Heritage2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier[] Worker = new Ouvrier[10];
            Worker[0] = new Ouvrier(new DateTime(2005, 10, 25),1,"Colops","Mark",new DateTime(1998, 12, 25));
            Worker[1] = new Ouvrier(new DateTime(2013, 1, 25),2,"Parker","Mark",new DateTime(2000, 12, 25));
            Worker[2] = new Ouvrier(new DateTime(2014, 2, 25),3,"Colops","Martin",new DateTime(2001, 12, 25));
            Worker[3] = new Ouvrier(new DateTime(2012, 3, 25),4,"Paterson","Greg",new DateTime(2002, 12, 25));
            Worker[4] = new Ouvrier(new DateTime(1990, 4, 25),5,"Colops","Nico",new DateTime(1978, 11, 25));

            Cadre[] Framework = new Cadre[3];
            Framework[0] = new Cadre(1,6,"Henry","Nico",new DateTime(1999, 11, 25));
            Framework[1] = new Cadre(3,7,"Paterson","Nico",new DateTime(1998, 11, 25));
            Framework[2] = new Cadre(4,8,"Parker","Nico",new DateTime(2000, 11, 25));

            Directeur[] Boss = new Directeur[2];
            Double ChiffreAffaireDure=100000;//euros
            Boss[0] = new Directeur(ChiffreAffaireDure,9,"Gates","Bool",new DateTime(1997, 12, 25));
            Boss[1] = new Directeur(ChiffreAffaireDure,10,"Gates","Bile",new DateTime(1996, 11, 25));

            Console.WriteLine("Voici les informations sur les ouvriers : ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Worker[i].AfficheSpec()+" date d'entré : " + Worker[i].enterDate+" Salaire : " + Worker[i].CalculSalaire());
            }
            Console.WriteLine("Voici les informations sur les cadres : ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Framework[i].AfficheSpec()+" indice : " + Framework[i].indice+" Salaire : " + Framework[i].CalculSalaire());
            }
            Console.WriteLine("Voici les informations sur les directeurs : ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Boss[i].AfficheSpec()+" chiffreAffaires : " + Boss[i].chiffreAffaires+" Salaire : " + Boss[i].CalculSalaire());
            }

            Console.ReadLine();
        }
    }
}