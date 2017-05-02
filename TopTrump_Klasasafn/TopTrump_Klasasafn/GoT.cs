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
        private string CardType { get; set; }
        private int Wit { get; set; }
        private int Strength { get; set; }
        private int Leadership { get; set; }
        private int Piety { get; set; }
        private int Prestige { get; set; }
        private int Agility { get; set; }
        private int Intrigue { get; set; }
        private int Stewardship { get; set; }
        public GoT(string[] CardDeck) //Settur eiginleikana á réttan stað
        {
            foreach (string cards in CardDeck)
            {
                string[] card = cards.Split(':');
                Name = card[1];
                id = card[2];
                Age = card[3];
                CardType = card[4];
                Wit = Convert.ToInt32(card[5]);
                Strength = Convert.ToInt32(card[6]);
                Leadership = Convert.ToInt32(card[7]);
                Piety = Convert.ToInt32(card[8]);
                Prestige = Convert.ToInt32(card[9]);
                Agility = Convert.ToInt32(card[10]);
                Intrigue = Convert.ToInt32(card[11]);
                Stewardship = Convert.ToInt32(card[12]);
            }
        }
        public string InitCards()
        {

        }
       string[] CardStack = new string[52];
    }
}
