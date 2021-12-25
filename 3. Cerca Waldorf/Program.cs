using System;

namespace Cercaparole
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = {
                { 't', 'b', 'c', 'i', 'a', 'o', 'g', 'f', 'i', 'g', 'g' },
                { 'h', 'u', 'i', 'r', 'r', 'a', 'r', 'd', 'o', 'w', 'f' },
                { 'f', 't', 'a', 'a', 'o', 'o', 'l', 'd', 'a', 'r', 'm' },
                { 'f', 't', 'o', 'l', 'd', 'o', 'l', 'l', 's', 'r', 'c' },
                { 'b', 'y', 'o', 'l', 'd', 'b', 'a', 'd', 'e', 'y', 'v' },
                { 'k', 'l', 'a', 'b', 'a', 'o', 'i', 'i', 'o', 'm', 'k' },
                { 's', 'w', 'r', 'e', 'r', 'g', 'r', 'd', 'c', 'r', 'b' },
                { 'f', 'c', 'i', 'a', 'o', 'a', 'w', 'f', 'b', 'j', 'w' },
            };
            int[,] coordinate = new int[50, 2];
            int coordinateCounter = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                    Console.Write(Convert.ToString(arr[row, col]) + " ");
                Console.Write('\n');
            }

            Console.WriteLine("Parola da cercare:");
            string parola = Console.ReadLine(); ;
            ricerca(arr, parola);
            stampaAColori(); // da finire





            void ricerca(char[,] arr, string parola)
            {
                for (int row = 0; row < arr.GetLength(0); row++)
                    for (int col = 0; col < arr.GetLength(1); col++)
                        if (arr[row, col] == parola[0])
                        {
                            if (col + parola.Length <= arr.GetLength(1))
                                controlloParolaOrizzontaleDx(arr, parola, row, col);
                            if (col - parola.Length+1 >= 0)
                                controlloParolaOrizzontaleSx(arr, parola, row, col);
                            if (row + parola.Length <= arr.GetLength(0))
                                controlloParolaVerticaleDw(arr, parola, row, col);
                            if (row - parola.Length + 1 >= 0)
                                controlloParolaVerticaleUp(arr, parola, row, col);
                            if (col + parola.Length <= arr.GetLength(1) && row + parola.Length <= arr.GetLength(0))
                                controlloParolaDxDw(arr, parola, row, col);
                            if (col - parola.Length + 1 >= 0 && row + parola.Length <= arr.GetLength(0))
                                controlloParolaSxDw(arr, parola, row, col);
                            if (col - parola.Length + 1 >= 0 && row - parola.Length + 1 >= 0)
                                controlloParolaSxUp(arr, parola, row, col);
                            if (col + parola.Length <= arr.GetLength(1) && row - parola.Length + 1 >= 0)
                                controlloParolaDxUp(arr, parola, row, col);

                        }
            }
            void controlloParolaOrizzontaleDx(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row, col + i] == parola[i]; i++)
                {
                    if (i == parola.Length - 1)
                    {

                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaOrizzontaleSx(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row, col - i] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaVerticaleDw(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row + i, col] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaVerticaleUp(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row - i, col] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaDxDw(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row + i, col + i] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaSxDw(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row + i, col - i] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaSxUp(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row - i, col - i] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }
            void controlloParolaDxUp(char[,] arr, string parola, int row, int col)
            {
                for (int i = 0; i < parola.Length && arr[row - i, col + i] == parola[i]; i++)
                {
                    if (i == parola.Length-1)
                    {
                        Console.WriteLine($"\nrigha:{row}\ncolonna:{col}\n\n");
                        coordinate[coordinateCounter, 0] = row;
                        coordinate[coordinateCounter, 1] = col;
                        coordinateCounter++;
                    }
                }
            }

            void stampaAColori()
            {
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    for (int col = 0; col < arr.GetLength(1); col++)
                    {
                        Boolean colore = true;
                        for (int x = 0; x < arr.GetLength(0); x++)
                        {
                            if (coordinate[x, 0] == row && coordinate[x, 1] == col)
                            {
                                colore = true;
                                break;
                            }
                            else
                            {
                                colore = false;
                            }

                        }

                        if (colore)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Convert.ToString(arr[row, col]) + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.Write(Convert.ToString(arr[row, col]) + " ");
                        }
                    }
                    Console.Write('\n');
                }
            }



        }

    }
}
