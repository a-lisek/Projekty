using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie4
    {
        public void Wyw4()
        {
            ThreadExample3 E3 = new ThreadExample3();
            E3.Wyw();
        }
    }
    class ThreadExample3
    {
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
            if (!done) { Console.WriteLine("Done"); done = true; }
        }
    }
}
