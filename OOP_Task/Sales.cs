using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    internal class Sales : Employee
    {
      
        public double Salary { get; set; }

        public Sales(string _name, int _id, double _taxrate, double _workingHours ) : base(_name, _id, _taxrate, _workingHours)
        {
            
        }

        public override double CalculateTotalSalaries()
        {

            Salary = WorkingHours * 50 - Taxrate;

            if (Achievedvalue < 20000)
            {
                return Salary;
            }
            else
            {
                return Salary = WorkingHours * 50 - Taxrate + 1500;
            }

        }
        public override void ShowEmployee()
        {
            Console.WriteLine($"the employee {Name} " +
                $"Id ={Id}  " +
                $"his Salary = {Salary}");
        }
    }
}
