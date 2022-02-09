using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.Algorithm;

namespace ProblemSet1
{
    internal class Q2
    {
        public void QQC()
        {
            string[] array = new string[] { "Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn" };
            string finalWord = array.OrderByDescending(n => n.Length).First();
            Console.WriteLine("Longest word is: " + finalWord);
        }
        public void QQB()
        {
            string s = "Supercalifragilisticexpialidocious";
            if (s.Contains("ice") == true)
            {
                Console.WriteLine($"Found ice in {s}");
            }
        }
        public void QQA()
        {
            Console.Write("Input the string : ");

            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string input = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            int count = 0;
            if (input != null)
            {

                foreach (char c in input)
                {
                    count++;
                }
                Console.Write("Number of Letter in the string is : {0}\n", count);
            }

        }
        public void QQD()
        {
            var names = new List<string> {"Berlioz", "Borodin",
            "Brian", "Bartok", "Bellini",
            "Buxtehude", "Bernstein"};

            var res = from name in names
                      orderby name.Split(" ")[0]
                      ascending
                      select name;

            Console.WriteLine(res);

            foreach (var name in res)
            {
                Console.WriteLine(name);
            }
        }
    }
}
