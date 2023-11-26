using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module12
{
    public class Race
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            car.Finished += Car_Finished;
            cars.Add(car);
        }

        public void Start()
        {
            Console.WriteLine("Гонка началась!");
            while (cars.Any())
            {
                foreach (var car in cars.ToList())
                {
                    car.Drive();
                    Console.WriteLine($"{car.Name} на расстоянии {car.Distance}");
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void Car_Finished(object sender, EventArgs e)
        {
            var car = sender as Car;
            Console.WriteLine($"{car.Name} финишировал!");
            cars.Remove(car);
        }
    }

}
