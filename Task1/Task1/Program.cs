using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letterA = { "a","A" };
            string[] letterB = { "b","B" };

            //Tester test
            string input = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vitae aliquam sunt laboriosam nobis. In facere ipsam incidunt eligendi laborum necessitatibus deleniti, culpa veritatis similique itaque possimus numquam repellendus est inventore temporibus, rerum, consequuntur adipisci! Veniam blanditiis rem cumque commodi laborum quas molestiae, odio iusto deleniti ut eligendi magni quis ex nisi perferendis obcaecati. Quam, est! Est commodi aut fugit alias deleniti molestias necessitatibus tempora iure expedita exercitationem. Vitae soluta in delectus accusamus molestias, iusto consectetur illum? Nemo culpa sapiente quisquam perspiciatis accusantium exercitationem labore, voluptatem sint ullam ab cumque quas blanditiis, dolore assumenda, officiis sunt voluptatum maxime illo! Ratione, quis.";

            //Regexden isstifade ederek Coutun hesablanmasi
            int ACount = letterA.Sum(letter => Regex.Matches(input, letter).Count);
            int BCount = letterB.Sum(letter => Regex.Matches(input, letter).Count);

            //A bolunsun B
            Console.WriteLine($"A ededi B ededinden ne qeder coxdur: {ACount / BCount}");
        }
    }
}
