using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();
            Console.ReadLine();
        }

        //    Draw(1,3,'@');
        //    Draw(4,5,'#');
        //    Console.ReadLine();
        //}
        //static void Draw(int x, int y, char sym)
        //{
        //    Console.SetCursorPosition(x, y);
        //    Console.Write(sym);
        //}
    }
}
