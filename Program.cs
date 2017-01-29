using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory firstFactory = new Factory(new MercedesFactory());
            firstFactory.CreateCar();

            Console.WriteLine();

            Factory secondFactory = new Factory(new WolksvagenFactory());
            secondFactory.CreateCar();

            Console.ReadLine();
        }
    }
}
