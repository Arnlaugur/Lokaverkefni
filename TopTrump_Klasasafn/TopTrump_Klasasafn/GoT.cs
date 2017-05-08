using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrump_Klasasafn
{
    class GoT:Class1
    {
        string[] CardStack = new string[52];
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
        public GoT() //Settur eiginleikana á réttan stað
        {
            foreach (string cards in CardStack)
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
            
            CardStack[0] = "Tyrion Lannister:1:26:heart:10:3:6:1:7:1:9:9";
            CardStack[1] = "Jamie Lannister:2:33:heart:7:8:7:6:10:8:3:4";
            CardStack[2] = "Cersei Lannister:3:33:heart:9:4:3:5:8:6:9:8";
            CardStack[3] = "Tywin Lannister:4:64:heart:10:6:9:4:10:6:9:8";
            CardStack[4] = "Gregor Clegane:5:34:heart:2:10:1:3:9:7:1:3";
            CardStack[5] = "Joffrey Baratheon:6:17:heart:5:6:4:3:7:7:3:2";
            CardStack[6] = "Sandor Clegane:7:29:heart:7:8:3:2:8:8:5:3";
            CardStack[7] = "Robert Baratheon:8:37:heart:7:7:9:6:9:2:4:5";
            CardStack[8] = "Margaery Tyrell:9:21:heart:8:2:7:2:5:3:8:3";
            CardStack[9] = "Renly Baratheon:10:22:heart:4:6:6:8:1:8:3:1";
            CardStack[10] = "Melisandre:11:396:heart:10:3:4:10:8:3:9:7";
            CardStack[11] = "Bronn:12:54:heart:7:6:6:7:10:1:7:6";
            CardStack[12] = "The High Sparrow:13:70:heart:9:3:1:7:6:10:7:1";

            CardStack[13] = "Hodor:14:28:Spade:2:10:3:9:3:1:2:8";
            CardStack[14] = "Eddard Stark:15:36:Spade:7:7:10:1:2:3:7:8";
            CardStack[15] = "Catelyn Stark:16:34:Spade:6:3:5:2:7:2:6:8";
            CardStack[16] = "Robb Stark:17:16:Spade:5:7:3:10:7:1:6:1";
            CardStack[17] = "Bran Stark:18:10:Spade:5:2:2:8:10:1:7:5";
            CardStack[18] = "Jon Snow:19:17:Spade:7:8:2:5:3:10:6:3";
            CardStack[19] = "Ygritte:20:19:Spade:6:7:9:1:3:1:3:7";
            CardStack[20] = "Samwell Tarly:21:17:Spade:6:5:5:2:5:8:4:1";
            CardStack[21] = "Arya Stark:22:11:Spade:6:7:10:6:4:6:7:9";
            CardStack[22] = "Sansa Stark:23:14:Spade:6:3:2:1:4:9:6:10";
            CardStack[23] = "Petyr Baelish:24:32:Spade:10:4:2:5:4:8:6:9";
            CardStack[24] = "Gilly:25:17:Spade:5:1:7:4:3:5:9:4";
            CardStack[25] = "Tormund Giantsbane:26:38:Spade:5:10:10:4:4:6:8:3";

            CardStack[26] = "Brienne of Tarth:27:20:Diamond:5:10:1:8:10:2:7:8";
            CardStack[27] = "Daenerys Targaryen:28:16:Diamond:7:3:8:6:9:3:4:9";
            CardStack[28] = "Viserys Targaryen:29:22:Diamond:7:4:6:10:5:9:8:3";
            CardStack[29] = "Varys:30:30:Diamond:10:3:2:4:7:4:1:4";
            CardStack[30] = "Jeor Mormont:31:69:Diamond:5:8:1:8:9:1:2:3";
            CardStack[31] = "Jaqen H'ghar:32:30:Diamond:10:6:8:5:10:5:7:1";
            CardStack[32] = "Daario Naharis:33:22:Diamond:5:9:6:1:8:3:9:3";
            CardStack[33] = "Missandei:34:12:Diamond:9:1:1:10:6:8:4:8";
            CardStack[34] = "Ellaria Sand:35:27:Diamond:8:6:5:10:3:10:7:5";
            CardStack[35] = "Loras Tyrell:36:18:Diamond:4:7:8:6:3:10:9:1";
            CardStack[36] = "Syrio Forel:37:35:Diamond:8:10:5:4:9:8:3:5";
            CardStack[37] = "Khal Drogo:38:31:Diamond:5:10:6:9:5:8:4:10";
            CardStack[38] = "The Waif:39:37:Diamond:8:10:7:1:5:10:3:6";

            CardStack[39] = "Podrick Payne:40:14:Clubs:5:5:2:1:10:1:8:9";
            CardStack[40] = "Yara Greyjoy:41:25:Clubs:6:8:8:10:1:7:6:1";
            CardStack[41] = "Theon Greyjoy:42:22:Clubs:4:6:4:6:10:1:4:2";
            CardStack[42] = "Ramsay Bolton:43:18:Clubs:8:8:1:6:8:9:6:10";
            CardStack[43] = "Roose Bolton:44:40:Clubs:9:7:7:1:7:8:5:4";
            CardStack[44] = "Stannis Baratheon:45:35:Clubs:7:6:2:10:5:2:4:10";
            CardStack[45] = "Maester Aemon:46:102:Clubs:10:1:9:6:3:1:6:8";
            CardStack[46] = "Janos Slynt:47:28:Clubs:3:5:3:9:3:2:1:6";
            CardStack[47] = "Alliser Thorne:48:52:Clubs:5:6:3:7:4:3:5:6";
            CardStack[48] = "Mance Rayder:49:50:Clubs:6:9:3:1:10:3:4:2";
            CardStack[49] = "Bowen Marsh:50:30:Clubs:5:6:8:1:8:10:9:5";
            CardStack[50] = "Varamyr Sixskins:51:40:Clubs:7:3:7:1:7:3:8:2";
            CardStack[51] = "Eddison Tollett:52:20:Clubs:5:6:8:9:6:5:7:9";
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
       
        public int Compete(int cardNum, int cardNum2 , int competitionCategory)
       {
            if (competitionCategory == 1)
            {
                if (Wit[cardNum] > Wit[cardNum2])
                {
                    return 1;
                }
                else if (Wit[cardNum] < Wit[cardNum2])
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
                if (Strength[cardNum] > Strength[cardNum2])
                {
                    return 1;
                }
                else if (Strength[cardNum] < Strength[cardNum2])
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
                if (Leadership[cardNum] > Leadership[cardNum2])
                {
                    return 1;
                }
                else if (Leadership[cardNum] < Leadership[cardNum2])
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
                if (Piety[cardNum] > Piety[cardNum2])
                {
                    return 1;
                }
                else if (Piety[cardNum] < Piety[cardNum2])
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
                if (Prestige[cardNum] > Prestige[cardNum2])
                {
                    return 1;
                }
                else if (Prestige[cardNum] < Prestige[cardNum2])
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
                if (Agility[cardNum] > Agility[cardNum2])
                {
                    return 1;
                }
                else if (Agility[cardNum] < Agility[cardNum2])
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
                if (Intrigue[cardNum] > Intrigue[cardNum2])
                {
                    return 1;
                }
                else if (Intrigue[cardNum] < Intrigue[cardNum2])
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
                if (Stewardship[cardNum] > Stewardship[cardNum2])
                {
                    return 1;
                }
                else if (Stewardship[cardNum] < Stewardship[cardNum2])
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
