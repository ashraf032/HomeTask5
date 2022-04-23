using System;

namespace Task8
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

            int lettersOfA = joined.IndexOf("a");
            Console.WriteLine(new string(joined[lettersOfA + 1], 10));






        }
    }
}
