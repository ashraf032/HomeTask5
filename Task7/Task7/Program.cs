using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A herfinin B herfinden sonra gelmesi ve C herfininde her ikisinden sonra gelmesi CONSOL-u ");
            string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            string input = Console.ReadLine().ToLower();


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);
            //string[] finders = { "abc" };
            int lettersOfA = joined.IndexOf("a");
            int lettersOfB = joined.IndexOf("b");
            int lettersOfC = joined.IndexOf("c");

            int firstMath = lettersOfB - lettersOfA;
            int secondMath = lettersOfC - lettersOfB;

            //char[] charedStr = joined.ToCharArray();

            //for (int i = 0; i < charedStr.Length; i++)
            //{
            //    if (charedStr[i]=='a')
            //    {
            //        //Console.WriteLine($"A herfinin indeksi : {i}");
                    
            //    }
            //    if (charedStr[i] == 'b')
            //    {
            //        //Console.WriteLine($"B herfinin  indeksi : {i}");
            //    }
            //    if (charedStr[i] == 'c')
            //    {
            //        //Console.WriteLine($"C herfinin indeksi : {i}");
            //    }

            //}


            if (firstMath>0&&secondMath>0)
            {
                Console.WriteLine("A herfi B herfinden C herfide her ikisinden sonra gelir");

            }
            else
            {
                Console.WriteLine("Sherte uygun netuce tapilmadi!!");
            }


            


        }
    }
}
