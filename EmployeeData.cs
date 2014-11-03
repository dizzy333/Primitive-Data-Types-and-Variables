using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class employeeData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Insert your age:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("What is your gender: m or f?");
            string gender = Console.ReadLine();
            Console.WriteLine("Write your personal ID number:");
            long idNUmber = long.Parse(Console.ReadLine());
            Console.WriteLine("Unique employee number (From 27560000 to 27569999)");
            uint employeeNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine("\nFirst name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID number: {4}\nUnique employee number: {5}", firstName, lastName, age, gender, idNUmber, employeeNumber);


        }
    }
}
