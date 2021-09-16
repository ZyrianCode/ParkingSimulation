using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSimulation.Zyrian.Objects.ParkingParticipants.BalanceComponents
{
    public abstract class Balance
    {
        private Money _money = new();
        public void SetBalance(int costToRecive) => _money.Count = costToRecive;
        public void AddBalance(int costToAdd) => _money.Count += costToAdd;
        public string GetBalance() => _money.Count.ToString();
        public Money WithdrawMoney(int costToWithdraw)
        {
            _money.Count -= costToWithdraw;
            Money newAmount = new Money();
            newAmount.Count = costToWithdraw;
            return newAmount;
        }
    }
}
