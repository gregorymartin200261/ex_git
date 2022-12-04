using System;
using System.Collections.Generic;
using System.Text;

namespace Sandwichs_aléatoires
{
    class SandwichMaker
    {
        string[] _proteine = { "jambon", "fromage", "roast beef", "salami" };
        string[] _condiments = { "moutarde", "guacamole", "mayo", "Purée d'haricots noirs" };
        string[] _pain = { "pain de campagne", "pain complet", "pain de seigle", "pains spéciaux" };
        string[] _crudites = { "salades", "tomates", "carotes", "oignons" };

        public string RndmProteine()
        {
            Random rnd = new Random();
            int min = 0;
            int max = 4;
            return _proteine[rnd.Next(min, max)];
        }
        public string RndmCondiments()
        {
            Random rnd = new Random();
            int min = 0;
            int max = 4;
            return _condiments[rnd.Next(min, max)];
        }
        public string RndmPain()
        {
            Random rnd = new Random();
            int min = 0;
            int max = 4;
            return _pain[rnd.Next(min, max)];
        }
        public string RndmCrudites()
        {
            Random rnd = new Random();
            int min = 0;
            int max = 4;
            return _crudites[rnd.Next(min, max)];
        }
    }
}
