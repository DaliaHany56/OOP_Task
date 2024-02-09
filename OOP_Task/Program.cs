using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           


            Sales sales1 = new Sales("Ahmed", 1, 100, 208);
            Sales sales2 = new Sales("Mohamed", 2, 200, 201);
            Sales sales3 = new Sales("Mustafa", 3, 200, 200);
            Sales sales4 = new Sales("NOOR", 4, 200, 216);
            Sales sales5 = new Sales("Mona", 5, 200, 150);
            Sales sales6 = new Sales("Ali", 6, 200, 180);
            Sales sales7 = new Sales("Salem", 7, 200, 190);
            
            Engineer engineer1 = new Engineer("Mahmoud", 8, 100, 8 * 26, 4 * 10);
            Engineer engineer2 = new Engineer("Ali", 8, 100, 8 * 25, 3 * 10);
            Engineer engineer3 = new Engineer("Salwa", 8, 100, 8 * 26, 4 * 8);
            Engineer engineer4 = new Engineer("Ahmed", 8, 100, 8 * 22, 4 * 5);
            Engineer engineer5 = new Engineer("Samy", 8, 100, 8 * 24, 2 * 10);
            Engineer engineer6 = new Engineer("Nahla", 8, 100, 8 * 20, 1 * 10);
            Engineer engineer7 = new Engineer("Mona", 8, 100, 8 * 26, 4 * 7);
            Engineer engineer8 = new Engineer("Amgad", 8, 100, 8 * 23, 4 * 6);

            var employees = new List<Employee> ();
            List<Employee> income = new List<Employee> ();
            income.Add(sales1);
            income.Add(sales2);
            income.Add(sales3);
            income.Add(sales4);
            income.Add(sales5);
            income.Add(sales6);
            income.Add(sales7);
            //-------------------------------------
            employees.Add(sales1);
            employees.Add(sales2);
            employees.Add(sales3);
            employees.Add(sales4);
            employees.Add(sales5);
            employees.Add(sales6);
            employees.Add(sales7);
            employees.Add(engineer1);
            employees.Add(engineer2);
            employees.Add(engineer3);
            employees.Add(engineer4);
            employees.Add(engineer5);
            employees.Add(engineer6);
            employees.Add(engineer7);
            employees.Add(engineer8);


            sales1.CalculateTotalSalaries();
            sales1.ShowEmployee();
            sales2.CalculateTotalSalaries();
            sales2.ShowEmployee();
            sales3.CalculateTotalSalaries();
            sales3.ShowEmployee();
            sales4.CalculateTotalSalaries();
            sales4.ShowEmployee();
            sales5.CalculateTotalSalaries();
            sales5.ShowEmployee();
            sales6.CalculateTotalSalaries();
            sales6.ShowEmployee();
            sales7.CalculateTotalSalaries();
            sales7.ShowEmployee();

            engineer1.CalculateTotalSalaries();
            engineer1.ShowEmployee();
            engineer2.CalculateTotalSalaries();
            engineer2.ShowEmployee();
            engineer3.CalculateTotalSalaries();
            engineer3.ShowEmployee();
            engineer4.CalculateTotalSalaries();
            engineer4.ShowEmployee();
            engineer5.CalculateTotalSalaries();
            engineer5.ShowEmployee();
            engineer6.CalculateTotalSalaries();
            engineer6.ShowEmployee();
            engineer7.CalculateTotalSalaries();
            engineer7.ShowEmployee();
            engineer8.CalculateTotalSalaries();
            engineer8.ShowEmployee();


            Company company1 = new Company("ECG", "Nasr City", employees);

            Console.WriteLine($" Company Name : {company1.CompanyName} , Location  : {company1.CompanyLocation} ");
         
            //double TotalSalaries = employees.Sum(e => e.CalculateTotalSalaries());
            //Console.WriteLine($"Total Salaries = {TotalSalaries}");

            Console.WriteLine($"Total Salaries = {company1.CalculateTotalSalary()}");


            double TotalIncome = income.Sum(x => x.Achievedvalue);
            Console.WriteLine($"Total Income = {TotalIncome}");

            
            company1.Profit = TotalIncome - company1.CalculateTotalSalary();

            Console.WriteLine($"Profit of the company={ company1.Profit}");
         

            //double ProfitOfTheCompany = sales1.achievedvalue + sales2.achievedvalue + sales3.achievedvalue + sales4.achievedvalue + sales5.achievedvalue + sales6.achievedvalue + sales7.AchievedValue;
            //Console.WriteLine(ProfitOfTheCompany);


        }
    }
}
