using System;
using System.Threading;

namespace Lab13
{
    public class Zadanie2
    {
        public void Wyw2()
        {
            new Thread(Run).Start();
        }
        static void Run()
        {
            try
            {
                // ...
                throw null;
                // ...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}
