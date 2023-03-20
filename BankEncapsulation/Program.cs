using System.Reflection.Metadata.Ecma335;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


            var juansAccount = new BankAccount();
            Console.WriteLine($"Welcome! Thank you for banking with us. Your account balance is ${juansAccount.GetBalance()}.");
            var answer = "Y";
            while (answer != "N")
            {
                Console.WriteLine("Would you like to deposit?\nType 'Y' if yes.\nType 'N' if no.");
                answer = Console.ReadLine().ToUpper();
                switch (answer)
                {
                    case "Y":
                        Console.WriteLine("How much money would you like to deposit");
                        var amountDeposit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"\nYou have ${juansAccount.Deposit(amountDeposit)} in your bank account");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "N":
                        Console.WriteLine($"Thank you for banking with us. You final balance is ${juansAccount.GetBalance()}.");
                        break;
                }
            }
        }
    }
}
