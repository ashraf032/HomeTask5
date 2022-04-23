using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] spearator = { ", ", ".", " ", "!", "?","/" };
            Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");
            string input = Console.ReadLine().ToLower();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);
            #region index metodlaridi buda ay mellim ehehehhe

            int indexFirstA = joined.IndexOf("a");

            char[] charArray = joined.ToCharArray();
            Array.Reverse(charArray);
            string reversedstr = new string(charArray);

            int indexLastA = reversedstr.IndexOf("a");

            Console.WriteLine("------------------------");
            Console.Write("Netice: ");
            if (indexFirstA == indexLastA)
            {
                Console.WriteLine("beraberdir");
            }
            else
            {
                Console.WriteLine("beraber deyil");
            }
            #endregion

            #region Forlu variantidi ay mellim :)
            //int LastCount = 0;
            //int FirstCount = 0;
            //char[] chrtotal1 = joined.ToCharArray();
            //int last = 0;
            //int first = 0;
            //////   For - u arrayin uzunlugu yeni length den basladiriq ve i--verib arxadan cixiriq

            //for (int i = 0; i < chrtotal1.Length; i++)
            //{
            //    FirstCount++;
            //    if (chrtotal1[i] == 'a')
            //    {
            //        first = FirstCount;
            //        Console.WriteLine($"Ilk cixacaq simvol: {chrtotal1[i]} ----> indeksi: {FirstCount}");
            //        break;
            //    }

            //}
            //for (int i = chrtotal1.Length - 1; i > 0; i--)
            //{
            //    LastCount++;
            //    if (chrtotal1[i] == 'a')
            //    {
            //        last = LastCount;
            //        Console.WriteLine($"Son cixacaq simvol: {chrtotal1[i]} ----> indeksi: {LastCount}");
            //        break;
            //    }
            //}
            //if (last == first)
            //{
            //    Console.WriteLine("Beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("Beraber deyil");
            //}
            #endregion



        }
    }
}
