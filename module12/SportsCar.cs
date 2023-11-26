using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module12
{
    public class SportsCar : Car
    {
        public SportsCar(string name) : base(name)
        {
            Speed = new Random().Next(10, 20);
        }
    }

    public class Sedan : Car
    {
        public Sedan(string name) : base(name)
        {
            Speed = new Random().Next(5, 15);
        }
    }

    public class Truck : Car
    {
        public Truck(string name) : base(name)
        {
            Speed = new Random().Next(3, 10);
        }
    }

    public class Bus : Car
    {
        public Bus(string name) : base(name)
        {
            Speed = new Random().Next(4, 12);
        }
    }

}
