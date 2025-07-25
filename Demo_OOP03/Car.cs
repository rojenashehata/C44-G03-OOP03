using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

       public Car()
        {

        }
      
      //first begin with  ⬇⬇⬇⬇⬇⬇⬇⬇
        public Car(int id)
        {
            Id = id;
        }

        //then ⬇⬇⬇⬇⬇⬇⬇⬇
        public Car(int id, string model) : this(id)
        {
          //  Id = id; 
            Model = model;
        }

        //finally ⬇⬇⬇⬇⬇⬇⬇⬇
        public Car(int id, string model, int speed) : this(id, model)
        {

            //Id = id;
            //Model = model;
            Speed = speed;
        }
    }
}
