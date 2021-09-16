using ParkingSimulation.Zyrian.Objects.ParkingParticipants.BalanceComponents;
using ParkingSimulation.Zyrian.Objects.ParkingParticipants.ParkingStorageComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects.ParkingParticipants
{
    public class ParkingStorage
    {
        private ParkingOrganization _parkingOrganization;
        private Balance _storageBalance = new StorageBalance();

        public void SetOrganization(ParkingOrganization parkingOrganization) => _parkingOrganization = parkingOrganization;

        public bool CompareMoney(Money money) =>
            _parkingOrganization.GetReglament().ParkingCost.Equals(money.Count) ? GivePermission(): GiveNoPermission();

        public bool GivePermission() => true;
        public bool GiveNoPermission() => false;

        public void TakeMoney(Money money) => _storageBalance.SetBalance(money.Count);
    }
}
