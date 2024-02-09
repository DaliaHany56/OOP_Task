using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
      public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public List<Employee> Employees { get; set; }

        public double Profit { get; set; }

        public double profit
        {
            get
            {
                return Profit;
            }
            set
            {
                if (value < 0)
                     throw new ArgumentException("value less than zero");
                Profit = value; ;

                
            }
        }







        public Company(string companyName , string companyLocation, List<Employee> employees)
        {
            CompanyName = companyName;
            
            CompanyLocation = companyLocation;

           Employees = employees;
            
            
        }
        public double CalculateTotalSalary()
        {
            double result = 0;
            foreach (Employee emp in Employees)
            {
                result += emp.CalculateTotalSalaries();
            }
            return result;
        }





    }
}
