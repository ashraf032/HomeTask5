using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            string input = Console.ReadLine().ToLower();
            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            //string joined = string.Join("", strlist);
            string free;
            char[] chararr1 = input.ToCharArray();
            for (int i = 0; i < chararr1.Length; i++)
            {
                if (i%2==0)
                {
                    chararr1[i] = char.ToUpper(chararr1[i]);
                }
            }
            free = new string(chararr1);
            Console.WriteLine(free);

        }
    }
}
