using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrump_Klasasafn
{
    class GoT
    {
        private string[] Name { get; set; }
        private string[] id { get; set; }
        private string[] Age { get; set; }
        private string[] CardType { get; set; }
        private int[] Wit { get; set; }
        private int[] Strength { get; set; }
        private int[] Leadership { get; set; }
        private int[] Piety { get; set; }
        private int[] Prestige { get; set; }
        private int[] Agility { get; set; }
        private int[] Intrigue { get; set; }
        private int[] Stewardship { get; set; }
        public GoT(string[] CardDeck) //Settur eiginleikana á réttan stað
        {
            foreach (string cards in CardDeck)
            {
                string[] card = cards.Split(':');
                int i = 0;
                Name[i] = card[1];
                id[i] = card[2];
                Age[i] = card[3];
                CardType[i] = card[4];
                Wit[i] = Convert.ToInt32(card[5]);
                Strength[i] = Convert.ToInt32(card[6]);
                Leadership[i] = Convert.ToInt32(card[7]);
                Piety[i] = Convert.ToInt32(card[8]);
                Prestige[i] = Convert.ToInt32(card[9]);
                Agility[i] = Convert.ToInt32(card[10]);
                Intrigue[i] = Convert.ToInt32(card[11]);
                Stewardship[i] = Convert.ToInt32(card[12]);
                i++;
            }
        }
        public string InitCards()
        {

        }
       string[] CardStack = new string[52];
    }
}
