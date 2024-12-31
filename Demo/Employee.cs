using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Employee
    {
        private int id;
        private string name; // null
        private double salary;
        private string address;


        // Address

        #region Apply Encapsulation User Setter Getter Method
        //// Apply Encapsulation User Setter Getter Method

        //// Setter
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //// Getter
        //public int GetId()
        //{
        //    return id; 
        //}

        //// Setter Name

        //public void SetName(string name)
        //{
        //    if(name.Length >= 8 && name.Length <= 20)
        //        //this.name = name;
        //    this.name = new string(name);
        //}

        //// Getter Name
        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary(double salary)
        //{
        //    if(salary > 0)
        //    this.salary = salary;
        //}

        //public double GetSalary()
        //{
        //    return salary;
        //}


        //public Employee(int id, string name, double salary)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //}

        #endregion


        //Apply Encapsulation User Properties!: [Recommended]
        // 1. Full Property

        // Id
        public int Id
        {
            // set
            // get
            set
            {
                id = value;
            }
            get 
            {
                return id;
            }
        }

        // Name
        public string Name
        {
            // set
            // get
            set
            {
                if (name.Length >= 8 && name.Length <= 20)
                    Name = value;
            }
            get
            {
                return Name;
            }
        }

        // Salary
        public double Salary
        {
            // set
            // get
            set
            {
                if (salary > 0)
                    Salary = value;
            }
            get
            {
                return Salary;
            }
        }


        // Adress

        //public string Address
        //{
        //    // set
        //    // get
        //    set
        //    {
        //       address = value;
        //    }
        //    get
        //    {
        //        return address;
        //    }
        //}



        // 2. Automatic Property

        public string Address { set; get; }

        








        // 3. Special Property [Indexer]



        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id: {id} :: Name:{ name} :: Salary: { salary}";
        //}

    }
}