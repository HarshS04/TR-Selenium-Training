using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Emplyee
    {
        public int empId;
        public string empName;
        public int empSalary;
        public string empPerformance;
        public static string companyName;

        //Constructor
        public Emplyee()
        {
            Console.WriteLine("Object created!!");
            Console.WriteLine("Launch Browser");
        }

        public Emplyee(int empId)
        {
            Console.WriteLine("Object created!!");
            Console.WriteLine("Launch browser");
            this.empId = empId;
        }

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                if (value>100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine("Currently employee id id 0. Please provide value more than 100");
                }
            }
        }
        public string EmpPerformance
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if (empPerformance.Equals("A") || empPerformance.Equals("B") || empPerformance.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please provide employee performace value either A,B or C");
                }
            }
        }
        public void DisplayEmplyeeDetail()
        {
            Console.WriteLine("Employee ID: "+empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Employee empPerformance: " + empPerformance);
            Console.WriteLine("Company name: " + Emplyee.companyName);
            Console.WriteLine("-----------------------------------------------");
        }

        //AllocateBonus
        public void AllocateBonus()
        {
            if(empPerformance.Equals("A"))
            {
                empSalary = empSalary + 1000;
            }
            else if (empPerformance.Equals("B"))
            {
                empSalary = empSalary + 500;
            }
            else
            {
                empSalary = empSalary + 100;
            }
        }
    }
}
