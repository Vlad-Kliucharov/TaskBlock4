using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskBlock2
{
    public class CompanyDepartment : Employees
    {   public static void SelectDepartment(List<Employees> PersonsList)
        {
            Console.WriteLine("Enter a department which you wanna find");
            var departmentName = Console.ReadLine();
            //List name "Where" selection attribute(LINQ) shifting to lower for any search variants contains value in list  convert to list for using foreach
            var selecteDepartment = PersonsList.Where(attr => attr.Department.ToLower().Contains(departmentName.ToLower())).ToList();
            //Loop for selecting from list
            selecteDepartment.ForEach(department => Console.WriteLine($"Department : {department.Department}, Name : {department.Name}"));

        }

        /*        public static void SelectDepartment(List<PersonAttribute> PersonsList)
        {
            //List name  OrderBy(LINQ)             convert to list for using foreach
            PersonsList.OrderBy(i => i.Department).ToList().ForEach(y => Console.WriteLine($"Departmnet : {y.Department}"));

        }*/
    }
}
