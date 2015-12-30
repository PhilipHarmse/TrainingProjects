using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPart1
{
    static class Program
    {
        public delegate bool FunctionForStrings(string s,string letter);

        public static bool StartWithLetter(string s,string letter)
        {
            return s.StartsWith(letter);
        }

        public static bool EndWithLetter(string s, string letter)
        {
            return s.EndsWith(letter);
        }

        public static string[] PerformOperationOnStringArray(string[] myStrings,string letter, FunctionForStrings myFunction)
        {
            System.Collections.ArrayList myList = new System.Collections.ArrayList();

            foreach (var s in myStrings)
            {
                if (myFunction(s,letter))
                {
                    myList.Add(s);
                }
            }

            return (string[])myList.ToArray(typeof(string));
        }

        static void Main(string[] args)
        {
            string[] myStrings = { "Adam", "Alan", "Bob", "Steve", "jim", "Aiden", "Rob", "Bill", "Jacob", "James" };

            //Get all strings that start with the letter A
            //List<string> stringsA = new List<string>();
            //foreach (var a in myStrings)
            //{
            //    if (a.StartsWith("A"))
            //    {
            //        stringsA.Add(a);
            //    }

            //}

            //foreach (var name in stringsA)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine("Choose - 1 (Begine) or 2 (End):");
            string choice = Console.ReadLine();

            Console.WriteLine("Enter letter:");
            string letter = Console.ReadLine();

            List<string> names = new List<string>();
            if (choice == "1")
            {
                names = PerformOperationOnStringArray(myStrings,letter, StartWithLetter).ToList();
            }
            else
            {
                names = PerformOperationOnStringArray(myStrings,letter, EndWithLetter).ToList();
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }

        static List<string> GetStringsBeginningWith(string[] myStrings, string beginningLetter)
        {
            List<string> StartWithStrings = new List<string>();

            foreach (var name in myStrings)
            {
                if (name.StartsWith(beginningLetter))
                {
                    StartWithStrings.Add(name);
                }
            }

            return StartWithStrings;
        }

        static List<string> GetStringsEndingWith(string[] myStrings, string endingWith)
        {
            List<string> EndWithStrings = new List<string>();

            foreach (var name in myStrings)
            {
                if (name.EndsWith(endingWith))
                {
                    EndWithStrings.Add(name);
                }
            }

            return EndWithStrings;
        }
    }
}
