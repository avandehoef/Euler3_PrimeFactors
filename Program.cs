using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double testNummer;
            double nummer = 2;
           
            for (testNummer = 600851475143; nummer < testNummer; testNummer = testNummer / nummer)
            {
                if (testNummer % nummer == 0)
                {
                    continue;                    
                }
                else
                {
                   for (testNummer = testNummer; nummer <= testNummer; nummer = nummer + 1)
                    {
                        if (testNummer % nummer != 0 || nummer == 1)
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(nummer);
                            break;                            
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
