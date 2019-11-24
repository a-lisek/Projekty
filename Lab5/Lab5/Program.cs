using System;

namespace Lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Zadanie 9
            Console.WriteLine("Zadanie9");
            Zadanie9 Z9 = new Zadanie9();
            Z9.Wyw9();
            Console.WriteLine(" ");

            // Zadanie 8
            Console.WriteLine("Zadanie8");
            Zadanie8 Z8 = new Zadanie8();
            Z8.Wyw8();
            Console.WriteLine(" ");

            // Zadanie 7
            Console.WriteLine("Zadanie7");
            Zadanie7 Z7 = new Zadanie7();
            Z7.Wyw7();
            Console.WriteLine(" ");

            // Zadanie 6
            Console.WriteLine("Zadanie6");
            Zadanie6 Z6 = new Zadanie6();
            Z6.Wyw6();
            Console.WriteLine(" ");

            //Zadanie 5
            Console.WriteLine("Zadanie5");
            Zadanie5 Z5 = new Zadanie5();
            Z5.Wyw5();
            Console.WriteLine(" ");

            //Zadanie 4
            Console.WriteLine("Zadanie4");
            Zadanie4 Z4 = new Zadanie4();
            Z4.Wyw4();
            Console.WriteLine(" ");

            //Zadanie 3
            Console.WriteLine("Zadanie3");
            Zadanie3 Z3 = new Zadanie3();
            Z3.Wyw3();
            Console.WriteLine(" ");

            //Zadanie 2

            Console.WriteLine("Zadanie2");
            Zadanie2 Z2 = new Zadanie2();
            Z2.Wyw2();
            Console.WriteLine(" ");

            //Zadanie 1
            int n;
            Console.WriteLine("Podaj liczbe");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Oto tablica 1 :");
            for (int i = 1; i<=n; i++)
            {
                for ( int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Oto tablica 2 :");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
            int k = 1;
            Console.WriteLine("Oto tablica 3 :");
            while (k <= n){
                int l = 1;
                while (l <= k)
                {
                    Console.Write(k);
                    l++;

                }
                Console.WriteLine("");
                k++;
            }
            Console.WriteLine("Oto tablica 4 :");
            int m = 1;
            do
            {
                int o = 1;
                do
                {
                    
                    Console.Write(o);
                    o++;
                } while (o <= m);
                Console.WriteLine("");
                m++;
            } while (m <= n);
        }
    }
}
