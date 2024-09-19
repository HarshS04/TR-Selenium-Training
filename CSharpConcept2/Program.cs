using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Formulae;

namespace TR.CSharpConcept2
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int radius = 10;

            //load all non-static feilds in memory
            Area obj = new Area();

            double result = Area.AreaOfCirle(10);
            Console.WriteLine(result);

            result = Area.AreaOfCirle(20);
            Console.WriteLine(result);

            Console.WriteLine(Area.AreaOfCirle(30));

            double output = obj.AreaOfRectangle(10, 2.5);
            Console.WriteLine(output);

            double output1 = Area.AreaOfTriangle(10, 8.5);
            Console.WriteLine(output1);

            string name = Area.GetAuthorName();
            Console.WriteLine(name);

            Area.Quit();
        }
    }
}
