using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TR.Formulae
{
    public class Area
    {
        public static double AreaOfCirle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        //AreaOfTriangle
        public static double AreaOfTriangle(double Varbase, double height)
        {
            return 0.5 * (Varbase * height);
        }

        public static string GetAuthorName()
        {
            return "Harsh Shinde";
        }

        public static void Quit()
        {

        }
    }
}
