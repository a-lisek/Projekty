using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie6
    {
        public void Wyw6()
        {
            ThreadExample6 E6 = new ThreadExample6();
            E6.Wyw();
        }
    }
    class ThreadExample6
    {
        public void Wyw()
        {
            Thread t = new Thread(Run);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
        }
        static void Run()
        {
            for (int i = 0; i < 777; i++) Console.Write("");
        }
    }
}
