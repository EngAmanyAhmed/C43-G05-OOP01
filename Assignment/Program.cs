using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Assignment
{

        public enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA,     SecurityOfficer
        }
       


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01

            // 1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the coordinates of the first point (X Y): ");

            //var firstPointInput = Console.ReadLine().Split(' ');
            //Point point1 = new Point(double.Parse(firstPointInput[0]), double.Parse(firstPointInput[1]));


            //Console.WriteLine("Enter the coordinates of the second point (X Y): ");

            //var secondPointInput = Console.ReadLine().Split(' ');
            //Point point2 = new Point(double.Parse(secondPointInput[0]), double.Parse(secondPointInput[1]));


            //double distance = point1.Distance(point2);


            //Console.WriteLine($"The distance between P1({point1.X}, {point1.Y}) and P2({point2.X}, {point2.Y}) is: {distance}");

            #endregion


            #region Problem 02

            // 2.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1} (Name Age): ");
            //    var personInput = Console.ReadLine().Split(' ');
            //    persons[i] = new Person(personInput[0], int.Parse(personInput[1]));
            //}

            //Person oldestPerson = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > oldestPerson.Age)
            //    {
            //        oldestPerson = person;
            //    }
            //}
            //Console.WriteLine($"Oldest Person: {oldestPerson.Name}, Age: {oldestPerson.Age}");

            #endregion


            #region Problem 03

            // 3. Design and implement a Class for the employees in a company:
            /*Notes:
                ●	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
                ●	We need to restrict the Gender field to be only M or F[Male or Female]
                ●	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
                ●	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].
            */


            Employee[] empArr = new Employee[3];

            // Initialize Employees  
            empArr[0] = new Employee("E001", "Alice", SecurityLevel.DBA, 80000, new HiringDate(15, 5, 2020), 'F');
            empArr[1] = new Employee("E002", "Bob", SecurityLevel.Guest, 30000, new HiringDate(10, 3, 2021), 'M');
            empArr[2] = new Employee("E003", "Charlie", SecurityLevel.SecurityOfficer, 90000, new HiringDate(1, 1, 2019), 'M');

            // Print unsorted employees  
            Console.WriteLine("Employees before sorting:");
            foreach (var emp in empArr)
            {
                Console.WriteLine(emp);
            }

            // Sort employees based on hiring date  
            Array.Sort(empArr, (x, y) =>
            {
                // Count boxing and unboxing  
                int boxingCount = 0;
                int unboxingCount = 0;

                boxingCount++; // Boxing Employee reference for comparison  
                unboxingCount++; // Unboxing Employee reference for comparison  

                int result = x.CompareTo(y);
                return result;
            });

            // Print sorted employees  
            Console.WriteLine("\nEmployees after sorting by hire date:");
            foreach (var emp in empArr)
            {
                Console.WriteLine(emp);
            }
        }

        #endregion




    }
}