using System;
namespace Lab13
{
    public class Zadanie5
    {
        public void Wyw5()
        {
            Func<string, int> method = Do;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            // .. tutaj możemy równolegle wykonywać inne prace ...
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }
        static int Do(string s) { return s.Length; }
    }
}
