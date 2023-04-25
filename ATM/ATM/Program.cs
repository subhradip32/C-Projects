using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class User
    {
        public String Username;
        public int BankAccountNumber;
        public int Password;
        public int CurrentBalance;
        public DateTime LastTransaction = new DateTime(); 
    }
    class Program
    {
        static void Main()
        {

            User[] AllUsers = new User[2];
            AllUsers[0] = new User { Username = "Ratul", BankAccountNumber = 100, Password = 2005, CurrentBalance = 1000 };
            AllUsers[1] = new User { Username = "Aayush", BankAccountNumber = 200, Password = 2004, CurrentBalance = 5000 };

            while (true)
            {
                int AcNum = Display();

                if (Authenticate(AllUsers, AcNum) )
                {
                    User data = GetUser(AllUsers, AcNum);
                    int asknum = WorkingInterface(data);
                    while (true)
                    {
                        if (asknum == 1)
                        {
                            Console.Write("Amount of money for Withdrawl: ");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            Withdrawl(data, amount);
                            asknum = new int();
                            break;
                        }
                        else if (asknum == 2)
                        {
                            Console.Write("Amount of money for Deposite: ");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            Deposite(data, amount);
                            asknum = new int();
                            break;
                        }
                        else if (asknum == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Thanks for visiting :)");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter A Vaild Input");
                            Console.ResetColor();
                        }
                    }

                }

                Console.ReadLine();

        }

        }
        static int Display()
        {
            Console.WriteLine("Welcome to ATM of Bank of Haven");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter Your BankAccount Number: ");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        static bool Authenticate(User[] users ,int Accnum)
        {
            bool ans = false;
            foreach (User user in users)
            {
                if (user.BankAccountNumber == Accnum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Enter Password: ");
                    Console.ResetColor();
                    int pass = Convert.ToInt32(Console.ReadLine());
                    if (pass == user.Password)
                    {
                        ans = true;
                        break;
                    }
                    else
                    {
                        ans = false;
                    }
                     
                }
                else
                {
                    ans = false; 
                }
            }
            return ans; 
        }
        static int WorkingInterface(User user)
        {
            Console.WriteLine($"Welcome {user.Username} \n Status--------> \n BankAccountNumber: {user.BankAccountNumber} \n CurrentBalance: {user.CurrentBalance} \n Last Date of transaction: {user.LastTransaction} ");
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine($"Menu-----> \n 1.Withdrawl \n 2.Deposite \n 0.Exit");
            Console.ResetColor();
            Console.Write("Provide your choice: "); 
            return Convert.ToInt32(Console.ReadLine()); 
        }
        static User GetUser(User[] users,int Bknum)
        {
            User data = new User();  
            foreach (User user in users)
            {
                if (user.BankAccountNumber == Bknum)
                {
                    data = user;
                    break; 
                }
            }
            return data; 
        }
        static void Withdrawl(User CurrentUser,int AmountofMoney)
        {
            CurrentUser.CurrentBalance -= AmountofMoney; 
        }
        static void Deposite(User CurrentUser, int AmountofMoney)
        {
            CurrentUser.CurrentBalance += AmountofMoney;
        }
    }
}
