using System;
namespace Lab5
{
    public class Zadanie2
    {
        public void Wyw2()
        {
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32)o);
        }
    }
}
