using System;
namespace Lab4_Z1_2
{
    class TestPointer
    {
        public unsafe void Cosik()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Adres [{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość[{0}]={1}", i, *(ptr + i));
                }
            Console.ReadKey();
        }
    }
    public class Zadanie2
    {
        public unsafe void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
            public Zadanie2()
        {
            TestPointer t = new TestPointer();
            t.Cosik();
        }
    }
}
