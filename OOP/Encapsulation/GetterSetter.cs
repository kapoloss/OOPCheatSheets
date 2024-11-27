using System;

namespace Encapsulation
{
    public class GetterSetter
    {
        //Bu metodlar, verilerin okuma ve yazma işlemlerini güvenli ve kontrollü hale getirir.
        //Getter metodu, bir değişkenin değerini dış dünyaya sunarken;
        //Setter metodu, dışarıdan verilen değeri değişkene atamadan önce belirli kontroller yapar.
    }
    
    public class BankAccount
    {
        private decimal balance;

        public decimal GetBalance()
        {
            return balance;
        }

        public void SetBalance(decimal amount)
        {
            if (amount >= 0)
            {
                balance = amount;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
            }
        }
    }
}