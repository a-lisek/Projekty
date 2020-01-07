using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, cntr = 4, tree_base, n = 15;
            for (i = 1; i <= 3; i++)
            {
                for (k = (n - 1); k >= i; k--)
                {
                    Console.Write("   ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*-o");
                    }
                }
                Console.WriteLine();
            }
            for (i = 1; i <= cntr; i++)
            {
                for (k = (n - 2); k >= i; k--)
                {
                    Console.Write("   ");
                }
                for (j = 0; j <= 2 * i; j++)
                {
                    Console.Write("*-o");
                }
                Console.WriteLine();
            }
            cntr++;
            for (i = 1; i <= cntr; i++)
            {
                for (k = (n - 4); k >= i; k--)
                {
                    Console.Write("   ");
                }
                for (j = 0; j <= 2 * i + 4; j++)
                {
                    Console.Write("*-o");
                }
                Console.WriteLine();
            }
            tree_base = 2 * i + 4;
            for (l = 0; l < 3; l++)
            {
                for (j = n - 3; j > 0; j--)
                {
                    Console.Write("   ");
                }
                for (j = 0; j <= 4; j++)
                {
                    Console.Write("***");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = 0; i < n - 9; i++)
            {
                Console.Write("   ");
            }
        }
    }
}
