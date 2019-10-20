using System;

namespace Aplikacja1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Zadanie 1" );
            var x = 18;
            var y = 6;
            Console.WriteLine("Liczby to: {0} i {1} ", x, y);

            Zadanie1 dodawanie = new Zadanie1();
            var wynik = dodawanie.suma(x,y);
            Console.WriteLine("Wynik dodawania to : {0} ", wynik);

            Zadanie1 dzielenie = new Zadanie1();
            var wynik2 = dodawanie.dzielenie(x, y);
            Console.WriteLine("Wynik dzielenia to : {0} ", wynik2);

            Console.WriteLine("Wynik dzialan to  : {0}, {1}, {2}, {3} ", -1+4*6, (35+5)%7, 14+ -4 * 6/11, 2+ 15/6 *1 - 7%2);

            Console.WriteLine("\nZadanie 2");
            Console.WriteLine("Podaj pierwsza liczbe:");
            string a = Console.ReadLine();
            int a_parsed;

            a_parsed = int.Parse(a);

            Console.WriteLine("Podaj druga liczbe:");
            string b = Console.ReadLine();
            int b_parsed;
            b_parsed = int.Parse(b);

            Console.WriteLine("Drugi numer : {0}, Pierwszy numer: {1} ",b_parsed, a_parsed);


            Console.WriteLine("\nZadanie 4");
            Console.WriteLine("Podaj liczbe:");
            string liczba1 = Console.ReadLine();
            int l1 = Convert.ToInt32(liczba1);
            Console.WriteLine("Podaj liczbe:");
            string liczba2 = Console.ReadLine();
            int l2 = Convert.ToInt32(liczba2);
            Console.WriteLine("Podaj liczbe:");
            string liczba3 = Console.ReadLine();
            int l3 = Convert.ToInt32(liczba3);
            Console.WriteLine("Iloczyn: {0} x {1} x {2} = {3}", l3, l2, l1, l3*l2*l1);

            Console.WriteLine("\nZadanie 5");
            Console.WriteLine("Podaj liczbe:");
            string liczbap = Console.ReadLine();
            int lp = Convert.ToInt32(liczbap);
            Console.WriteLine(" {0}{0}{0} \n{0}    {0}\n{0}    {0}\n{0}    {0}\n {0}{0}{0} \n",lp);

            Console.WriteLine("\nZadanie 6");
            Console.WriteLine("Formatowanie int i double");
            int ii = 75400;
            double id = 7.53;
            string s = string.Format("Wartosc int to: {0}, a wartosc double to {1}", ii, id);
            Console.WriteLine(s);
            string s2 = "Wartosc int to " + ii + "a wartosc double to " + id;
            Console.WriteLine(s2);
            Console.WriteLine("Wartosc int to {0,-40} a wartosc double to {1, -40}",ii,id);
            Console.WriteLine("Wartosc int to {0,40} a wartosc double to {1, 40}", ii, id);
            int ii2 = 57300;
            double id2 = 5.73;
            //Console.WriteLine("{0,c},{0,d},{0,e},{0,f}{0,r},{0,o},{0,x}",ii2);
            //Console.WriteLine("{0,c},{0,d},{0,e},{0,f}{0,r},{0,o},{0,x}", id2);

            float flo = 220.022f;
            //Console.WriteLine("{0:0.00000}, {0:0.0}, {0:0,0}, {0:,.},{0:0%}, {0:0e+0}", flo);

            Console.WriteLine("\nFormatowanie doubli");
            double n1 = 123.4;
            double n2 = -1234;
            double n3 = 0;
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", n1);
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", n2);
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", n3);

            DateTime d = System.DateTime.Now;
            Console.WriteLine("\nFormatowanie daty");
            Console.WriteLine("{0:d}", d);
            Console.WriteLine("{0:D}", d);
            Console.WriteLine("{0:t}", d);
            Console.WriteLine("{0:T}", d);
            Console.WriteLine("{0:f}", d);
            Console.WriteLine("{0:F}", d);
            Console.WriteLine("{0:g}", d);
            Console.WriteLine("{0:G}", d);
            Console.WriteLine("{0:M}", d);
            Console.WriteLine("{0:r}", d);
            Console.WriteLine("{0:s}", d);
            Console.WriteLine("{0:u}", d);
            Console.WriteLine("{0:U}", d);
            Console.WriteLine("{0:Y}", d);

            Console.WriteLine("\nZadanie 7");
            Console.WriteLine("Podaj liczbe w stopniach Celciusza");
            string C1= Console.ReadLine();
            int C = Convert.ToInt32(C1);
            int F = C * 18 / 10 + 32;
            int K = C + 273;
            Console.WriteLine("Ta temperatura w Kelvinach to {0}, a w Farenheitach to {1}", K, F);


            Console.WriteLine("\nZadanie 8");
            Console.WriteLine("Podaj liczbe");
            string M1 = Console.ReadLine();
            int M = Convert.ToInt32(M1);
            Console.WriteLine("Podaj liczbe");
            string N1 = Console.ReadLine();
            int N = Convert.ToInt32(N1);
            if ((N>0 && M > 0)||(N<0 && M<0)){
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            Console.WriteLine("\nZadanie 9 \nnop-No Operation \nldstr-Push a string object for the literal string \ncall-Call method described by method  \npop-Pop value from the stack  \nret-Return from method, possibly with a value");


        }
    }
}
