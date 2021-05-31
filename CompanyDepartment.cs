using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskBlock4
{
    public class CompanyDepartment
    {
        List<Person> PersonsList = new List<Person>();
        SalaryRate salaryRate = new SalaryRate();
        public void SelectDepartment()
        {
            Console.WriteLine("Enter a department which you wanna find");
            var departmentName = Console.ReadLine();
            //List name "Where" selection attribute(LINQ) shifting to lower for any search variants contains value in list  convert to list for using foreach
            var selecteDepartment = PersonsList.Where(attr => attr.Department.ToLower().Contains(departmentName.ToLower())).ToList();
            //Loop for selecting from list
            selecteDepartment.ForEach(department => Console.WriteLine($"Department : {department.Department}, Name : {department.Name}"));
        }

        public void SelectEmployeesWorkHour()
        {
            if (PersonsList.Count == 0)
            {
                Console.WriteLine("The list is empty add at least one user");
            }
            else
            {
                foreach (var items in PersonsList)
                {
                    Console.WriteLine($"Name : {items.Name}, Work Hours : {items.Hours}"); //Use string for itemize "items" in list
                }
            }
        }

        public void UpdateHours()
        {
            Console.WriteLine("Enter a department which you wanna add salary");
            var departmentName = Console.ReadLine();
            //List name "Where" selection attribute(LINQ) shifting to lower for any search variants contains value in list  convert to list for using foreach
            var departmentSalary = PersonsList.Where(attr => attr.Department.ToLower().Contains(departmentName.ToLower())).ToList();
            departmentSalary.ForEach(department => Console.WriteLine($"Department : {department.Department}"));
            //Loop for selecting from list
            Console.WriteLine("Enter the hour value for staff");
            var quantityHours = Convert.ToDouble(Console.ReadLine());
            foreach(Person p in departmentSalary)
            {
                p.Hours = quantityHours;
            }
        }

        public void UpdateRate()
        {
            //input via console
            Console.WriteLine("Input rate for Boss");
            salaryRate.BossRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input rate for Acountant");
            salaryRate.AcountantRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input rate for Employee");
            salaryRate.EmployeeRate = Convert.ToDouble(Console.ReadLine());
        }


        private void BuildEmployee(Person employee)
        {
            Console.WriteLine($"Enter Employees name: ");
            employee.Name = Console.ReadLine();

            while (employee.Age != Double.NaN)
            {
                try
                {
                    Console.WriteLine($"Enter Employees Age: ");
                    employee.Age = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine($"You entered not a NAN value, try again");
                }
            }
            PersonsList.Add(employee);
        }

        public void AddEmployee()
        {
            Console.WriteLine($"Select Department from list: 1-Eployee, 2-Accontant, 3-Boss");
            string newPersonAttr = Console.ReadLine();
            Person employee;

            switch (newPersonAttr)
            {
                case "1":
                    {
                        Console.WriteLine("Employee department");
                        employee = new Employee(salaryRate); //Creation of new object "Employee"
                        BuildEmployee(employee);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Accountant department");
                        employee = new Accountant(salaryRate);
                        BuildEmployee(employee);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Boss department");
                        employee = new Boss(salaryRate);
                        BuildEmployee(employee);
                        break;
                    }
                default: break;
            }
        }

        public void OptionList()
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

        public void SelectUserByName()
        {
            Console.WriteLine("Enter a name for the user which you wanna find");
            var userName = Console.ReadLine();
            var selectedUsers = PersonsList.Where(attr => attr.Name.ToLower().Contains(userName.ToLower())).ToList();
            selectedUsers.ForEach(user => Console.WriteLine($"Name: { user.Name}, Department: { user.Department}, Age: { user.Age}, Salary: { user.Salary}, Work Hours : {user.Hours}"));

        }

        //List           List Name
        public void SelectAllEmployees() //Transfer method from up 
        {
            if (PersonsList.Count == 0)
            {
                Console.WriteLine("The list is empty add at least one user");
            }
            else
            {
                foreach (var items in PersonsList)
                {
                    Console.WriteLine($"Name : {items.Name}, Department : {items.Department}, Age : {items.Age}, Salary : {items.Salary}, Work Hours : {items.Hours}"); //Use string for itemize "items" in list
                }
            }
        }
    }
}
