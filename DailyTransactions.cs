using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practice_StaticClass_Methods_Constructor
{
    internal class DailyTransactions
    {
        static List<Transaction> _transactions;

        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
        }

        public static void AddTransaction(string name, double amount)
        {
            
            _transactions.Add(new Transaction(name, amount));
        }
        public static double CalculateTotal()
        {
            double total = 0;
            foreach (Transaction transaction in _transactions)
            {
                total += transaction.Amount;
            }
            double final = total * (1 + BusinessInfo.TaxAmount);
            return final;
        }
        public static void Display()
        {
            foreach (Transaction transaction in _transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
            Console.WriteLine($"Here is the total: {CalculateTotal().ToString("c")}");
        }
    }
}
