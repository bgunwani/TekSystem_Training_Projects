/*using System;

namespace CSharp_Polymorphism_Fundamentals
{
    abstract class ABCBank
    {
        public void welcomeMessage()
        {
            Console.WriteLine("Welcome to ABC Bank!!");
        }
        protected abstract void openAccount();
        public abstract void closeAccount();
    }
    abstract class BankAccount : ABCBank
    {
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }
    class SavingAccount : BankAccount
    {
        public override void balance()
        {
            Console.WriteLine("Balance in Saving Acocunt.");
        }

        public override void closeAccount()
        {
            Console.WriteLine("Close Saving Account.");
        }

        public override void deposit()
        {
            Console.WriteLine("Deposit in Saving Account.");
        }

        public override void openAccount()
        {
            Console.WriteLine("Open Saving Account.");
        }

        public override void withdraw()
        {
            Console.WriteLine("Withdrawal from Saving Account.");
        }
    }


    class AbstractClassesExample
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount();
            savingAccount.welcomeMessage();
            savingAccount.openAccount();
            savingAccount.deposit();
            savingAccount.withdraw();
            savingAccount.balance();
            savingAccount.closeAccount();
        }
    }
}
*/