using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrump_Klasasafn
{
    class GoT
    {
        private string Name { get; set; }
        private string id { get; set; }
        private string Age { get; set; }
        private int Wit { get; set; }
        private int Strength { get; set; }
        private int Leadership { get; set; }
        private int Piety { get; set; }
        private int Prestige { get; set; }
        private int Agility { get; set; }
        private int Intrigue { get; set; }
        private int Stewardship { get; set; }
        public GoT(List<string> card) //Settur eiginleikana á réttan stað
        {
            Name = card[1];
            id = card[2];
            Age = card[3];
            Wit = Convert.ToInt32(card[4]);
            Strength = Convert.ToInt32(card[5]);
            Leadership = Convert.ToInt32(card[6]);
            Piety = Convert.ToInt32(card[7]);
            Prestige = Convert.ToInt32(card[8]);
            Agility = Convert.ToInt32(card[9]);
            Intrigue = Convert.ToInt32(card[10]);
            Stewardship = Convert.ToInt32(card[11]);
        }
        List<List<string>> list = new List<List<string>>();
        List<string> card1 = new List<string>();
    }
}
