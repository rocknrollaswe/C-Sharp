using System;

namespace Villkor_och_loopar
{

    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int startNummer = 0,
                startTimme = 0,
                startMinut = 0,
                startSekund = 0,
                malTimme = 0,
                malMinut = 0,
                malSekund = 0,
                startTidISekunder = 0,
                maltidISekunder = 0,
                slutTidISekunder = 0,
                bastaStartNummer = 0,
                bastaTid = int.MaxValue;
                int antalTavlande = 0;
                int totalTidSekunderDygn = 86400; 
                //bastaSlutTimme = 0,
                //bastaSlutMinut = 0,
                //bastaSlutSekund = 0;
                string bastaSlutTid = null;
            Console.WriteLine(Enheter(3140));

            while (true)
            {
                Console.WriteLine("Ange startnummer: ");
                startNummer = int.Parse(Console.ReadLine());

                if (startNummer < 1)
                {
                    break;
                }
                antalTavlande++;

                Console.WriteLine("Ange timme för start: ");
                startTimme = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange minut för start: ");
                startMinut = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange sekund för start: ");
                startSekund = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange timme för mål: ");
                malTimme = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange minut för mål: ");
                malMinut = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange sekund för mål: ");
                malSekund = int.Parse(Console.ReadLine());


                startTidISekunder = (startTimme * 60) * 60 + (startMinut * 60) + startSekund;
                maltidISekunder = (malTimme * 60) * 60 + (malMinut * 60) + malSekund;

                slutTidISekunder = maltidISekunder - startTidISekunder;

                if (startTimme > malTimme)
                {
                    slutTidISekunder = totalTidSekunderDygn - startTidISekunder + maltidISekunder; 

                }


                if (slutTidISekunder < bastaTid)
                {
                    bastaStartNummer = startNummer;
                    bastaTid = slutTidISekunder;

                }
            }
                Console.WriteLine($"Vinnare är startnr: {bastaStartNummer}");
               
                bastaSlutTid = Enheter(bastaTid);
                //bastaSlutTimme = (int)(Math.Floor((decimal)bastaTid /60/60));
                //bastaSlutMinut = (int)Math.Floor((decimal)bastaTid / 60) - (bastaSlutTimme * 60);
                //bastaSlutSekund = bastaTid % 60;
                //bastaSlutEnheter = Enheter(bastaTid);

                Console.WriteLine($"Vinnande sluttid: {bastaSlutTid} ");
                Console.WriteLine($"Antal tävlande: {antalTavlande}");

                 


        }

        public static string Enheter(int bastaTid) // Metod för att räkna ut enheter ur sekunder
        {
            int timmar = bastaTid / 3600;
            int minuter = (bastaTid % 3600)  / 60;
            int sekunder = bastaTid % 60;
            return string.Format("{0:D2}:{1:D2}:{2:D2}", timmar, minuter, sekunder);
        }






    }
}
