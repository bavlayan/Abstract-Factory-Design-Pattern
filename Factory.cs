using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class Factory
    {
        private CarFactory carFactory;
        private Car car;

        public Factory(CarFactory carFactory)
        {
            this.carFactory = carFactory;
            car = carFactory.CreateCar();
        }

        public void CreateCar()
        {
            Console.WriteLine("--------------------------------------");            
            car.CreateEngine();
            car.CreateHeadLight();
            car.CreateWheel();
            Console.WriteLine("---------CAR HAS BEEN CREATED---------");
        }
    }
}
