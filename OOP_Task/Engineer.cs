using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    internal class Engineer : Employee

    {
        public double overTimeHours;
        public double OverTimeHours
        {
            get
            {
                return overTimeHours;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("value less than zero");
                overTimeHours = value;
            }
        }
        public double Salary {get;set;}
        public Engineer(string _name, int _id, double _taxrate, double _workingHours, double overtimehour ) : base(_name, _id, _taxrate, _workingHours)
        {
            OverTimeHours = overtimehour;
            
        }
        public override double CalculateTotalSalaries()
        {
            return Salary=(WorkingHours * 80) + (OverTimeHours * 100) - Taxrate;
        }

        public override void ShowEmployee()
        {
            Console.WriteLine($"Eng {Name} ,Id {Id} ,his salary is {Salary}");
        }
    }
}
