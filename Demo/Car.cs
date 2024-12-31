using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        // Id
        #region Attributes

        private int id; // 4
        private int speed;  // 4
        private string model;   // 8

        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        #endregion

        //public String Address {get; set;} // Prop

        // CLR Will Generate Parameterless Constructor
        // This Constructor Do Nothing

        // CTOR

        // Public Car
        //{
        // Id = default;
        // Model = default;
        // Speed = default;
        //}


        public override string ToString()
        {
            return $"Id:{Id} :: Speed: {Speed} :: Mode: {Model}";
        }


        public Car(int id, int speed, string model) : this(id, speed)
        {
            // Id = id;
            //Speed = speed;
            Model = model;

        }




        public Car(int id, int speed) : this(id)
        {
            Id = id;
            Speed = speed;
            Model = model;
        }

        public Car(int id)
        {
            Id = id;

        }

        public Car(string model, int speed)
        {
            Speed = speed;
            Model = model;
        }
    }


}
