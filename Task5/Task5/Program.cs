using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] spearator = { ", ", ".", " ", "!", "?" };

            string input = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vitae aliquam sunt laboriosam nobis. In facere ipsam incidunt eligendi laborum necessitatibus deleniti, culpa veritatis similique itaque possimus numquam repellendus est inventore temporibus, rerum, consequuntur adipisci! Veniam blanditiis rem cumque commodi laborum quas molestiae, odio iusto deleniti ut eligendi magni quis ex nisi perferendis obcaecati. Quam, est! Est commodi aut fugit alias deleniti molestias necessitatibus tempora iure expedita exercitationem. Vitae soluta in delectus accusamus molestias, iusto consectetur illum? Nemo culpa sapiente quisquam perspiciatis accusantium exercitationem labore, voluptatem sint ullam ab cumque quas blanditiis, dolore assumenda, officiis sunt voluptatum maxime illo! Ratione, quis.";


            string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            string joined = string.Join("", strlist);

            int count = 0;
            char[] chrtotal1 = joined.ToCharArray();
            //For-u arrayin uzunlugu yeni length den basladiriq ve i-- verib arxadan cixiriq 

            for (int i = chrtotal1.Length-1; i > 0; i--)
            {
                count++;
                if (chrtotal1[i] == 'b' || chrtotal1[i] == 'a' || chrtotal1[i] == 'c' )
                {
                    Console.WriteLine($"Cixacaq simvol: {chrtotal1[i]} ----> indeksi: {count}");
                    return;
                }
                
            }
            
        }
    }
}
