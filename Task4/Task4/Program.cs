using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");

            string input = Console.ReadLine();
            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);

            int count = 0;
            char[] chrtotal1 = joined.ToCharArray();
            for (int i = 0; i < chrtotal1.Length; i++)
            {
                count++;
                if (chrtotal1[i] == 'a' && count % 2 == 0)
                {
                    Console.WriteLine($"Cixacaq simvol: {chrtotal1[i]} ----> indeksi: {count}");
                    Console.WriteLine("Cutdur");
                }
                else
                {
                    Console.WriteLine("Cut deyil");
                }
            }
        }
    }
}
