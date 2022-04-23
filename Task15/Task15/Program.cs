using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            string[] removeC = { "c" };
            Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");
            string input = Console.ReadLine().ToLower();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);
            #region index metodu

            char[] charArray = joined.ToCharArray();
            string firstletter = charArray[0].ToString() ;
            string lastletter = charArray[charArray.Length-1].ToString();

            Console.WriteLine("------------------------");
            if (firstletter==lastletter && joined.Contains("aa") && !joined.Contains("b"))
            {
                string[] strlist2 = joined.Split(removeC, StringSplitOptions.RemoveEmptyEntries);

                string joined2 = string.Join("", strlist2);
                Console.WriteLine($"Neticede alinan Metin: {joined2}");
            }
            else
            {
                Console.WriteLine("Shertlere uygun bir netice tapilmadi");
            }
            //Ele bilinki zerkalnidi :D
            #endregion

        }
    }
}
