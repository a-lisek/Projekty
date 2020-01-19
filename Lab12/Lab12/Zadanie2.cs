using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie2
    {
        public void Wyw2()
        {
            new Thread(Run).Start(); // Uruchom Run w innym wątku
            Run(); // Uruchom Run w głownym wątku
        }
        static void Run()
        {
            // Deklaracja i użycie zmiennej lokalnej - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('x');
        }
    }
}
