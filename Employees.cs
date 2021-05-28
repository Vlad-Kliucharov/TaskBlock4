using System;
using System.Collections.Generic;
using System.Linq;


namespace TaskBlock4
{
    public class Employees : EmploeesList
    {
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

            Console.WriteLine($"Enter Employees Department from list: 1-Eployee, 2-Accontant, 3-Boss");
            Employee.Department = Console.ReadLine();
            string[] DepartmentName = { "Employee", "Accontant", "Boss" };

            //Employee.Department = DepartmentName[Convert.ToInt32(Employee.Department) - 1];

            foreach (var item in DepartmentName)
            {
                switch (Employee.Department)
                {
                    case "1":
                        Console.WriteLine("Employee department");
                        Employee.Department = DepartmentName[0];
                        break;
                    case "2":
                        Console.WriteLine("Accountant department");
                        Employee.Department = DepartmentName[1];
                        break;
                    case "3":
                        Console.WriteLine("Boss department");
                        Employee.Department = DepartmentName[2];
                        break;
                }
            }

            while (Employee.Salary != Double.NaN)
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

