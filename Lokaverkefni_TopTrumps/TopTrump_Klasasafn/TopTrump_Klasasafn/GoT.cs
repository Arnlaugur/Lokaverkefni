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
            CardStack[7] = "Robert Baratheon:8:37:heart:7:7:9:6:9:2:4:5";
            CardStack[8] = "Margaery Tyrell";	
            CardStack[9] = "Renly Baratheon:10:22:heart:";
            CardStack[10] = "Melisandre:11:396:heart:10:3:4:10:8:3:9:7";
            CardStack[11] = "Bronn";
            CardStack[12] = "The High Sparrow";

            CardStack[13] = "Hodor";
            CardStack[14] = "Eddard Stark:14:";
            CardStack[15] = "Catelyn Stark:15";
            CardStack[16] = "Robb Stark";
            CardStack[17] = "Brandon Stark";
            CardStack[18] = "Jon Snow";
            CardStack[19] = "Ygritte";
            CardStack[20] = "Samwell Tarly";
            CardStack[21] = "Arya Stark";
            CardStack[22] = "Sansa Stark";
            CardStack[23] = "Petyr Baelish";
            CardStack[24] = "Gilly";
            CardStack[25] = "Tormund Giantsbane";

            CardStack[26] = "Brienne of Tarth";
            CardStack[27] = "Daenerys Targaryen";
            CardStack[28] = "Viserys Targaryen";
            CardStack[29] = "Varys";
            CardStack[30] = "Jeor Mormont";
            CardStack[31] = "Jaqen H'ghar";
            CardStack[32] = "Daario Naharis";
            CardStack[33] = "Missandei";
            CardStack[34] = "Ellaria Sand";
            CardStack[35] = "Loras Tyrell";
            CardStack[36] = "Syrio Forel";
            CardStack[37] = "Khal Drogo";
            CardStack[38] = "The Waif";

            CardStack[39] = "Podrick Payne";
            CardStack[40] = "Yara Greyjoy";
            CardStack[41] = "Theon Greyjoy";
            CardStack[42] = "Ramsay Bolton";
            CardStack[43] = "Roose Bolton";
            CardStack[44] = "Stannis Baratheon:9:35:heart:";
            CardStack[45] = "Maester Aemon";
            CardStack[46] = "Janos Slynt";
            CardStack[47] = "Alliser Thorne";
            CardStack[48] = "Mance Rayder";
            CardStack[49] = "Bowen Marsh";
            CardStack[50] = "Varamyr Sixskins";
            CardStack[51] = "Eddison Tollett";
            return CardStack;
        }
       public void DisplayCard(int cardNum)
       {
           Console.WriteLine("Name: " + Name[cardNum]);
           Console.WriteLine("Age: " + Age[cardNum]);
           Console.WriteLine("CardType: " + CardType[cardNum]);
           Console.WriteLine("Wit: " + Wit[cardNum]);
           Console.WriteLine("Strength: " + Strength[cardNum]);
           Console.WriteLine("Leadership: " + Leadership[cardNum]);
           Console.WriteLine("Piety: " + Piety[cardNum]);
           Console.WriteLine("Prestige: " + Prestige[cardNum]);
           Console.WriteLine("Agility: " + Agility[cardNum]);
           Console.WriteLine("Intrigue: " + Intrigue[cardNum]);
           Console.WriteLine("Stewardship: " + Stewardship[cardNum]);
       }
       
        public int Compete(int cardNum1, int cardNum2, int competitionCategory)
       {
           if (competitionCategory == 1)
           {
                if (Wit[cardNum1] > Wit[cardNum2])
                {
                    return 1;
                }
                else if (Wit[cardNum1] < Wit[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
           }
           else if (competitionCategory == 2)
           {
                if (Strength[cardNum1] > Strength[cardNum2])
                {
                    return 1;
                }
                else if (Strength[cardNum1] < Strength[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 3)
           {
                if (Leadership[cardNum1] > Leadership[cardNum2])
                {
                    return 1;
                }
                else if (Leadership[cardNum1] < Leadership[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 4)
           {
                if (Piety[cardNum1] > Piety[cardNum2])
                {
                    return 1;
                }
                else if (Piety[cardNum1] < Piety[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 5)
	       {
                if (Prestige[cardNum1] > Prestige[cardNum2])
                {
                    return 1;
                }
                else if (Prestige[cardNum1] < Prestige[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 6)
	       {
                if (Agility[cardNum1] > Agility[cardNum2])
                {
                    return 1;
                }
                else if (Agility[cardNum1] < Agility[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 7)
	       {
                if (Intrigue[cardNum1] > Intrigue[cardNum2])
                {
                    return 1;
                }
                else if (Intrigue[cardNum1] < Intrigue[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
           else if (competitionCategory == 8)
	       {
                if (Stewardship[cardNum1] > Stewardship[cardNum2])
                {
                    return 1;
                }
                else if (Stewardship[cardNum1] < Stewardship[cardNum2])
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else
            {
                return 4;
            }
           
       }
    }
}
