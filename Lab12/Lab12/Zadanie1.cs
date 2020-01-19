using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie1
    {
        public void Wyw1()
        {
            ThreadExample E1 = new ThreadExample();
            E1.Wyw();
        }
        
    }
    public class ThreadExample
    {
        public void Wyw()
        {
            Thread t = new Thread(Write1); //Uruchom inny wątek
            t.Start();
            // Główny wątek.
            for (int i = 0; i < 1000; i++) Console.Write("0");
        }
        //Inny wątek
        static void Write1()
        {
            for (int i = 0; i < 1000; i++) Console.Write("1");
        }
    }

}
