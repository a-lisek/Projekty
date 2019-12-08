using System;
namespace Lab7
{
    public class Zadanie2
    {
        public void Wyw2()
        {

            Point p1 = new Point(3,5);
            Console.WriteLine("Punkt p1 to :{0},{1}", p1.x, p1.y);
            Point p2 = new Point(9,1);
            Console.WriteLine("Punkt p2 to :{0},{1}", p2.x, p2.y);
            Point p3 = p1 + p2;
            Console.WriteLine("Punkt p3 = p1 + p3 to :{0},{1}",p3.x, p3.y);

            if (p1 <= p3)
            {
                Console.WriteLine("Punkt p1 jest mniejszy niz p3");
            }
            p3++;
            Console.WriteLine("Punkt p3++ to :{0},{1}", p3.x, p3.y);
            p3--;
            Console.WriteLine("Punkt p3-- to :{0},{1}", p3.x, p3.y);



            Point p13 = 5;
            Console.WriteLine("Punkt p13 (5,0) to :{0},{1}", p13.x, p13.y);

            int suma = (int)p1;
            Console.WriteLine("Suma wpolrzednych pkt p1 {0}",suma);
        }
    }
    public class Point
    {
        public int x, y;
        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static bool operator true(Point p1)
        {
            return !(p1.x == 0 && p1.y == 0);
        }
        public static bool operator false(Point p1)
        {
            return (p1.x == 0 && p1.y == 0);
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.x == p2.x && p2.y == p1.y);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.x != p2.x || p2.y != p1.y);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.x <= p2.x && p1.y <= p2.y);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.x >= p2.x && p1.y >= p2.y);
        }
        public static Point operator ++(Point p1)
        {
            Point pnew = new Point(p1.x + 1, p1.y + 1);
            return pnew;
        }
        public static Point operator --(Point p1)
        {
            Point pnew = new Point(p1.x - 1, p1.y - 1);
            return pnew;
        }

        public static implicit operator Point(int v)
        {
            return new Point(v,0);
        }

        public static explicit operator int(Point v)
        {
            return (v.x + v.y);
        }
    }
}
