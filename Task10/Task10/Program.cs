
using System;
using System.Text.RegularExpressions;

namespace Task10
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

            string withoutNumbers = Regex.Replace(joined, "[0-9]", "");

            Console.WriteLine(withoutNumbers);



        }
    }
}
