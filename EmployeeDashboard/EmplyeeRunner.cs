using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmplyeeRunner
    {
        static void Main(string[] args)
        {
            Emplyee.companyName = "TR";

            Emplyee emp1= new Emplyee();
            Emplyee emp2 = new Emplyee();
            Emplyee emp3 = new Emplyee();

            emp1.empId = 101;
            emp1.empName = "peter";
            emp1.empSalary = 9000;
            emp1.empPerformance = "B";

            emp2.empId = 102;
            emp2.empName = "peter";
            emp2.empSalary = 7000;
            emp2.empPerformance = "A";

            emp1.DisplayEmplyeeDetail();
            emp2.DisplayEmplyeeDetail();
            emp3.DisplayEmplyeeDetail();

            emp1.AllocateBonus();
            emp2.AllocateBonus();
            emp3.AllocateBonus();

            emp1.DisplayEmplyeeDetail();
            emp2.DisplayEmplyeeDetail();
            emp3.DisplayEmplyeeDetail();
        }
    }
}
