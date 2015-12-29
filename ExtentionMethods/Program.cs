using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    static class Program
    {
        static void Main(string[] args)
        {
            int i = 7;



            // Print(Bonus(Decrement(Increment(i))));

            i.Increment().Decrement().Bonus().Print();


            Console.ReadLine();

            

        }

        static void Print(this object o)
        {
            Console.WriteLine("Called Print {0}",o.ToString());
        }

        static int Increment(this int i)
        {
            return i++;
        }

        static int Decrement(this int i)
        {
            return i--;
        }

        static int Bonus(this int i)
        {
            return i + 5;
        }
    }
}
