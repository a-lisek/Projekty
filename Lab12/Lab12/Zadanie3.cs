using System;
using System.Threading;

namespace Lab12
{
    public class Zadanie3
    {
        public void Wyw3()
        {
            ThreadTest E1 = new ThreadTest();
            E1.Wyw();
        }
    }
    public class ThreadTest
    {
        bool done;
        public void Wyw()
        {
            ThreadTest tt = new ThreadTest();
            new Thread(tt.Run).Start();
            tt.Run();
        }
        // Zauważ, że Run jest teraz metodą instancji
        void Run()
        {
            if (!done) { done = true; Console.WriteLine("Done"); }
        }
    }

}
