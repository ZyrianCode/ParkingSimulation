using ParkingSimulation.Zyrian.Objects.ParkingParticipants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects
{
    public class Parking
    {
        private List<Car> _cars = new();
        private ParkingStorage _parkingStorage;
        public void TakeParkingStorage(ParkingStorage parkingStorage) => _parkingStorage = parkingStorage;
        public void TakeCar(Car car) => _cars.Add(car);
        public ParkingStorage GetParkingStorage() => _parkingStorage;
    }
}
