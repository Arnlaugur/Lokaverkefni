using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTrump_Klasasafn;

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
                Console.WriteLine("Veldu Hvað þú vilt gera");
                Console.WriteLine("1. Sýna Reglur");
                Console.WriteLine("2. Taka leik");
                UserInput = Convert.ToInt32(Console.ReadLine());
                switch(UserInput)
                {
                    case 1:
                        Console.WriteLine(KlassLibrary.Reglur());
                        Console.ReadKey();
                        break;
                    case 2:
                        int b = 0;
                        int c = 26;
                        int d = 26;
                        int[] cards = KlassLibrary.Skyptakortum();
                        int[] Player1Deck = new int[52];
                        int[] Player2Deck = new int[52];
                        for (int i = 0; i < 26; i++)
                        {
                            int a = 0;
                            Player1Deck[a] = cards[i];
                            i++;
                            Player2Deck[a] = cards[i];
                            a++;
                        }
                        
                        if (KlassLibrary.TakaLeik() == 1)
                        {
                            Player1Deck[b] = Player2Deck[c];
                            c--;
                            b++;
                            d++;
                        }
                        else if (KlassLibrary.TakaLeik() == 2)
                        {
                            Player2Deck[b] = Player1Deck[d];
                            c++;
                            b++;
                            d--;
                        }
                        else if (KlassLibrary.TakaLeik() == 3)
                        {
                            Console.WriteLine("Jafntefli næsti gerir");
                            b++;
                        }
                        else if (KlassLibrary.TakaLeik() == 4)
                        {

                        }

                        break;
                }
            }

            
        }
    }
}
