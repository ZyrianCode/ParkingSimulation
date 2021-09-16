using ParkingSimulation.Zyrian.Objects.CarComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects
{
    public class Car
    {
        private CarInfo _info;

        public Car(CarInfo info)
        {
            _info = info;
        }

        public CarInfo GetCartInfo() => _info;
    }
}
