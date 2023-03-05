using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism_Fundamentals
{
    interface IManageBank
    {
        void openAccount();
        void closeAccount();
    }
    interface IBankAccount
    {
        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance { get; }
    }

    public class SavingAccount : IBankAccount, IManageBank
    {
        private decimal _balance;
        private decimal _perDayLimit;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else if (_perDayLimit + amount > 5000) //limit is 5000
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public override string ToString()
        {
            return String.Format("Saving Account Balance = {0,6:C}", _balance);
        }

        public void openAccount()
        {
            Console.WriteLine("Opening Saving Account.");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Saving Account.");
        }
    }

    public class CurrentAccount : IBankAccount, IManageBank
    {
        private decimal _balance;
        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (_balance < amount)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            else
            {
                _balance -= amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));

                return true;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public override string ToString()
        {
            return String.Format("Current Account Balance = {0,6:C}", _balance);
        }
        public void openAccount()
        {
            Console.WriteLine("Opening Current Account.");
        }

        public void closeAccount()
        {
            Console.WriteLine("Closing Current Account.");
        }
    }
    class InterfaceExample
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            CurrentAccount currentAccount = new CurrentAccount();

            savingAccount.openAccount();
            savingAccount.Deposit(200);
            savingAccount.Withdraw(100);
            savingAccount.ToString();
            savingAccount.closeAccount();

            currentAccount.openAccount();
            currentAccount.Deposit(500);
            currentAccount.Withdraw(600);
            currentAccount.Withdraw(200);
            currentAccount.ToString();
            currentAccount.closeAccount();

            Console.ReadLine();
        }
    }
}
