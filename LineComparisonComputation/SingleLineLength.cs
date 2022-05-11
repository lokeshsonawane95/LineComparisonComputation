using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    internal class SingleLineLength
    {
        public void LineLength()
        {
            Console.WriteLine("Enter the co-ordinates of the line");
            Console.WriteLine("Enter the first co-ordinate");
            Console.Write("Enter value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second co-ordinate");
            Console.Write("Enter value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Start (x1,y1) = ({0},{1})\t\tEndpoint (x2,y2) = ({2},{3})", x1, y1, x2, y2);
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line is : " + length + " units");
        }
    }
}
