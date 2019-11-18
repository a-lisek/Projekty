using System;
namespace Lab5
{
    public class Zadanie3
    {
        public int? N;
        public void Wyw3()
        {
            Console.WriteLine("Zadeklarowana zmienna {0}", N);

            Console.WriteLine(N.GetValueOrDefault(-1));

            if (N.HasValue)
            {
                Console.WriteLine(N);
            }
            else
            {
                Console.WriteLine("Nie ma wartosci");
            }


            N = 5;
            Console.WriteLine(N);
        }
    }
}
