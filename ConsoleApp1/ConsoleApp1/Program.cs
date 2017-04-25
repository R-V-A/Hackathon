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
            while (true)
            {
                Show(f);
                
            }
            
        }

        static void Show(Field f)
        {
            Console.SetCursorPosition(0, 0);
            for (int x = 0; x < 25; x++)
            {
                for (int y = 0; y < 25; y++)
                {
                    switch (f[x,y].CellType)
                    {
                        case TypeOfCell.Empty:
                            Console.Write("E");
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
