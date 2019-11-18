using System;
using System.Collections.Generic;

namespace Lab5
{
    public class Zadanie6
    {
        public void Wyw6()
        {

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

        }
        public void PrintAllItems()
        {

        }
        public void ClearAll()
        {

        }
    }
}
