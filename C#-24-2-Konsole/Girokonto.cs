using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal class Girokonto : Konto
    {
        private double _limit;

        public Girokonto(int accountID, double amount, double limit) : base(accountID, amount)
        {
            _limit = limit;
        }

        public override void Deposit(int amount)
        {
            _limit += amount;
        }

        public override void Payment(int money)
        {
            if(_amount - money < _limit)
            {
                throw new ArgumentOutOfRangeException("Durch die Transaktion würde der Kontostand unter das Limit fallen");
            }
            _amount -= money;
        }

    }
}
