using System;

namespace Citazione_e_autore
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] citazioniAutori = new string[3,2];
            for(int i = 0; i < citazioniAutori.GetLength(0); i++)
            {
                for (int j = 0; j < citazioniAutori.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Scrivi la citazione");
                        citazioniAutori[i, j] = Console.ReadLine();
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("Scrivi l'autore");
                        citazioniAutori[i, j] = Console.ReadLine();

                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < citazioniAutori.GetLength(0); i++)
            {
                Console.WriteLine("{0,50}",$"{citazioniAutori[i, 1]} ha detto, \"{citazioniAutori[i, 0]}\"");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
