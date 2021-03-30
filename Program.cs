using System;
using System.Collections.Generic;
using System.Threading;


namespace TaskBlock2
{
    class Program
    {

        static List<PersonAttribute> PersonsList = new List<PersonAttribute>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select the action (the value):");
                Console.WriteLine("1 - Add new employee");
                Console.WriteLine("2 - Select all employees");
                Console.WriteLine("3 - Select one parametr from list");
                Console.WriteLine("4 - Select user by department");
                Console.WriteLine("5 - Select user by name");
                string SelectAction = Console.ReadLine();
                switch (SelectAction)
                {
                    case "1":
                        Console.WriteLine("Add new employee");
                        PersonsList.Add(PersonAttribute.AddEmployees());
                        break;
                    case "2":
                        Console.WriteLine($"Select all employees");
                        //Select "PersonsList" for itemize
                        PersonAttribute.SelectAllEmployees(PersonsList); //Use "PersonAttribute" for itemize
                        break;
                    case "3":
                        Console.WriteLine("Select one parametr from list:");
                        Console.WriteLine("Parametr 1 is max salary");
                        Console.WriteLine("Parametr 2 is min salary");
                        Console.WriteLine("Parametr 3 is average age of employees");

                        break;
                    case "4":
                        Console.WriteLine("Select user by department");
                        /*Employee.SelectDepartment();*/
                        break;
                    case "5":
                        Console.WriteLine("Select user by name");

                        break;
                }
                Console.WriteLine("For ending the program enter the 'end', for continuing press 'enter'");
                string EndAction = Console.ReadLine();
                if (EndAction == "end")
                {
                    break;
                }
            }
            Console.WriteLine("The program is ended");
        }
    }

    class PersonAttribute
    {
        public string Name;
        public string Age;
        public string Salary;
        public string Department;


        public static PersonAttribute AddEmployees()
        {

            PersonAttribute Employee = new PersonAttribute(); //Creation of new object "Employee"

            Console.WriteLine($"Enter Employees name: ");
            Employee.Name = Console.ReadLine();
            Console.WriteLine($"Enter Employees Age: ");
            Employee.Age = Console.ReadLine();
            Console.WriteLine($"Enter Employees Salary: ");
            Employee.Salary = Console.ReadLine();
            Console.WriteLine($"Enter Employees Department: ");
            Employee.Department = Console.ReadLine();

            return Employee;
        }

        //List                List Name
        public static void SelectAllEmployees(List<PersonAttribute> PersonsList) //Transfer method from up 
        {
            foreach (var items in PersonsList)
            {
                Console.WriteLine($"{items.Name}, {items.Age}"); //Use string for itemize "items" in list
            }
        }
    }


    /*
   public void SelectDepartment()
    {

    }
        public void OptionList()
        {
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    double MaxSalary = Math.Max(salary1, Math.Max(salary2, salary3));
                    Console.WriteLine($"Max salary is");
                    break;
                case "2":
                    double MinSalary = Math.Min(salary1, Math.Min(salary2, salary3));
                    Console.WriteLine($"Max salary is");
                    break;
                case "3":
                    int AvarageAge = (age1 + age2 + age3) / 3;
                    Console.WriteLine($"average age of employees is");
                    break;
                default:
                    Console.WriteLine("You enter incorrect value");
                    break;
            }
        }
*/
}
