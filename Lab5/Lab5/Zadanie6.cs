using System;
using System.Collections.Generic;

namespace Lab5
{
    public class Zadanie6
    {
        public void Wyw6()
        {
            Stack s1 = new Stack();
            Stack s2 = new Stack();
            Stack s3 = new Stack();

            Random r = new Random();

            for (int i =0; i <100; i++)
            {
                int a = r.Next(1, 100);
                int b = r.Next(2, 50);
                s1.AddItem(a);
                s2.AddItem(b);
                if (a % 2 == 0)
                {
                    s3.AddItem(a);
                }
                if (b % 2 == 0 && b!=a)
                {
                    s3.AddItem(b);
                }
            }
            Console.WriteLine("S1:");
            s1.PrintAllItems();
            Console.WriteLine(" ");
            Console.WriteLine("S2:");
            s2.PrintAllItems();
            Console.WriteLine(" ");
            Console.WriteLine("S3:");
            s3.PrintAllItems();




        }
    }
    public class Stack
    {
        List<int> elements = new List<int>();

        public void AddItem(int item)
        {
            elements.Add(item);
        }
        public void DeleteItem()
        {
            elements.RemoveAt(0);
        }
        public void ShowNumberOfItem()
        {
            Console.WriteLine("Number of elements : {0}", elements.Count);
        }
        public void ShowMinItem()
        {
            List<int> findMin = elements;
            findMin.Sort();

            Console.WriteLine("Min element : {0}", findMin[0]);
        }
        public void ShowMaxItem()
        {
            List<int> findMax = elements;
            findMax.Sort();

            Console.WriteLine("Min element : {0}", findMax[findMax.Count]);

        }
        public void FindAnItem()
        { 
            if (elements.Count!=0){
                Console.WriteLine(elements.Count);
            }
            else
            {
                Console.WriteLine(-1);
            }
            
        }
        public void PrintAllItems()
        {
            foreach (int i in elements)
            {
                Console.Write(i);
                Console.Write(" ");
            }

        }
        public void ClearAll()
        {
            foreach(int i in elements)
            {
                elements.RemoveAt(i);
            }
        }
    }
}
