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

            var action = Console.ReadLine();
            if (action == "1")
                P._coordinates.y ++ ;

            Console.WriteLine(P.Show(P._coordinates));
            Console.ReadKey();
        }

        
    }
}
