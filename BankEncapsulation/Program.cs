namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string choice = "0";

            while ((choice != "1") && (choice != "2") && (choice != "3") && (choice != "4")) 
            {
                Console.WriteLine("Please enter your choice:");
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Add Money");
                Console.WriteLine("3: Withdraw Funds");
                Console.WriteLine("4: Exit");

                choice = Console.ReadLine();
                Console.WriteLine($"You chose {choice}");



            }

            while (choice != "4")
            {



                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Balance");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Add");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Subtract");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Leave");
                            break;
                        }


                }

                Console.WriteLine("Please enter your choice:");
                Console.WriteLine("1: Check Balance");
                Console.WriteLine("2: Add Money");
                Console.WriteLine("3: Withdraw Funds");
                Console.WriteLine("4: Exit");

                choice = Console.ReadLine();
            }

 

        }
    }
}
