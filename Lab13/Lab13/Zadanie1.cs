using System;

using System.Threading;
namespace Lab13
{
    public class Zadanie1
    {
        
            public void Wyw1()
            {
                try
                {
                    new Thread(Run).Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception!");
                }
            }
            static void Run() { throw null; }
        
    }
}
