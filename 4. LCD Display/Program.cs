using System;

namespace LCD_display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i numeri");
            string numeri = Console.ReadLine();
            string[,] LCD = new string[5, 100];

            for (int i = 0; i < numeri.Length; i++)
            {
                cella(i);

                switch (numeri[i])
                {
                    case '0':
                        LCD[2, (i * 3) + 1] = " ";
                        break;
                    case '1':
                        LCD[0, (i * 3) + 1] = " ";
                        LCD[1, (i * 3) + 0] = " ";
                        LCD[2, (i * 3) + 1] = " ";
                        LCD[3, (i * 3) + 0] = " ";
                        LCD[4, (i * 3) + 1] = " ";
                        break;
                    case '2':
                        LCD[1, (i * 3) + 0] = " ";
                        LCD[3, (i * 3) + 2] = " ";
                        break;
                    case '3':
                        LCD[1, (i * 3) + 0] = " ";
                        LCD[3, (i * 3) + 0] = " ";
                        break;
                    case '4':
                        LCD[0, (i * 3) + 1] = " ";
                        LCD[3, (i * 3) + 0] = " ";
                        LCD[4, (i * 3) + 1] = " ";
                        break;
                    case '5':
                        LCD[1, (i * 3) + 2] = " ";
                        LCD[3, (i * 3) + 0] = " ";
                        break;
                    case '6':
                        LCD[1, (i * 3) + 2] = " ";
                        break;
                    case '7':
                        LCD[1, (i * 3) + 0] = " ";
                        LCD[2, (i * 3) + 1] = " ";
                        LCD[3, (i * 3) + 0] = " ";
                        LCD[4, (i * 3) + 1] = " ";
                        break;
                    case '8':
                        break;
                    case '9':
                        LCD[3, (i * 3) + 0] = " ";
                        break;
                }
            }

            void cella(int i)
            {
                LCD[0, i * 3] = " ";
                LCD[0, (i * 3) + 1] = "_";
                LCD[0, (i * 3) + 2] = " ";

                LCD[1, i * 3] = "|";
                LCD[1, (i * 3) + 1] = " ";
                LCD[1, (i * 3) + 2] = "|";

                LCD[2, i * 3] = " ";
                LCD[2, (i * 3) + 1] = "_";
                LCD[2, (i * 3) + 2] = " ";

                LCD[3, i * 3] = "|";
                LCD[3, (i * 3) + 1] = " ";
                LCD[3, (i * 3) + 2] = "|";

                LCD[4, i * 3] = " ";
                LCD[4, (i * 3) + 1] = "_";
                LCD[4, (i * 3) + 2] = " ";




            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int k = 0; k < LCD.GetLength(0); k++)
            {
                for (int j = 0; j < LCD.GetLength(1); j++)
                {
                    Console.Write("{0}", LCD[k, j]);
                    if((j+1) % 3 == 0)
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write(Environment.NewLine);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
