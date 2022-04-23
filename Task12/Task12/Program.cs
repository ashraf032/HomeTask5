using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] spearator = { ", ", ".", " ", "!", "?", "/","a" };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            string input = Console.ReadLine();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);

            Console.WriteLine(joined);
        }
    }
}
