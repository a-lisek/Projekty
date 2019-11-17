using System;

namespace Lab4_Z1_2
{
    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    class MainClass
    {

        static void Fun1(in int i)
        {
            //i = i + 3;
        }
        static void Fun2(out int i)
        {
            i = 2;
            i = i + 3;
        }
        static void Fun3(ref int i)
        {
            i = i + 3;
        }
        static void Fun4(int i)
        {
            i = i + 3;
        }
        static void Fun5(Point p)
        {
            Point p1 = new Point(4, 3);
            p = p1;
        }
        static void Fun6(ref Point p)
        {
            Point p1 = new Point(4, 3);
            p = p1;
        }
        public static void Main(string[] args)
        {
            int x = 4;

            Fun1(x);
            Console.WriteLine(x);
            Fun2(out x);
            Console.WriteLine(x);
            Fun3(ref x);
            Console.WriteLine(x);
            Fun4(x);
            Console.WriteLine(x);

            short y = 3;
            Fun1(y);
            Console.WriteLine(y);
            //Fun2(out y);
            //Console.WriteLine(y);
            //Fun3(ref y);
           // Console.WriteLine(y);
            Fun4(y);
            Console.WriteLine(y);

            Point pun = new Point(2, 1);

            Console.WriteLine("{0},{1}", pun.x, pun.y);
            Fun5(pun);
            Console.WriteLine("{0},{1}",pun.x,pun.y);
            Fun6(ref pun);
            Console.WriteLine("{0},{1}", pun.x, pun.y);

            pun = null;
            //Fun5(pun);
           // Console.WriteLine("{0},{1}", pun.x, pun.y);
            pun = null;
            Fun6(ref pun);
            Console.WriteLine("{0},{1}", pun.x, pun.y);


            //Zadanie 2

        }

    }
}
