using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Field f = new Field();
            int x = 0;
            int y = 0;
            Guard g = new Guard(new Person.Coordinate { x = 5, y = 5 }, 10, 1, 1);

            Console.WriteLine("Введите начальные координаты");

            while (true)
            { 
                try
                {
                    x = Int32.Parse(Console.ReadLine());
                    y = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидалось целое число");
                    continue;               
                }
                break;
            }
            Person.Coordinate coordinates;
            coordinates.x = x;
            coordinates.y = y;

            MainCharacter P = new MainCharacter(coordinates);
            Console.WriteLine("Ваш ход");
            while (true)
            {
                g.Update();
                Console.SetCursorPosition(0, 3);
                for (int j = 0; j < 25; j++)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        if (P._coordinates.x == i && P._coordinates.y == j)
                            Console.Write("P");
                        
                        else if (g.Coordinates.x == i && g.Coordinates.y == j)
                            Console.Write("X");
                        else
                        {
                            switch (f[i, j].CellType)
                            {
                                case TypeOfCell.Empty:
                                    Console.Write(" ");
                                    break;
                                case TypeOfCell.HWall:
                                    Console.Write("|");
                                    break;
                                case TypeOfCell.WWall:
                                    Console.Write("—");
                                    break;
                            }
                        }
                    }
                    Console.WriteLine();
                }
                
                Console.WriteLine("");
                if (P._coordinates.x >= 26 || P._coordinates.y >= 26 || P._coordinates.y <= 0 || P._coordinates.x <= 0)
                {
                    break;
                }
                var action = Console.ReadLine();
                switch (action)
                {
                    case "6": P._coordinates.x++; break;
                    case "8": P._coordinates.y--; break;
                    case "4": P._coordinates.x--; break;
                    case "2": P._coordinates.y++; break;
                }
                //Console.WriteLine(P.Show(P._coordinates));
            }

            Console.WriteLine("Падение с платформы\nИгра окончена");
            Console.ReadKey();
        }

        

        
    }
}
