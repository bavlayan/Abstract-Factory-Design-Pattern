using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class WolksvagenFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Wolksvagen();
        }
    }
}
