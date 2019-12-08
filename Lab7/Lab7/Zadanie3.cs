using System;
namespace Lab7
{
    delegate void Funkcje(int n,int m);
    public class Zadanie3
    {
        public  void Wyw3()
        {
            Funkcje f1 = new Funkcje(dodawanie);
            f1(3, 4);
            Funkcje f2 = new Funkcje(ode);
            f2(9, 4);
            Funkcje f3 = new Funkcje(mn);
            f3(3, 4);
            Funkcje f4 = new Funkcje(dz);
            f4(3, 4);
        }
        public void dodawanie(int a, int b)
        {
            Console.WriteLine("Wynik dodawania:{0}", a + b);
        }
        public void ode(int a, int b)
        {
            Console.WriteLine("Wynik odejnowania:{0}",a - b);
        }
        public void mn(int a, int b)
        {
            Console.WriteLine("Wynik mnożenia:{0}",a * b);
        }
        public void dz(int a, int b)
        {
            Console.WriteLine("Wynik dzielenia:{0}",a / b);
        }
    }
   
}
