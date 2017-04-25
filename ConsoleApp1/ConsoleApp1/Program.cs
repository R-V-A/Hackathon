using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Console.WriteLine("");
                if (P._coordinates.x == 25 || P._coordinates.y == 25)
                {
                    Console.WriteLine("Следующий шаг в этом же напрвлении приведет у смерти");
                }
                if (P._coordinates.x == 26 || P._coordinates.y == 26)
                {

                    break;
                }
                var action = Console.ReadLine();
                switch (action)
                {
                    case "6": P._coordinates.x++; break;
                    case "8": P._coordinates.y++; break;
                    case "4": P._coordinates.x--; break;
                    case "2": P._coordinates.y--; break;
                    default: break;
                }
                Console.WriteLine(P.Show(P._coordinates));
            }

            Console.WriteLine("Падение с платформы\nИгра окончена");
            Console.ReadKey();
        }

        
    }
}
