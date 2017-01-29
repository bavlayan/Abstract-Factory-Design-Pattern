using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class MercedesFactory : CarFactory
    {
        public override Car CreateCar()
        {
            return new Mercedes();
        }
    }
}
