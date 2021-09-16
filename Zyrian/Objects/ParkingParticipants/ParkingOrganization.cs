using ParkingSimulation.Zyrian.Objects.ParkingParticipants.ParkingOrganizationComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects.ParkingParticipants
{
    public class ParkingOrganization
    {
        private ParkingStorage parkingStorageToGet;
        private List<ParkingStorage> _parkingStorages = new();
        private Reglament _reglament = new();

        public void FillOrganization(ParkingStorage storage) => _parkingStorages.Add(storage);

        public ParkingStorage GetStorage()
        {
            for (int i = 0; i < 1; i++){
                parkingStorageToGet = _parkingStorages[i];
            }
            return parkingStorageToGet;
        }

        public Reglament GetReglament() => _reglament;
        public ParkingOrganization GetOrganization() => this;
    }
}
