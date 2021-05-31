using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskBlock4
{
    public class MainClass : CompanyDepartment
    {
        CompanyDepartment manager = new CompanyDepartment();
        //;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Select the action (the value):");
                Console.WriteLine("1 - Add new employee");
                Console.WriteLine("2 - Select all employees");
                Console.WriteLine("3 - Select user by parametr from list (Max and Min salary, avarage age of employees )");
                Console.WriteLine("4 - Select user by department");
                Console.WriteLine("5 - Select user by name");
                Console.WriteLine("6 - Select user work hours");
                Console.WriteLine("7 - Add salary for user (based on hours)");
                Console.WriteLine("8 - Update rate");
                string SelectAction = Console.ReadLine();
                switch (SelectAction)
                {
                    case "1":
                        Console.WriteLine("Add new employee");
                        manager.AddEmployee();
                        break;
                    case "2":
                        Console.WriteLine($"Employees list");
                        //Select "PersonsList" for itemize
                        manager.SelectAllEmployees(); //Use "PersonAttribute" for itemize
                        break;
                    case "3":
                        Console.WriteLine("Select one parametr from list: ");
                        Console.WriteLine("Parametr 1 is max salary");
                        Console.WriteLine("Parametr 2 is min salary");
                        Console.WriteLine("Parametr 3 is average age of employees");
                        manager.OptionList();
                        break;
                    case "4":
                        manager.SelectDepartment();
                        break;
                    case "5":
                        manager.SelectUserByName();
                        break;
                    case "6":
                        manager.SelectEmployeesWorkHour();
                        break;
                    case "7":
                        manager.UpdateHours();
                        break;
                    case "8":
                        manager.UpdateRate();
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

        static void Main(string[] args)
        {
            new MainClass().Start();
        }
    }
}
