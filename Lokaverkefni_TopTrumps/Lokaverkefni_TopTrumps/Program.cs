using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrump_Klasasafn;
//Arnlaugur og Bjarki 22.4.2017
namespace Lokaverkefni_TopTrumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 KlassLibrary = new Class1();
            int UserInput = 99;
            while(UserInput != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Veldu Hvað þú vilt gera");
                Console.WriteLine("1. Sýna Reglur");
                Console.WriteLine("2. Taka leik af GOT TopTrumps");
                Console.WriteLine("3. Taka leik af LOTR TopTrumps");
                Console.WriteLine("0. Hætta");
                Console.WriteLine("");
                UserInput = Convert.ToInt32(Console.ReadLine());
                switch (UserInput)
                {
                    case 1:
                        Console.WriteLine(KlassLibrary.Reglur());
                        Console.ReadKey();
                        break;
                        
                    case 2:
                        int b = -1;
                        int c = 26;
                        int d = 26;
                        int CompCat = 0;
                        int[] cards = KlassLibrary.SkyptaKortum();
                        int[] Player1Deck = new int[52];
                        int[] Player2Deck = new int[52];
                        for (int i = 0; i < 26; i++)
                        {
                            int a = 0;
                            Player1Deck[a] = cards[i];
                            i = i + 1;
                            Player2Deck[a] = cards[i];
                            a++;
                        }
                        while (UserInput != 0)
                        {
                        b++;
                        GoT got = new GoT(Player1Deck[b], Player2Deck[b]);
                        Console.WriteLine("");
                        Console.WriteLine("1. Skoða Kortið Þitt");
                        Console.WriteLine("2. Velja Grein");
                        Console.WriteLine("0. Hætta");
                        Console.WriteLine("");
                        UserInput = Convert.ToInt32(Console.ReadLine());
                            switch (UserInput)
                            {
                                case 1:
                                    got.DisplayCard(Player1Deck[b]);
                                    break;
                                case 2:
                                    Console.WriteLine("");
                                    Console.WriteLine("Hvaða grein viltu keppa í?");
                                    Console.WriteLine("1. Wit");
                                    Console.WriteLine("2. Strength");
                                    Console.WriteLine("3. Leadership");
                                    Console.WriteLine("4. Piety");
                                    Console.WriteLine("5. Prestige");
                                    Console.WriteLine("6. Agility");
                                    Console.WriteLine("7. Intrigue");
                                    Console.WriteLine("8. Stewardship");
                                    Console.WriteLine("");
                                    
                                    CompCat = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Þú spilaðir: ");
                                    got.DisplayCard(Player1Deck[b]);
                                    Console.WriteLine("");
                                    Console.WriteLine("Hann spilaði: ");
                                    got.DisplayCard2(Player2Deck[b]);
                                    Console.WriteLine("");

                                    if (b == 26)
                                    {
                                        b = 0;
                                    }
                                    if (d == 51)
                                    {
                                        Console.WriteLine("Þú vannst leikin");
                                    }
                                    else if (c == 51)
                                    {
                                        Console.WriteLine("Þú tapaðir leiknum");
                                    }

                                    else
                                    {
                                        if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 1)
                                        {
                                            Player1Deck[b] = Player2Deck[c];
                                            c = c - 1;
                                            d = d + 1;
                                            Console.WriteLine("Þú vannst og hefur nú " + (d) + " kort af 52");
                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 2)
                                        {
                                            Player2Deck[b] = Player1Deck[d];
                                            c = c + 1;
                                            d = d - 1;
                                            Console.WriteLine("Þú tapaðir og hefur nú " + (d) + " kort af 52");
                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 3)
                                        {
                                            Console.WriteLine("Jafntefli næsti gerir");
                                            
                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 4)
                                        {
                                            Console.WriteLine("Villa komm upp reyndu aftur");
                                        }
                                        
                                    }
                                    break;
                            }
                }
                break;
                }
            }

            
        }
    }
}
