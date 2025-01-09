/* withdraw(int amountToWithdraw): This method will withdraw money from the balance and decrease the balance.
deposit(int amountToDeposit): This method will deposit money into the account.
viewBalance(): This method will display the current balance.
exit(): This will exit the application.
Initially, the balance is set to 1000 TL.
The user can:

Press -1 to exit.
Press 1 to withdraw money.
Press 2 to deposit money.
Press 3 to view the balance.

*/

using System;

static class Program
{
    static void Main()
    {
        int balance = 1000;
        int choice;

        do
        {
            Console.WriteLine("\nATM Menu:");
            Console.WriteLine("1 - Withdraw Money");
            Console.WriteLine("2 - Deposit Money");
            Console.WriteLine("3 - View Balance");
            Console.WriteLine("-1 - Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) // Withdraw Money
            {
                Console.Write("Enter amount to withdraw: ");
                int withdrawAmount = int.Parse(Console.ReadLine());
                if (withdrawAmount > balance)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                else
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"You withdrew {withdrawAmount} TL. Remaining balance: {balance} TL.");
                }
            }
            else if (choice == 2) // Deposit Money
            {
                Console.Write("Enter amount to deposit: ");
                int depositAmount = int.Parse(Console.ReadLine());
                balance += depositAmount;
                Console.WriteLine($"You deposited {depositAmount} TL. Current balance: {balance} TL.");
            }
            else if (choice == 3) // View Balance
            {
                Console.WriteLine($"Current balance: {balance} TL.");
            }
            else if (choice == -1) // Exit
            {
                Console.WriteLine("Exiting... Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        } while (choice != -1);
    }
}
