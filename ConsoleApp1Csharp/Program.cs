using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

class BankVariables
{
    public float balance = 0;
    public float numDeposit = 0;
    public string deposit = "";
    public float numWithdraw = 0;
    public string withdraw = "";
    public string option = "";
    public int numOption = 0;
}

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BankVariables bank;
            bank = new BankVariables();

            do
            {
                MainMenu();

                bank.option = Console.ReadLine();

                if (int.TryParse(bank.option, out bank.numOption))
                {

                    switch (bank.numOption)
                    {
                        case 1:
                            Console.WriteLine("Your balance is: " + bank.balance);
                            ClearScreen();
                            break;
                        case 2:
                            Console.WriteLine("Choose amount to deposit: ");
                            bank.deposit = Console.ReadLine();
                            if (float.TryParse(bank.deposit, out bank.numDeposit) && bank.numDeposit > 0 && bank.numDeposit < 2147483583) 
                            {
                                bank.balance += bank.numDeposit;
                                Console.WriteLine("You made a deposit of " + bank.numDeposit);
                                Console.WriteLine("Your new balance is: " + bank.balance);
                                ClearScreen();
                            } else
                            {
                                ErrorMessage();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Choose the amount to withdraw: ");
                            bank.withdraw = Console.ReadLine();
                            if (float.TryParse(bank.withdraw, out bank.numWithdraw))
                            {
                                if (bank.numWithdraw > 0 && bank.balance >= bank.numWithdraw) 
                                {
                                    bank.balance -= bank.numWithdraw;
                                    Console.WriteLine("You made a withdraw of " + bank.numWithdraw);
                                    Console.WriteLine("Your new balance is: " + bank.balance);
                                    ClearScreen();
                                } else
                                {
                                    Console.WriteLine("Opss... Your balance is insufficient for that withdraw.");
                                    ClearScreen();
                                }
                            } else
                            {
                                ErrorMessage();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Thanks for visiting the bank of California!");
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option!");
                            ClearScreen();
                            break;
                    }
                } else
                {
                    Console.WriteLine("Please enter only numbers!");
                    ClearScreen();
                }

            } while (bank.numOption != 4);
            
            Console.WriteLine("Exiting program in 5 seconds...");
            Thread.Sleep(5000);
        }
        static void MainMenu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("***********Bank of California***********");
            Console.WriteLine("****************************************");
            Console.WriteLine("\n");
            Console.WriteLine("1. View balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
        }

        static void ErrorMessage()
        {
            Console.WriteLine("Please enter a valid number!");
            ClearScreen();
        }
        static void ClearScreen()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}