using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            race.AddCar(new SportsCar("Спортивный автомобиль"));
            race.AddCar(new Sedan("Легковой автомобиль"));
            race.AddCar(new Truck("Грузовик"));
            race.AddCar(new Bus("Автобус"));

            race.Start();
        }
    }
}
