﻿using System;
namespace Lab8
{
    public class Zadanie1
    {
        public void Wyw1()
        {
            string[] slowa = new string[]
            {
            // Indeks od początku od końca
            "Już północ", // 0 ^10
            "cień", // 1 ^9
            "ponury", // 2 ^8
            "pół", // 3 ^7
            "świata", // 4 ^6
            "okrywa", // 5 ^5
            "A jeszcze", // 6 ^4
            "serce", // 7 ^3
            "zmysłom", // 8 ^2
            "spoczynku nie daje" // 9 ^1
            // 10(słowa.Lenght) ^0
            };
            //Punkt 1
            // Console.WriteLine($"{slowa[^1]}");

            //Punkt 2
            string[] sonet1 = slowa[2..6];
            foreach (var slowo in sonet1)
                Console.Write($"< { slowo} >");

            Console.WriteLine();

            //Punkt 3
            string[] sonet2 = words[^3..^0];
            foreach (var word in sonet2)
                Console.Write($"{slowo}");
            Console.WriteLine();

            //Punkt 4
            string[] sonet3 = slowa[..];
            string[] sonet4 = slowa[..5];
            string[] sonet5 = slowa[7..];

            //Punkt 5
            Index stri = ^5;
            Console.WriteLine(slowa[stri]);

            //Punkt 6
            Range fraza = 2..7; 
            string[] tekst = slowa[fraza];
            foreach (var slowo in tekst)
            Console.Write($" {slowo} ");
            Console.WriteLine();
        }
    }
}
