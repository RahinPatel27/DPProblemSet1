using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet1
{
    internal class Q4
    {
        public void OddEven()
        {

            int i;
            Console.WriteLine("Input the number of elements to be stored in the array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[num];
            for (i = 0; i < num; i++)
            {
                Console.Write($"\nElement - {i}:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            for (i = 0; i < num; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    Console.Write($"{arr[i]} Number is an Even Number \n");
                }
                else
                {
                    Console.Write($"{arr[i]} Number is an Odd Number \n");
                }
            }
        }
    }
}
