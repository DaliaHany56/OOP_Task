using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Task
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Taxrate { get; set; }
        public double WorkingHours { get; set; }

        public double AVprofitForEachEmployee;
        

        internal double Achievedvalue
        {
            get
            {
                return AVprofitForEachEmployee = WorkingHours * 180;
            }

        }
        public Employee(string _name, int _id, double _taxrate, double _workingHours)
        {
            Name = _name;
            Id = _id;
            Taxrate = _taxrate;
            WorkingHours = _workingHours;
        }
        public abstract double CalculateTotalSalaries();
        public abstract void ShowEmployee();

    
    }
}
