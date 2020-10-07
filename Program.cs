using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2
{
    class Program
    {
        static void Main(string[] args)
        {
         // Program written in C# language please confirm that before running.  
            string InputNumber;
            Console.Write("Please enter the number: ");
            InputNumber = Console.ReadLine();
            int n = Convert.ToInt32(InputNumber);

            //Upper half pattern
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write((char)(91 - k));
                }
                for (int l = 2; l <= i; l++)
                {                   
                    Console.Write((char)(91 - l));
                }
                Console.WriteLine();
            }
            //Lower half pattern
            for (int i = n-1; i >= 1; i--)
            {
                int n1 =n-1;
                for (int j = 0; j <= n1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write((char)(91 - k));
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write((char)(91 - l));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
