using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee : IComparable<Employee>
    {
        private string id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hiringDate;
        private char gender;

        // Constructor  
        public Employee(string id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hiringDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HiringDate = hiringDate;
            Gender = gender;
        }

        // Properties  
        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public SecurityLevel SecurityLevel
        {
            get => securityLevel;
            set => securityLevel = value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        public HiringDate HiringDate
        {
            get => hiringDate;
            set => hiringDate = value;
        }

        public char Gender
        {
            get => gender;
            set
            {
                if (value != 'M' && value != 'F')
                {
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).");
                }
                gender = value;
            }
        }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, " +
                   $"Hire Date: {HiringDate}, Gender: {Gender}";
        }


        public int CompareTo(Employee other)
        {
            return this.HiringDate.Year != other.HiringDate.Year ?
                this.HiringDate.Year.CompareTo(other.HiringDate.Year) :
                this.HiringDate.Month != other.HiringDate.Month ?
                this.HiringDate.Month.CompareTo(other.HiringDate.Month) :
                this.HiringDate.Day.CompareTo(other.HiringDate.Day);
        }
    }
}
