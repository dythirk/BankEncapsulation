namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            double transaction = 0;
            BankAccount account = new BankAccount();

            string choice = "0";

            while ((choice != "1") && (choice != "2") && (choice != "3") && (choice != "4"))    // Filtering responses for menu
            {
                Console.WriteLine("\nPlease enter your choice:");
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Deposit Money");
                Console.WriteLine("3: Withdraw Money");
                Console.WriteLine("4: Exit\n");

                choice = Console.ReadLine();
            }

            while (choice != "4")   // Executing repeating menu (if 4 was chosen, menu is bypassed and program terminates)
            {
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Balance");
                            Console.WriteLine($"You have {account.GetBalance()} dollars.");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Deposit");
                            Console.WriteLine("Please enter amount to deposit:");
                            var canParse = double.TryParse(Console.ReadLine(), out transaction);
                            while (canParse == false)
                            {
                                Console.WriteLine("Please enter a valid amount:");
                                canParse = double.TryParse(Console.ReadLine(), out transaction);
                            }
                            account.Deposit(transaction);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Withdrawl");
                            Console.WriteLine("Please enter amount to withdraw:");
                            var canParse = double.TryParse(Console.ReadLine(), out transaction);
                            while (canParse == false)
                            {
                                Console.WriteLine("Please enter a valid amount:");
                                canParse = double.TryParse(Console.ReadLine(), out transaction);
                            }
                            account.Withdraw(transaction);
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Exiting");
                            break;
                        }
                }

                Console.WriteLine("\nPlease enter your choice:");
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Add Money");
                Console.WriteLine("3: Withdraw Funds");
                Console.WriteLine("4: Exit\n");

                choice = Console.ReadLine();
            }
        }
    }
}
