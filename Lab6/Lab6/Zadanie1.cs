using System;
using System.Collections.Generic;

namespace Lab6
{
    public class Zadanie1
    {
        public void Wyw1()
        {
            ChristmasTree C1 = new ChristmasTree("Choinka1", 1);
            C1.Add("zielona", "kula");
            C1.Add("biala", "kostka");
            C1.Add("niebieski", "dzwonek");
            C1.Add("czerwona", "gwiazda");

            Console.WriteLine(C1[1]);
            Console.WriteLine(C1["czerwona"]);

            C1[1] = "niebieska";
            Console.WriteLine(C1[1]);

            ChristmasTreeA C2 = new ChristmasTreeA("Choinka2", 2);
            C2.Add("zielona", "kula");
            C2.Add("biala", "kostka");
            C2.Add("niebieski", "dzwonek");
            C2.Add("czerwona", "gwiazda");
            Console.WriteLine(C2[1]);

            ChristmasTreeB C3 = new ChristmasTreeB("Choinka3", 2);
            C3.Add("zielona", "kula");
            C3.Add("biala", "kostka");
            C3.Add("niebieski", "dzwonek");
            C3.Add("czerwona", "gwiazda");
            Console.WriteLine(C3[1]);
        }
    }
    public class Tree
    {
        string _name;
        int _wiek;
        public Tree(string name, int wiek)
        {
            _name = name;
            _wiek=wiek;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Wiek
        {
            get => _wiek;
            set => _wiek = value;
        }

    }
    public class Fir:Tree
    {
        public Fir(string name, int wiek):base(name,wiek)
        {
            _baubles = new List<Bauble>();
        }

        protected List<Bauble> _baubles;

        public void Add(string color, string typ)
        {
            Bauble b1 = new Bauble(color, typ);
            _baubles.Add(b1);
        }
        public void Remove(int ind)
        {

            _baubles.RemoveAt(ind);
        }

        public class Bauble
        {
            string _color;
            string _typ;
            

            public Bauble(string color, string typ)
            {
                _color = color;
                _typ = typ;
            }
            public string Color
            {
                get => _color;
                set => _color = value;
            }
            public string Typ
            {
                get => _typ;
                set => _typ = value;
            }


        }
    }
    public class ChristmasTree:Fir
    {
        public ChristmasTree(string name, int wiek):base(name,wiek)
        {

        }
        public string this[int ind]
        {
            get
            {
                Bauble b1 = _baubles[ind];
                return b1.Color;
            }
            set
            {
                _baubles[ind].Color = value;
            }
        }
        public int this[string color]
        {
            get
            {
                return _baubles.FindIndex(b => b.Color == color);
            }
        }

    }
    public class ChristmasTreeA : ChristmasTree
    {
        public ChristmasTreeA(string name, int wiek) : base(name, wiek)
        {

        }
        public string this[int ind]
        {
            get
            {
                Bauble b1 = _baubles[ind];
                return b1.Typ;
            }
        }
        public string BaubleColor(int ind)
        {
            return base[ind];
        }

    }
    public class ChristmasTreeB : ChristmasTreeA
    {
        public ChristmasTreeB(string name, int wiek) : base(name, wiek)
        {

        }
        public string this[int ind]
        {
            get
            {
                Bauble b1 = _baubles[ind];
                return b1.Typ + "_" + b1.Color;

            }
        }
     

    }
    public sealed class ChristmasTreeC : ChristmasTreeB
    {
        public ChristmasTreeC(string name, int wiek) : base(name, wiek)
        {

        }

    }



    }
