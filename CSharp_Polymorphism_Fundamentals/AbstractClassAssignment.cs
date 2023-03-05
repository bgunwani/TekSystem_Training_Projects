/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Polymorphism_Fundamentals
{
    public abstract class BankAccount
    {
        public abstract bool Deposit(decimal amount);
        public abstract bool Withdraw(decimal amount);
        decimal Balance { get; }
    }
    public class SavingAccount : BankAccount
    {
        private decimal _balance;
        private decimal _perDayLimit;
        public override bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public override bool Withdraw(decimal amount)
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
    }
    public class CurrentAccount : BankAccount
    {
        private decimal _balance;
        public override bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }
        public override bool Withdraw(decimal amount)
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
    }
    class AbstractClassAssignment
    {
        static void Main(string[] args)
        {
            BankAccount savingAccount = new SavingAccount();
            BankAccount currentAccount = new CurrentAccount();

            savingAccount.Deposit(200);
            savingAccount.Withdraw(100);
            savingAccount.ToString();

            currentAccount.Deposit(500);
            currentAccount.Withdraw(600);
            currentAccount.Withdraw(200);
            currentAccount.ToString();

            Console.ReadLine();
        }
    }
}
*/