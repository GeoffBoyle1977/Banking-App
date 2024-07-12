using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApp
{
    internal class Program
    {

        static void start()                                          //Function created for Start Menu                       
        {
            Console.WriteLine("Please select an option");            //Console to print the menu options to screen
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Signup");
            Console.WriteLine("[3] Quit");

        }
        static void transact()                                                  //Function created for Transaction Menu
        {
            Console.WriteLine("Transaction Menu");                              //Console to print Transaction menu options
            Console.WriteLine("Please select an option");
            Console.WriteLine("[1] View Balance");
            Console.WriteLine("[2] Deposit");
            Console.WriteLine("[3] Withdraw");
            Console.WriteLine("[4] Transfer");
            Console.WriteLine("[5] Quit");
        }
        static void Main(string[] args)
        {
            int startMenu;                                                      //Declaring Variables
            String userName;
            String password;
            int transaction;
            double balance;
            double withdraw;
            double deposit;
            double transfer;
            char quit;
            Console.WriteLine("Welcome to BankPlus");
            start();
            startMenu = int.Parse(Console.ReadLine());                          //Console to read user input of the menu option
            while (startMenu > 1 && startMenu > 3 || startMenu == 0)             //Condition statement if user does not enter
            {                                                                       //a number between 1 and 3.
                Console.WriteLine("Please select one of the 3 options");
                start();
                startMenu = int.Parse(Console.ReadLine());
            }

            switch (startMenu)
            {
                case 1:
                    Console.WriteLine("You have selected [" + startMenu + "] Login");
                    Console.WriteLine("Please enter Username");
                    userName = Console.ReadLine();
                    Console.WriteLine("Please enter your password");
                    password = Console.ReadLine();
                    Console.WriteLine("Welcome " + userName);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("You have selected [" + startMenu + "] Signup");
                    break;
                case 3:
                    Console.WriteLine("You have selected [" + startMenu + "] Quit");

                    break;

            }
            if (startMenu == 1)                                                 //If user selects option 1 calls function 
            {                                                                       //transact.
                transact();

                transaction = int.Parse(Console.ReadLine());
                while (transaction > 1 && transaction > 5 || transaction == 0)  //Condition statement if user does not 
                {                                                                   //enter u number between 1 and 5
                    Console.WriteLine("Please select one of the 5 options");
                    transaction = int.Parse(Console.ReadLine());
                }

                switch (transaction)                                                //Maybe create functions or classes to be
                {                                                                       //Called up in this section
                    case 1:
                        Console.WriteLine("Your Current balance is ");
                        break;
                    case 2:
                        Console.WriteLine("How much do you wish to deposit? ");
                        break;

                    case 3:
                        Console.WriteLine("How much do you wish to withdraw? ");
                        break;
                    case 4:
                        Console.WriteLine("How much do you wish to transfer? ");
                        break;

                    case 5:

                        Console.WriteLine("Are you sure you want to quit to the Main Screen (Y/N)");
                        quit = char.Parse(Console.ReadLine());                     //Condition statement prompting the user to
                        if (quit == 'N' || quit == 'n')                                 // Y or N to quit the program
                        {

                        }
                        else
                             if (quit == 'Y' || quit == 'y')
                        {

                        }
                        break;
                }

                if (startMenu == 2)                                               //If the user selects option 2 from the start
                {                                                                       //menu to sign up.
                    Console.WriteLine("You have selected signup menu");
                }                                                               // ** PUT CODE IN THIS SECTION *** 
                                                                                // ** TO ACCESS SIGNUP MENU *****
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}

