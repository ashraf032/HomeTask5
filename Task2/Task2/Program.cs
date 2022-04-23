using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            string input = Console.ReadLine();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);

            var inde = input.IndexOf('a');

            if (inde%2==0)
            {
                Console.WriteLine($"Tek yerde dayanan simvol {'a'} simvoludu mellim");
            }
            else
            {
                Console.WriteLine($"Tek yerde dayanan simvol {'a'} simvolu deyil ay mellim");
            }
        }
    }
}
