using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopTrump_Klasasafn
{
    public class LotR:Class1
    {
        private string[] Name { get; set; }
        private string[] Culture { get; set; }
        private string[] id { get; set; }
        private string[] CardType { get; set; }
        private string[] Age { get; set; }       
        private int[] Resistance { get; set; }
        private int[] Resilience { get; set; }
        private int[] Ferocity { get; set; }
        private int[] Magic { get; set; }
        private int[] Height { get; set; }
        public LotR(string[] CardDeck) //Settur eiginleikana á réttan stað
        {
            foreach (string cards in CardDeck)
            {
                string[] card = cards.Split(':');
                int i = 0;
                Name[i] = card[1];
                Culture[i] = card[2];
                id[i] = card[3];
                CardType[i] = card[4];
                Age[i] = card[5];
                Resistance[i] = Convert.ToInt32(card[6]);
                Resilience[i] = Convert.ToInt32(card[7]);
                Ferocity[i] = Convert.ToInt32(card[8]);
                Magic[i] = Convert.ToInt32(card[9]);
                Height[i] = Convert.ToInt32(card[10]);
                i++;
            }
        }
        public string[] InitCards()
        {
            string[] CardStack = new string[52];
            CardStack[0] = "Gimli:Dwarf:1:Heart:139:2:7:53:1:5'0";
            CardStack[1] = "Legolas:Elf:2:Heart:7000:2:8:42:14:5'10";
            CardStack[2] = "Aragorn:Human:3:Heart:87:2:7:59:10:6'4";
            CardStack[3] = "Gandalf the Grey:Wizard:4:Heart:2018:3:9:56:19:5'9";
            CardStack[4] = "Frodo Baggins:Hobbit:5:Heart:50:3:10:28:4:3'10";
            CardStack[5] = "Borimir:Human:6:Heart:40:1:6:52:0:5'11";
            CardStack[6] = "Bilbo Baggins:Hobbit:7:Heart:128:2:6:7:5:3'10";
            CardStack[7] = "Treebeard:Ent:8:Heart:17051:2.5:9:15:17:15'4";
            CardStack[8] = "Faramir:Human:9:Heart:38:2:6:52:4:6'0";
            CardStack[9] = "Galadriel:Elf:10:Heart:7500:";
            CardStack[10] = "Meriadoc Merry Brandybuck:Hobbit:11:Heart:36:2:8:38:1:3'11";
            CardStack[11] = "Peregrin Pippin Took:Hobbit:12:Heart:28:2:9:37:1:3'10";
            CardStack[12] = "Sauron:Dark Lord:13:Heart:27061:5:8:45:20:n/a";

            CardStack[13] = "The Witch-King:Ringwraith:14:Spade:4290:1:7:70:18:6'9";
            CardStack[14] = "Gollum:Hobbit:15:Spade:589:0:4:47:4:3'7";
            CardStack[15] = "Elrond:Elf:16:Spade:6517:3:6:38:19:6'2";
            CardStack[16] = "Arwen Evenstar:Elf:17:Spade:2777:2:5:3:14:5'11";
            CardStack[17] = "Saruman The White:Wizard:18:Spade:2019:0:6:49:19.5:6'0";
            CardStack[18] = "Éomer:Human:19:Spade:30:2:6:56:1:5'9";
            CardStack[19] = "Éowyn:Human:20:Spade:26:2:7:54:2:5'8";
            CardStack[20] = "Théoden:Human:21:Spade:70:2:8:60:1:5'9";
            CardStack[21] = "Gil-galad:Elf:22:Spade:3561:2:7:52:14:6'2";
            CardStack[22] = "Isengard Orc:Orc:23:Spade:248:1:2:56:0:5'4";
            CardStack[23] = "Lurtz:Uruk-hai:24:Spade:n/a:1:6:63:0:5'10";
            CardStack[24] = "The Balrog:Demon:25:Spade:13905:3:8:70:19:20'9";
            CardStack[25] = "Moria Orc:Orc:26:Spade:1018:1:1:49:0:5'2";

            CardStack[26] = "Samwise Gamgee:Hobbit:27:Diamond:38:3:9:42:1:3'9";
            CardStack[27] = "Shelob:Arachnid:28:Diamond:7260:2:6:54:4:12'4";
            CardStack[28] = "Gandalf the White:Wizard:29:Diamond:2018:3:10:67:20:5'9";
            CardStack[29] = "Gríma Wormtongue:Human:30:Diamond:59:1:3:21:1:5'6";
            CardStack[30] = "Shadowfax:Horse:31:Diamond:28:2:7:45:14:6'5";
            CardStack[31] = "Denethor:Human:32:Diamond:89:1:6:52:0:6'1";
            CardStack[32] = "Cave Troll:Troll:33:Diamond:4000:1:5:59:0:14'0";
            CardStack[33] = "Gondorian Warrior:Human:34:Diamond:35:2:7:49:0:5'10";
            CardStack[34] = "Berzerker:Uruk-hai:35:Diamond:427:1:6:59:0:5'1";
            CardStack[35] = "Orc:Orc:36:Diamond:2000:0:2:43:0:5'3";
            CardStack[36] = "Cirith Ungol Orc:Orc:37:Diamond:2000:0:2:44:0:5'3";
            CardStack[37] = "Mordor Orc:Orc:38:Diamond:2000:1:2:45:0:5'11";
            CardStack[38] = "Grishnákh:Orc:39:Diamond:761:0:4:53:1:5'4";

            CardStack[39] = "Warg Rider:Orc:40:Clubs:2025:0:6:61:3:n/a";
            CardStack[40] = "Shagrat:Uruk-hai:41:Clubs:540:0:6:59:0:5'9";
            CardStack[41] = "Haradrim:Human:42:Clubs:29:1:5:49:0:5'5";
            CardStack[42] = "Rohirrim:Human:43:Clubs:37:2:7:48:0:5'7";
            CardStack[43] = "Gorbag:Orc:44:Clubs:1860:0:4:53:1:5'4";
            CardStack[44] = "The One Ring:Created by Sauron:45:Clubs:4859:0:7:0:20:n/a";
            CardStack[45] = "Mountain Troll:Troll:46:Clubs:4000:1:5:62:0:14'5";
            CardStack[46] = "Múmakil:Elephant:47:Clubs:65:2:7:55:0:34'3";
            CardStack[47] = "Easterling:Easterling:48:Clubs:35:1:6:50:1:5'6";
            CardStack[48] = "Uglúk:Uruk-hai:49:Clubs:540:0:6:59:0:5'9";
            CardStack[49] = "Sharku:Orc:50:Clubs:2710:1:2:50:1:5'3";
            CardStack[50] = "Dunlending Wildmen:Human:51:Clubs:35:1:5:42:0:5'7";
            CardStack[51] = "Dwarves:Dwarf:52:Clubs:180:2:7:48:2:4'8";
            return CardStack;
        }
       public void DisplayCard(int cardNum)
       {
           Console.WriteLine("Name: " + Name[cardNum]);
           Console.WriteLine("Culture: " + Culture[cardNum]);
           Console.WriteLine("CardType: " + CardType[cardNum]);
           Console.WriteLine("Age: " + Age[cardNum]);          
           Console.WriteLine("Resistance to Ring: " + Resistance[cardNum]);
           Console.WriteLine("Resilience: " + Resilience[cardNum]);
           Console.WriteLine("Ferocity: " + Ferocity[cardNum]);
           Console.WriteLine("Magic: " + Magic[cardNum]);
           Console.WriteLine("Height: " + Height[cardNum]);
       }

     /*  public int Compete(int cardNum, int cardNum2, int competitionCategory)
       {
           if (competitionCategory == 1)
           {
               if (Resistance[cardNum] > Resistance[cardNum2])
               {
                   return 1;
               }
               else if (Resistance[cardNum] < Resistance[cardNum2])
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
               if (Resilience[cardNum] > Resilience[cardNum2])
               {
                   return 1;
               }
               else if (Resilience[cardNum] < Resilience[cardNum2])
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
               if (Ferocity[cardNum] > Ferocity[cardNum2])
               {
                   return 1;
               }
               else if (Ferocity[cardNum] < Ferocity[cardNum2])
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
               if (Magic[cardNum] > Magic[cardNum2])
               {
                   return 1;
               }
               else if (Magic[cardNum] < Magic[cardNum2])
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
		 
	       }
           else if (competitionCategory == 6)
	       {
		 
	       }
           else if (competitionCategory == 7)
	       {
		 
	       }
           else if (competitionCategory == 8)
	       {
		 
	       }           
           else
           {
               return 4;
           }          
       } */

    }
}
