namespace Prog124_Practice_StaticClass_Methods_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BusinessInfo._businessName.ToString());
            DailyTransactions.AddTransaction("Coffee", 2);
            DailyTransactions.AddTransaction("Panda", 200000);
            DailyTransactions.AddTransaction("Camping tent", 20);
            DailyTransactions.AddTransaction("Stove", 60);
            DailyTransactions.AddTransaction("Gitar", 30);
            DailyTransactions.Display();
        }
    }
}