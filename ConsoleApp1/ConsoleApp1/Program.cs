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

            var x = Int32.Parse(Console.ReadLine());
            var y = Int32.Parse(Console.ReadLine());

            Person.Coordinate coordinates;
            coordinates.x = x;
            coordinates.y = y;

            MainCharacter P = new MainCharacter(coordinates);

            while (true)
            {
                if (P._coordinates.x == 25 || P._coordinates.y == 25)
                    break;
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

            Console.WriteLine(P.Show(P._coordinates));
            Console.ReadKey();
        }

        
    }
}
