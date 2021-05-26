using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskBlock4
{
    public class EmploeesList : Person
    {
        public static void SelectUserByName(List<Employees> PersonsList)
        {
            Console.WriteLine("Enter a name for the user which you wanna find");
            var userName = Console.ReadLine();
            var selectedUsers = PersonsList.Where(attr => attr.Name.ToLower().Contains(userName.ToLower())).ToList();
            selectedUsers.ForEach(user => Console.WriteLine($"Name: { user.Name}, Department: { user.Department}, Age: { user.Age}, Salary: { user.Salary}, Work Hours : {user.Hours}"));

        }

                                             //List           List Name
        public static void SelectAllEmployees(List<Employees> PersonsList) //Transfer method from up 
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
