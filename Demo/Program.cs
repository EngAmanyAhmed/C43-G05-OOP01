namespace Demo
{
    internal class Program
    {

        // 1. Class
        // 2. Struct
        // 3. Interface
        // 4. Enum

        static void Main()
        {

            #region Struct
            
            // Struct : Value Type : Stak


            // Employee
            // Id, Name, Salary


            // Point

            Point P01;
            //Declare For object From Type 'Point'
            // P01 ;Object
            // Allocate Uninitialized 8 Bytes at STACK

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X = 12;
            //P01.Y = 12;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            // P01 = new Point(x: 1, y: 2);
            // new : Used For Select The Constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Console.WriteLine(P01); // C_OOP01G07.Point
            //P01.PrinPoint();

            //Console.WriteLine(P01.ToString()); // C_OOP01G07.Point
            //Console.WriteLine(P01); // C_OOP01G07.Point 
            #endregion

            #region OOP Overview

            // OOP  : Object Oriented Programming
            // Programming Paradigm
            // OOP  : The Paradigm Use For Build Any Business

            // Class : Blueprint Of The Object
            // Object: Specific Instance From Class

            // 4 Pillars
            // ================
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Ploymorphism
            // 4. Abstraction
            // 
            #endregion

            #region 1. Encapsulation
            
            // 1. Encapsulation:
            // Class Or Struct
            // Seperate The Data(Attributes) Definition From Its Use

            // Employee
            // Id Name salary

            // 1. End User Access data itself
            // 2. No Data Validation
            // 3. No Read Only Filed

            // Apply Encapsulation:
            // 1. Make All Data(Attributes) Private
            // 2. Access Data Through:
            // 2.1. Setter Getter Method
            // 2.2. Properties

            //Employee E01 = new Employee(id: 1, name: "Ahmed", salary: 12000);
            //Console.WriteLine(E01);

            //// Id : Read Only Attributes

            //E01.GetId();

            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 12000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);



            //E01.SetId(1);
            //E01.SetName("Ahmed");
            //E01.SetSalary(-12000);

            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E81.Getname());
            //Console.WriteLine(E01.Getsalary());

            Employee E01 = new Employee();

            // E01.Id = 12;
            E01.Name = "Ahmed Amin";
            E01.Salary = 12000;
            E01.Address = "Cairo";

            Console.WriteLine(E01.Id);
            Console.WriteLine(E01.Name);
            Console.WriteLine(E01.Salary);
            Console.WriteLine(E01.Address);
            #endregion

            #region Indexer

            // Indexer : Special Property
            //          1. Named this

            // Phonebook :

            //PhoneBook phoneBook = new PhoneBook(size: 3);

            //phoneBook.Addperson(name: "Ahmed", number: 111, Index: 0);
            //phoneBook.Addperson(name: "Ali", number: 222, Index: 1);
            //phoneBook.Addperson(name: "Omar", number: 333, Index: 2);

            //Console.WriteLine(phoneBook.GetNumber(name:"Ahmed"));

            //phoneBook.UpdateNumber(name: "Ahmed", newNumber: 999);

            //Console.WriteLine(PhoneBook[name:"Ahmed"]); // long

            //PhoneBook[name:"Ahmed"] = 11111; // long

            #endregion

            #region Class


            // Class : Reference Types : HEAP

            // Car : Id Model Speed

            Car C01;
            // Decalre For Refernce (Pointer) From Type 'Car'
            // C81  : Can Refer To Object From Type 'Car' Or Any Class Inherited From Car
            // C01  : Refer To Null

            //Console.WriteLine(C01);

            // 8 Bytes Will Be Allocated At STACK For The Reference 'C01'
            // 0 Bytes Will Be Allocated At HEAP

            //C01 = new Car(1);
            //C01 = new Car(1, 200);
            //C01 = new Car(id: 1, speed: 200, model: "XYZ"); 

            //new
            // 1. Allocate The Number Of Required Bytes At HEAP For The Object
            //2. Initailized The Allocated Bytes With The Default Value Of The Datatypes
            //3. Call User Defined Constructor if Exists
            // 4. Assign The Object To The Reference

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);

            //Console.WriteLine(C01);














            #endregion

        }
    }
}
