﻿using System;

namespace Felande
{
    class Program
    {
        /// <summary>
        /// Korrigera koden så att programmet kan köras ordentligt. Det finns många fel i koden. 
        /// Tips för att lösa uppgiften. Hovra över det som är rött i koden och se om felmeddelandena kan hjälpa dig.
        /// Om du kör fast helt kan du även kolla i projektet Uppgift1_Korrekt för att se hur ett fungerande programmer ser ut.
        /// Kör hårt!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            Console.WriteLine("Hej, välkommen till uppgift 1!");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();
            
            string namn = "Linda";
            Console.WriteLine();
            Console.WriteLine($"Här ser du en sträng representerat av variabeln 'namn': {namn}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();
            
            bool sant = true;
            Console.WriteLine();
            Console.WriteLine($"Boolean eller bool är en användbar datatyp när man vill avgör om något är sant eller falskt. Här ser vi variabeln sants värde: {sant}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();
            
            DateTime datum = DateTime.Now;
            Console.WriteLine("Här ser du ett datum representerat av variabeln 'datum': {datum}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();


            decimal decimaltal = 0.5m;
            Console.WriteLine();
            Console.WriteLine("Här ser du ett flyttal representerat av variabeln 'decimaltal': {decimaltal}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");


            int helttal = 30;
            Console.WriteLine();
            Console.WriteLine("Här ser du ett heltal representerat av variabeln 'heltal': {helttal}");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

           


            //KLART!
        }

    }


}
