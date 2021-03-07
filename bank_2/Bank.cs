using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_2
{
    class Bank
    {
        private string bankName;
        private account[] myBank = new account[10];
        
        
        public string BankName
        {
            get { return this.bankName; }  set { this.bankName = value; }
        }
        public void AddAccount(account account)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].AutoacoountNumberGenarator();
                    myBank[i].ShowaccountInformation();
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Sorry account Couldnt Be Created!");

            }

        }

        public void Deleteaccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; myBank[i] != null; i++)
            {
                if(myBank[i].AccountNumber == accountNumber)
                {
                    while (myBank[i + 1] != null && i < myBank.Length)
                    {
                        myBank[i] = myBank[i + 1];
                        i++;

                    }
                    myBank[i] = null;
                    Console.WriteLine("account Deleted Successfully!");
                    flag = 1;
                    break;

                }






            }





        }

    }
}
