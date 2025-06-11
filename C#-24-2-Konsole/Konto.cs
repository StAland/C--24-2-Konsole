using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__24_2_Konsole
{
    internal abstract class Konto

    {
        private int _accountID;
        protected double _amount;

        public Konto(int accountID, double amount)
        {
            _accountID = accountID;
            _amount = amount;
        }

        public abstract void Deposit(int amount);


        public virtual void Payment(int amount)
        {
            _amount -= amount;
        }
    }
}
