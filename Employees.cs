using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskBlock2
{
    public class Employees : EmploeesList
    {
        public string Name;
        public double Age;
        public double Salary;
        public string Department;
        public double Hours;

        public static Employees AddEmployees()
        {

            Employees Employee = new Employees(); //Creation of new object "Employee"


            Console.WriteLine($"Enter Employees name: ");
            Employee.Name = Console.ReadLine();

            while (Employee.Age != Double.NaN)
            {
                try
                {
                    Console.WriteLine($"Enter Employees Age: ");
                    Employee.Age = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"You entered not a NAN value, try again");
                }
            }

            while (Employee.Salary != Double.NaN)
            {
                try
                {
                    Console.WriteLine($"Enter Employees Salary: ");
                    Employee.Salary = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"You entered not a NAN value, try again");
                }
            }
           
            Console.WriteLine($"Enter Employees Department: ");
            Employee.Department = Console.ReadLine();

            while(Employee.Salary != Double.NaN)
            {
                try
                {
                    Console.WriteLine($"Enter employees work hours: ");
                    Employee.Hours = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"You entered not a NAN value, try again");
                }
            }

            return Employee;
        }

        public static void OptionList(List<Employees> PersonsList)
        {
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    double MaxSalary = PersonsList.Max(s => s.Salary);
                    Console.WriteLine($"Max salary is {MaxSalary}");
                    break;
                case "2":
                    double MinSalary = PersonsList.Min(s => s.Salary);
                    Console.WriteLine($"Mix salary is {MinSalary}");
                    break;
                case "3":
                    double AvarageAge = PersonsList.Average(a => a.Age);
                    Console.WriteLine($"An average age of employees is {AvarageAge}");
                    break;
                default:
                    Console.WriteLine("You enter incorrect value");
                    break;
            }
        }
    }
}

