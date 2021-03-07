﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_2
{
    class Savings_Account: account
    {
        public override void ShowAccountInformation()
        {

            base.ShowAccountInformation();
        }
        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance && (Balance - amount > 0))
            {
                Balance -= amount;
                TransactionIncrement();
            }
            else
            {
                Console.WriteLine("Sorry The Amount Couldnt Be Withdrawn..");

            }



        }





    }
}
