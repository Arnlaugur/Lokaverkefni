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
            Class1 KlassLibrary = new Class1(); //Tengist við klassasafn
            int UserInput = 99; //UserInput tekur við inslátt frá notanda
            while (UserInput != 0) //Keyrist þangað til að notandi slær inn 0
            {
                Console.WriteLine(""); //Skrifað er út val fyrir notanda
                Console.WriteLine("Veldu Hvað þú vilt gera");
                Console.WriteLine("1. Sýna Reglur");
                Console.WriteLine("2. Taka leik af GOT TopTrumps");
                Console.WriteLine("3. Taka leik af LOTR TopTrumps");
                Console.WriteLine("0. Hætta");
                Console.WriteLine("");

                UserInput = Convert.ToInt32(Console.ReadLine()); //Tekið in val notanda

                switch (UserInput) //Valmynd
                {
                    case 1: //Skrifar út reglur
                        Console.WriteLine(KlassLibrary.Reglur());
                        Console.ReadKey();
                        break;

                    case 2: //Spilar GOT TopTrumps

                        int b = -1; //Notað til að geyma hversu hátt stokkurin er komin
                        int c = 26; //Notað til að geyma hendi notanda
                        int d = 26; //Notað til að geyma hendi tölvu
                        int CompCat = 0; //Notað til að gama grein sem kept er í
                        int[] cards = KlassLibrary.SkyptaKortum(); //Skyptir kortum á milli spilara
                        int[] Player1Deck = new int[52]; //Stakkur fyrir spilara1
                        int[] Player2Deck = new int[52]; //Stakkur fyrir spilara2

                        for (int i = 0; i < 26; i++) //Forlykja til að dreyfa spilum
                        {
                            int a = 0;
                            Player1Deck[a] = cards[i];
                            i = i + 1;
                            Player2Deck[a] = cards[i];
                            a++;
                        }
                        while (UserInput != 0) //Keyrist þangað til notandi velur 0
                        {
                            b++;
                            GoT got = new GoT(Player1Deck[b], Player2Deck[b]); //Tengist við GoT klassan

                            Console.WriteLine(""); //Gefur notanda val
                            Console.WriteLine("1. Skoða Kortið Þitt");
                            Console.WriteLine("2. Velja Grein");
                            Console.WriteLine("0. Hætta");
                            Console.WriteLine("");

                            UserInput = Convert.ToInt32(Console.ReadLine()); //Tekur in val notanda
                            switch (UserInput) //Valmynd
                            {
                                case 1: //Sýnir kort notanda
                                    got.DisplayCard(Player1Deck[b]);
                                    break;

                                case 2: //Gefur notanda val á greinum

                                    //Gleymdum að gera leið fyrir tölvuna að velja grein

                                    Console.WriteLine(""); //Gefur notanda val
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

                                    CompCat = Convert.ToInt32(Console.ReadLine()); //Tekur inn val notanda

                                    Console.WriteLine("Þú spilaðir: "); //Segir notanda hvaða spil hann spilaði
                                    got.DisplayCard(Player1Deck[b]);
                                    Console.WriteLine("");
                                    Console.WriteLine("Hann spilaði: "); //Segir notanda hvaða spil tölvan spilaði
                                    got.DisplayCard2(Player2Deck[b]);
                                    Console.WriteLine("");

                                    if (b == 26) 
                                    {
                                        b = 0; //Endurstillir b
                                    }
                                    if (d == 51) //Ef notandi vinnur
                                    {
                                        Console.WriteLine("Þú vannst leikin");
                                    }
                                    else if (c == 51) //Ef tölva vinnur
                                    {
                                        Console.WriteLine("Þú tapaðir leiknum");
                                    }

                                    else 
                                    {
                                        if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 1) //Ef notandi vinnur umferð
                                        {
                                            Player1Deck[b] = Player2Deck[c];
                                            c = c - 1;
                                            d = d + 1;
                                            Console.WriteLine("Þú vannst og hefur nú " + (d) + " kort af 52");
                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 2) //Ef tölva vinnur umferð
                                        {
                                            Player2Deck[b] = Player1Deck[d];
                                            c = c + 1;
                                            d = d - 1;
                                            Console.WriteLine("Þú tapaðir og hefur nú " + (d) + " kort af 52");
                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 3) //Ef það er jafntefli
                                        {
                                            Console.WriteLine("Jafntefli næsti gerir");

                                        }
                                        else if (got.Compete(Player1Deck[b], Player2Deck[b], CompCat) == 4) //Ef eitthvað fer úrskeiðis
                                        {
                                            Console.WriteLine("Villa komm upp reyndu aftur");
                                        }

                                    }
                                    break;

                            }
                        }
                        break;
                        case 3:
                        int b2 = -1; //Notað til að geyma hversu hátt stokkurin er komin
                        int c2 = 26; //Notað til að geyma hendi notanda
                        int d2 = 26; //Notað til að geyma hendi tölvu
                        int CompCat2 = 0; //Notað til að gama grein sem kept er í
                        int[] cards2 = KlassLibrary.SkyptaKortum(); //Skyptir kortum á milli spilara
                        int[] Player1Deck2 = new int[52]; //Stakkur fyrir spilara1
                        int[] Player2Deck2 = new int[52]; //Stakkur fyrir spilara2
                        for (int i = 0; i < 26; i++) //Forlykja til að dreyfa spilum
                        {
                            int a = 0;
                            Player1Deck2[a] = cards2[i];
                            i = i + 1;
                            Player2Deck2[a] = cards2[i];
                            a++;
                        }
                        while (UserInput != 0) //Keyrist þangað til notandi velur 0
                        {
                            b2++;
                            LotR lotr = new LotR(Player1Deck2[b2], Player2Deck2[b2]); //Tengist við Lotr klassan
                            Console.WriteLine(""); //Gefur notanda val
                            Console.WriteLine("1. Skoða Kortið Þitt");
                            Console.WriteLine("2. Velja Grein");
                            Console.WriteLine("0. Hætta");
                            Console.WriteLine("");
                            UserInput = Convert.ToInt32(Console.ReadLine()); //Tekur in val notanda
                            switch (UserInput) //Valmynd
                            {
                                case 1: //Sýnir kort notanda
                                    lotr.DisplayCard(Player1Deck2[b2]);
                                    break;
                                case 2: //Gefur notanda val á greinum
                                    Console.WriteLine(""); //Gefur notanda val
                                    Console.WriteLine("Hvaða grein viltu keppa í?");
                                    Console.WriteLine("1. Resistance");
                                    Console.WriteLine("2. Resilience");
                                    Console.WriteLine("3. Ferocity");
                                    Console.WriteLine("4. Magic");
                                    Console.WriteLine("");

                                    CompCat2 = Convert.ToInt32(Console.ReadLine()); //Tekur inn val notanda

                                    Console.WriteLine("Þú spilaðir: "); //Segir notanda hvaða spil hann spilaði
                                    lotr.DisplayCard(Player1Deck2[b2]);
                                    Console.WriteLine("");
                                    Console.WriteLine("Hann spilaði: "); //Segir notanda hvaða spil tölvan spilaði
                                    lotr.DisplayCard2(Player2Deck2[b2]);
                                    Console.WriteLine("");

                                    if (b2 == 26)
                                    {
                                        b2 = 0; //Endurstillir b
                                    }
                                    if (d2 == 51) //Ef notandi vinnur
                                    {
                                        Console.WriteLine("Þú vannst leikin");
                                    }
                                    else if (c2 == 51) //Ef tölva vinnur
                                    {
                                        Console.WriteLine("Þú tapaðir leiknum");
                                    }

                                    else
                                    {
                                        if (lotr.Compete(Player1Deck2[b2], Player2Deck2[b2], CompCat2) == 1) //Ef Notandi vinnur umferð
                                        {
                                            Player1Deck2[b2] = Player2Deck2[c2];
                                            c2 = c2 - 1;
                                            d2 = d2 + 1;
                                            Console.WriteLine("Þú vannst og hefur nú " + (d2) + " kort af 52");
                                        }
                                        else if (lotr.Compete(Player1Deck2[b2], Player2Deck2[b2], CompCat2) == 2) //Ef tölva vinnur umferð
                                        {
                                            Player2Deck2[b2] = Player1Deck2[d2];
                                            c2 = c2 + 1;
                                            d2 = d2 - 1;
                                            Console.WriteLine("Þú tapaðir og hefur nú " + (d2) + " kort af 52");
                                        }
                                        else if (lotr.Compete(Player1Deck2[b2], Player2Deck2[b2], CompCat2) == 3) //Ef það er jafntefli
                                        {
                                            Console.WriteLine("Jafntefli næsti gerir");

                                        }
                                        else if (lotr.Compete(Player1Deck2[b2], Player2Deck2[b2], CompCat2) == 4) //Ef eitthvað fer úrskeiðis
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
