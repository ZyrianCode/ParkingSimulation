using ParkingSimulation.Zyrian.Objects;
using ParkingSimulation.Zyrian.Objects.CarComponents;
using ParkingSimulation.Zyrian.Objects.ParkingParticipants;
using System;

namespace ParkingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingOrganization parkingOrganization = new();
            ParkingStorage parkingStorage = new();
            parkingStorage.SetOrganization(parkingOrganization);

            parkingOrganization.FillOrganization(parkingStorage);
            Parking parking = new();

            parking.TakeParkingStorage(parkingOrganization.GetStorage());
            CarInfo carInfo = new();

            carInfo.BrandName = "Toyota";
            carInfo.ModelName = "Mark2";
            carInfo.Color = "Gray";
            

            Car car = new(carInfo);

            CarUser carUser = new(car);
            carUser.FirstName = "Dmitry";
            carUser.Age = 21;
            carUser.Balance.SetBalance(20000);

            carUser.ArriveToParking(parking);
            Console.WriteLine("Прибыл на парковку");

            parkingStorage = parking.GetParkingStorage();
            Console.WriteLine("Стораж подошёл");

            Money userMoney = carUser.PayToPark(500);

            Console.WriteLine("Клиент платит за парковку");

            if (parkingStorage.CompareMoney(userMoney))
            {
                parkingStorage.TakeMoney(userMoney);
                Console.WriteLine("Оплата прошла успешно, стораж забрал сумму и разрешил парковаться");

                parking.TakeCar(carUser.ParkCarToParking());
                Console.WriteLine("Машина припаркована");
            }
            
        }
        
    }
}
