using System;
using System.Threading;

namespace Lab13
{
    public class Zadanie4
    {
        public void Wyw4()
        {
            ThreadPool.QueueUserWorkItem(Run);
            ThreadPool.QueueUserWorkItem(Run, 123);
            Console.ReadLine();
        }
        static void Run(object data)
        {
            Console.WriteLine("Hello !! The thread pool! " + data);
        }
    }
}
