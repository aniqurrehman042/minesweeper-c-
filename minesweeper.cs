using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        public bool game;
        public string[,] Board = new string[10,10];
        public string[,] Cells = new string[10, 10];

        public Program()
        {
            
            for(int a=0;a<10;a++)
            {
                for(int b = 0; b < 10; b++)
                {
                    Cells[a, b] = "-";
                    Board[a, b] = " ";
                }
            }
            game = true;
        }
        public void New()
        {
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Cells[a, b] = "-";
                    Board[a, b] = " ";
                }
            }
        }
        public void Terminate()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            
            for(int a = 0; a < 10; a++)
            {
                for(int b = 0; b < 10; b++)
                {
                    if (Board[a, b] != Cells[a, b])
                    {
                        Console.SetCursorPosition((a * 2) + 2, (b * 2) + 2);
                        Console.WriteLine(Board[a, b]);
                    }
                }
            }
            game = false;
        }

        public void TakeInput()
        {
            Console.WriteLine("Choose Box(e.g. b5): ");
            string input = Console.ReadLine();
            for (int a=0;a<10;a++)
            {
                if (input == "a" + a.ToString())
                {
                    Cells[0, a] = Board[0,a];
                    if (Board[0, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[0, a]);
                        Terminate();
                        
                    }
                }
                if (input == "b" + a.ToString())
                {
                    Cells[1, a] = Board[1, a];
                    if (Board[1, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(1 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[1, a]);
                        Terminate();
                    }
                }
                if (input == "c" + a.ToString())
                {
                    Cells[2, a] = Board[2, a];
                    if (Board[2, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(2 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[2, a]);
                        Terminate();
                    }
                }
                if (input == "d" + a.ToString())
                {
                    Cells[3, a] = Board[3, a];
                    if (Board[3, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(3 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[3, a]);
                        Terminate();
                    }
                }
                if (input == "e" + a.ToString())
                {
                    Cells[4, a] = Board[4, a];
                    if (Board[4, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(4 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[4, a]);
                        Terminate();
                    }
                }
                if (input == "f" + a.ToString())
                {
                    Cells[5, a] = Board[5, a];
                    if (Board[5, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(5 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[5, a]);
                        Terminate();
                    }
                }
                if (input == "g" + a.ToString())
                {
                    Cells[6, a] = Board[6, a];
                    if (Board[6, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(6 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[6, a]);
                        Terminate();
                    }
                }
                if (input == "h" + a.ToString())
                {
                    Cells[7, a] = Board[7, a];
                    if (Board[7, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(7 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[7, a]);
                        Terminate();
                    }
                }
                if (input == "i" + a.ToString())
                {
                    Cells[8, a] = Board[8, a];
                    if (Board[8, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(8 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[8, a]);
                        Terminate();
                    }
                }
                if (input == "j" + a.ToString())
                {
                    Cells[9, a] = Board[9, a];
                    if (Board[9, a] == "M")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(9 * 2 + 2, a * 2 + 2);
                        Console.WriteLine(Board[9, a]);
                        Terminate();
                    }
                }
            }
            
        }

        public void CreateBoard()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("  a b c d e f g h i j");
            Console.SetCursorPosition(0,1);
            Console.WriteLine("\n0\n\n1\n\n2\n\n3\n\n4\n\n5\n\n6\n\n7\n\n8\n\n9");

            for(int a = 0; a < 10; a++)
            {
                for(int b = 0; b < 10; b++)
                {
                    if (Board[a, b] == Cells[a, b])
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(a * 2 + 2, b * 2 + 2);
                        Console.WriteLine(Cells[a, b]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(a * 2 + 2, b * 2 + 2);
                        Console.WriteLine(Cells[a, b]);
                    }
                }
            }
            
        }

        public void PutMines()
        {
            Random A = new Random();
            int end = 0;
            while(end<15)
            {
                int b = A.Next(0, 10);
                int c = A.Next(0, 10);
                if (Board[b, c] == " ")
                {
                    Board[b, c] = "M";
                    end++;
                }
                
            }
            for(int a = 0; a < 10; a++)
            {
                for(int b = 0; b < 10; b++)
                {
                    int c = 0;
                    if (Board[a, b] != "M")
                    {
                        if (a != 0&&Board[a - 1, b] == "M")
                        {
                            c++;
                        }
                        if (a != 9&&Board[a + 1, b] == "M")
                        {
                            c++;
                        }
                        if (a != 0 && b != 0&&Board[a - 1, b-1] == "M")
                        {
                            c++;
                        }
                        if (a != 9 && b != 0&&Board[a + 1, b-1] == "M")
                        {
                            c++;
                        }
                        if (b != 0&&Board[a , b-1] == "M")
                        {
                            c++;
                        }
                        if (a != 0 && b != 9&&Board[a - 1, b+1] == "M")
                        {
                            c++;
                        }
                        if (a != 9 && b != 9&&Board[a + 1, b+1] == "M")
                        {
                            c++;
                        }
                        if (b != 9&&Board[a , b+1] == "M")
                        {
                            c++;
                        }
                        Board[a, b] = c.ToString();
                    }
                }
            }
            
        }

        static void Main(string[] args)
        {
            bool retry = false;
            Program A = new Program();
            
            do
            {
                A.New();
                A.PutMines();
                
                retry = false;
                while (A.game)
                {
                    A.CreateBoard();
                    A.TakeInput();
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nDo you want to play again?(y/n)");
                if (Console.ReadLine() == "y")
                {
                    retry = true;
                    A.game = true;
                }
            } while (retry);


            Console.ReadLine();
        }
    }
}
