using System;

namespace Es_lezione1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("What is the input string?:");
            string stringa = Console.ReadLine();
            while (stringa == "")
            {
                Console.WriteLine("Write something");
                stringa = Console.ReadLine();
            }
            stringa = stringa.Replace(" ", String.Empty);
            int i;
            for (i = 0; i < stringa.Length; i++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n{stringa} ha {i} caratteri");
            Console.ReadKey();
        }
    }
}
