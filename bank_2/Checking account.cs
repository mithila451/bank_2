using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_2
{
    class Checking_account:account
    {

        public override void ShowAccountInformation()
        {
            base.ShowAccountInformation();
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                TransactionIncrement();

            }

        }
    }
}
