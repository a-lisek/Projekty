using System;
using System.Text.RegularExpressions;

namespace Lab3
{
    enum Day {Poniedzialek=1, Wtorek, Sroda, Czwartek, Piatek, Sobota, Niedziela};
    enum data_val { mala = 10, srednia =100, duza=1000 };

    class MainClass
    {
        public static void Main(string[] args)
        {

            // Zadanie 3
            string znak = "0";
            int licznik_int = 0;
            int licznik_float = 0;
            int licznik_string = 0;

            while (znak != "-1"){
                Console.WriteLine("Podaj znak z klawiatury");
                znak = Console.ReadLine();
                int znak_i;
                if (int.TryParse(znak, out znak_i)){
                    licznik_int = licznik_int + 1;
                    continue;
                }
                float znak_f;
                if (float.TryParse(znak, out znak_f))
                {
                    licznik_float = licznik_float + 1;
                    continue;
                }
                licznik_string = licznik_string + 1;
            }
            Console.WriteLine("Liczba intow {0}, liczba floatow {1}, liczba stringow {2}", licznik_int, licznik_float, licznik_string);


            // Zadanie 4

            Console.WriteLine("Podaj numer dnia");
            String dayno = Console.ReadLine();
            int nr = int.Parse(dayno);
            Console.WriteLine("Dzien tygodnia numer {0} to {1}", nr, Enum.GetName(typeof(Day), nr));

            Console.WriteLine("Podaj liczbe");
            String l1 = Console.ReadLine();
            int lc = int.Parse(l1);
            foreach (data_val liczba in Enum.GetValues(typeof(data_val)))
            {
                if (lc <= (int)liczba)
                {
                    Console.WriteLine(Enum.GetName(typeof(data_val), liczba));
                    break;
                }
            }

            // Zadanie 5
            Console.WriteLine("Podaj znak");
            String sign = Console.ReadLine();
            if (sign == "0"|| sign == "1"|| sign == "2"|| sign == "3"|| sign == "4"|| sign == "5" || sign == "6"|| sign == "7"|| sign == "8" ||sign == "9")
            {
                Console.WriteLine("Numer");
            }
            else if (sign == "a" || sign == "ą" || sign == "e" || sign == "ę" || sign == "o"|| sign == "i" || sign == "u" || sign == "y")
            {
                Console.WriteLine("Samogloska");
            }
            else
            {
                Console.WriteLine(" I am not a number");
            }

            // Zadanie 6
            Console.WriteLine("Podaj slowo");
            String slowo = Console.ReadLine();
            char[] caracters = slowo.ToCharArray();
            string s = string.Join(" ", caracters);
            Console.WriteLine(s);

            //Zadanie 7


            // Kompilacja
            //Console.WriteLine( checked(8283838383 + 10) );

            // Konsola
            int x1 = 922;
            try
            {
                checked
                {
                    int x3 = 293838484 + x1;
                    Console.WriteLine(x3);
                }
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Wykryto blad:\n{0}", e.ToString());
            }

            // Zadanie 10
            // Implicit conversion. A long can
            // hold any value an int can hold, and more!
            int num = 2147483647;
            long bigNum = num;

            //Zadanie 9 - Prosty kalkulator
            Console.WriteLine("Podaj rownanie");
            String input = Console.ReadLine();
            int i = 0;
            string[] numbers = new string[20];
            int result;
            foreach (var match in Regex.Matches(input, @"([*+/\-)(])|([0-9]+)"))
            {
                numbers[i++] = match.ToString();
            }
            result = int.Parse(numbers[0]);
            for (int j = 0; j < numbers.Length; j++)
            {
                
                if (numbers[j] == "-")
                {
                    result = result - int.Parse(numbers[j + 1]);
                    
                }
                else if (numbers[j] == "+")
                {
                    result = result + int.Parse(numbers[j + 1]);
                 
                }


            }
            Console.WriteLine("Wynik to {0}", result);


            //Zadanie 8
            //Typy wartosci i typy odwolan
            void Fun1(Punkt p)
            {
                p.x = 100;
                p.y = 100;
            }
            void Fun2(Coords c)
            {
                c.x = 100;
                c.y = 100;
            }
            Punkt puk = new Punkt(3,2);
            Console.WriteLine("Punkt przed modyfikacja: {0},{1}", puk.x, puk.y);
            Fun1(puk);
            Console.WriteLine("Punkt po  modyfikacji: {0},{1}", puk.x, puk.y);

            Coords cor = new Coords(3, 2);
            Console.WriteLine("Punkt przed modyfikacja: {0},{1}", cor.x, cor.y);
            Fun2(cor);
            Console.WriteLine("Punkt po  modyfikacji: {0},{1}", cor.x, cor.y);


        }
    }
    public struct Coords
    {
        public int x, y;
        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;

        }
    }
    public class Punkt
    {
        public int x, y;
        public Punkt(int p1, int p2)
        {
            x = p1;
            y = p2;

        }
    }

}
