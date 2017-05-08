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
                }
            }

            
        }
    }
}
