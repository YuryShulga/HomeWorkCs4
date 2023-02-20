using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCs4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point("p1", 1,1);
            Console.WriteLine(p1);

        }
    }

    class Point { 
        public String Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }  

        public Point(string name, int x, int y)
        {
            Name = name;
            X= x;
            Y= y;
        }
        public override String ToString()
        {
            return (Name+"("+X+";"+Y+")");
        }
        public static Point operator ++(Point p1) {
            return p1;
        }
    }
}
