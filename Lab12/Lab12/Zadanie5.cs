using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie5
    {
        public void Wyw5()
        {
            ThreadExample5 E5 = new ThreadExample5();
            E5.Wyw();
        }
    }
    class ThreadExample5
    {
        static readonly object locker = new object();
        static bool done; // Pole statyczne
        public void Wyw()
        {
            new Thread(Run).Start();
            Run();
        }
        //static void Run()
        //{
        //   if (!done) { done = true; Console.WriteLine("Done"); }
        //}
        static void Run()
        {
            lock (locker)
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}