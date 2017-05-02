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
        public string[] InitCards()
        {
            string[] CardStack = new string[52];
            CardStack[0] = "Tyrion Lannister:1:26:heart:10:3:6:1:7:1:9:9";
            CardStack[1] = "Jamie Lannister:2:33:heart:7:8:7:6:10:8:3:4";
            CardStack[2] = "Cersei Lannister:3:33:heart:9:4:3:5:8:6:9:8";
            CardStack[3] = "Tywin Lannister:4:64:heart:10:6:9:4:10:6:9:8";
            CardStack[4] = "Gregor Clegane:5:34:heart:2:10:1:3:9:7:1:3";
            CardStack[5] = "Joffrey Baratheon:6:17:heart:5:6:4:3:7:7:3:2";
            CardStack[6] = "Sandor Clegane:7:29:heart:7:8:3:2:8:8:5:3";

            return CardStack;
        }
       
    }
}
