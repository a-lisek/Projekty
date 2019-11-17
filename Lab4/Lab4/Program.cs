using System;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Zadanie 8
            int[][] tab8_2 = {

            new int[] { 1, 2, 3 },

            new int[] { 4, 5, 6, 7, 8, 9 },

            new int[] { 10, 11, 12, 13 },

            new int[] { 14, 15, 16, 17, 18 },

            new int[] { 19, 20, 21 }

             };

            int[][] tab8_1 = new int[5][];

            tab8_1[0] = new int[] { 1, 2, 3 };

            tab8_1[1] = new int[] { 4, 5, 6, 7, 8, 9 };

            tab8_1[2] = new int[] { 10, 11, 12, 13 };

            tab8_1[3] = new int[] { 14, 15, 16, 17, 18 };

            tab8_1[4] = new int[] { 19, 20, 21 };

            foreach (int[] el in tab8_1)
            {
                foreach (int elm in el)
                {

                    Console.Write(elm + " ");
                }
                Console.WriteLine("");
            }

            foreach (int[] el in tab8_2)
            {
                foreach (int elm in el)
                {

                    Console.Write(elm + " ");
                }
                Console.WriteLine("");
            }

            //Zadanie 7

            int [,] tab7 = new int[3,3] { {1, 0, -1 },{ 0,0,1},{ -1, -1,0} };
            int wyznacznik = 0; 
           
            wyznacznik = tab7[0, 0] * tab7[1, 1] * tab7[2, 2] + tab7[1, 0] * tab7[2, 1] * tab7[0, 2] + tab7[2, 0] * tab7[0, 1] * tab7[1, 2] - (tab7[2, 0] * tab7[1, 1] * tab7[0, 2] + tab7[0, 0] * tab7[2, 1] * tab7[1, 2] + tab7[1, 0] * tab7[0, 1] * tab7[2, 2]);

            Console.WriteLine("Wyznacznik to {0}", wyznacznik);

            //Zadanie 6
            int[,] numbers = new int[5, 5] { { 1, 2, 3, 4, 5 },
            { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }};

            int[,] numbers2 = new int[5, 5] { { 2, 2, 3, 4, 5 },
            { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5 }};

            int[,] tab6_1 = new int[5,5];
            int[,] tab6_2 = new int[5,5];

            int[,] result = new int[5, 5];
            Console.WriteLine("Tablica wynikowa to");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for(int j = 0; j< result.GetLength(1); j++)
                {
                    result[i, j] = numbers[i,j] + numbers2[i,j];
                    Console.Write("{0} ", result[i, j] + " ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            //Zadanie 5
            int[] tab5 = new int[5];
            for (int i = 0; i < tab5.Length; i++)
            {
                Console.WriteLine("Podaj liczbe do tablicy");
                int number = int.Parse(Console.ReadLine());
                tab5[i] = number;
            }
            foreach (int item in tab5)
            {
                Console.Write("Liczba {0}", item.ToString() + " ");
                int frequency = 0;
                for (int i = 0; i < tab5.Length; ++i)
                {
                    if (tab5[i] == item) ++frequency;
                }
                Console.WriteLine("Powtarza sie {0} razy",frequency.ToString());
            }

            //Zadanie 4
            int[] tab4 = new int[5];
            for (int i = 0; i < tab4.Length; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int number = int.Parse(Console.ReadLine());
                tab4[i] = number;
            }
            Array.Reverse(tab4);
            Console.WriteLine("Odwrócona tablica: ");
            foreach (int el in tab4)
            {
                Console.WriteLine(el);
            }

            //Zadanie 3
            int[] tab3 = new int[10];
            Console.WriteLine("Podaj znak aby dodać go do tablicy");
            int sign = int.Parse(Console.ReadLine());
            Array.Resize(ref tab3, tab3.Length + 1);
            tab3[tab3.GetLowerBound(0)] = sign;
            foreach(int val in tab3)
            {
                Console.WriteLine(val);
            }

            

        }
    }
}
