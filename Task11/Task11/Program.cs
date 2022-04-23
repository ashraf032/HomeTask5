using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            string input = Console.ReadLine().ToLower();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);

            int letterOfA = joined.IndexOf("a");
            int letterOfB = joined.IndexOf("b");

            string newstr1 = joined.Insert(letterOfA,"b");
            string newstr2 = newstr1.Insert(letterOfB, "a");

            Console.WriteLine(newstr2);


        }
    }
}
