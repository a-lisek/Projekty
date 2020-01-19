using System;

namespace Lab13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Zadanie 1
            //Console.WriteLine("Zadanie1");
            Zadanie1 Z1 = new Zadanie1();
            //Z1.Wyw1(); //Wywolanie zwraca System.NullReferenceException
            //Console.WriteLine(" ");

            //Zadanie 2
           // Console.WriteLine("Zadanie2");
            Zadanie2 Z2 = new Zadanie2();
            //Z2.Wyw2();
            Console.WriteLine(" ");

            //Zadanie 3
            //Console.WriteLine("Zadanie3");
            Zadanie3 Z3 = new Zadanie3();
            //Z3.Wyw3();
            Console.WriteLine(" ");

            //Zadanie 4
            //Console.WriteLine("Zadanie4");
            Zadanie4 Z4 = new Zadanie4();
            //Z4.Wyw4();
            Console.WriteLine(" ");

            //Zadanie 5
            Console.WriteLine("Zadanie5");
            Zadanie5 Z5 = new Zadanie5();
            Z5.Wyw5();
            Console.WriteLine(" ");
        }
    }
}
