using ParkingSimulation.Zyrian.Objects.ParkingParticipants.BalanceComponents;
using ParkingSimulation.Zyrian.Objects.ParkingParticipants.UserComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects.ParkingParticipants
{
    public class CarUser
    {
        private Car _car;
        private Parking _parking;
        public Balance Balance = new UserBalance();

        public CarUser(Car car)
        {
            _car = car;
        }
        public int Age { get; set; }
        public string FirstName { get; set; }

        public void ArriveToParking(Parking parking) => _parking = parking;
        public Money PayToPark(int cost) => Balance.WithdrawMoney(cost);
        public Car ParkCarToParking() => _car;
    }
}
