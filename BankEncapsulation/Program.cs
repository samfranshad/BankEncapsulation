namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();

            bool userWantsToContinue = true;

            do
            {
                Console.WriteLine("Thank you for choosing Shadwell Banking!\nPlease enter an option from the list below:\nCheck Balance\nDeposit Funds\nTransfer Funds");
                string optionSelection = Console.ReadLine();
                optionSelection.ToLower();

                if (optionSelection == "check balance")
                {
                    Console.WriteLine("Which balance would you like to check?\nSavings\nChecking");
                    string balanceSelection = Console.ReadLine();
                    balanceSelection.ToLower();

                    if (balanceSelection == "savings")
                    {
                        var savingsBalance = userAccount.GetSavingsBalance();
                        Console.WriteLine($"Your Savings account total is ${savingsBalance}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                   
                    }
                    else if (balanceSelection == "checking")
                    {
                        var checkingBalance = userAccount.GetCheckingBalance();
                        Console.WriteLine($"Your Checking account total is ${checkingBalance}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, would you like to try again? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                }
                else if (optionSelection == "deposit funds")
                {
                    Console.WriteLine("Which account would you like to deposit funds into?\nSavings\nChecking");
                    var depositSelection = Console.ReadLine();
                    depositSelection.ToLower();

                    if (depositSelection == "savings")
                    {
                        Console.WriteLine("How much would you like to deposit into your Savings account?");
                        double savingsDepositTotal = double.Parse(Console.ReadLine());
                        var savingsDeposit = userAccount.SavingsDeposit(savingsDepositTotal);
                        Console.WriteLine($"You have deposited ${savingsDepositTotal} into your Savings account. Your Savings account total is now ${userAccount.GetSavingsBalance()}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                    else if (depositSelection == "checking")
                    {
                        Console.WriteLine("How much would you like to deposit into your Checking account?");
                        double checkingDepositTotal = double.Parse(Console.ReadLine());
                        var checkingDeposit = userAccount.CheckingDeposit(checkingDepositTotal);
                        Console.WriteLine($"You have deposited ${checkingDepositTotal} into your Checking account. Your Checking account total is now ${userAccount.GetCheckingBalance()}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, would you like to try again? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }

                }
                else if (optionSelection == "transfer funds")
                {
                    Console.WriteLine("Where would you like to transfer funds?\nSavings to Checking\nChecking to Savings");
                    var transferSelection = Console.ReadLine();
                    transferSelection.ToLower();

                    if (transferSelection == "savings to checking")
                    {
                        Console.WriteLine("How much would you like to transfer to your Checking account?");
                        double transferToCheckingTotal = double.Parse(Console.ReadLine());
                        var transferToChecking = userAccount.TransferSavingsToChecking(transferToCheckingTotal);
                        Console.WriteLine($"You have transferred ${transferToCheckingTotal} from your Savings account to your Checking account. Your Checking account total is now ${userAccount.GetCheckingBalance()} and your Savings account total is now ${userAccount.GetSavingsBalance()}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                    else if (transferSelection == "checking to savings")
                    {
                        Console.WriteLine("How much would you like to transfer to your Savings account?");
                        double transferToSavingsTotal = double.Parse(Console.ReadLine());
                        var transfertoSavings = userAccount.TransferCheckingToSavings(transferToSavingsTotal);
                        Console.WriteLine($"You have transferred ${transferToSavingsTotal} from your Checking Account to your Savings account. Your Savings account total is now ${userAccount.GetSavingsBalance()} and your Checking account total is now ${userAccount.GetCheckingBalance()}.");
                        Console.WriteLine("Would you like to return to the menu? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, would you like to try again? Please enter Y or N.");
                        var userResponse = Console.ReadLine();
                        userResponse.ToLower();
                        if (userResponse == "y")
                        {
                            userWantsToContinue = true;
                        }
                        else if (userResponse == "n")
                        {
                            userWantsToContinue = false;
                        }
                    }
                }
            } while (userWantsToContinue == true);
        }
    }
}
