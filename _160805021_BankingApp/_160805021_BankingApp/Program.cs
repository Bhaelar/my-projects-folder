
using System;
using System.Collections.Generic;

 namespace _160805021_BankingApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Random generator = new Random();
			List<Account> accountHolder = new List<Account>();
			while (true) {
				Console.WriteLine("Welcome to our banking app. How may we help you?");
				Console.Write("1. Set up account\n" +
				              "2. Check balance\n" +
				              "3. Deposit\n" +
				              "4. Withdraw\n" +
				              "5. Transfer\n" +
				              "6. Buy Airtime\n" +
				              "X. Terminate\n\n" +
				              "Select Function: ");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "1")
                {
                    Console.Write("Enter your full name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter initial deposit: ");
                    double deposit = double.Parse(Console.ReadLine());
                    int i = generator.Next(100000000,999999999) + 1;
					String accountNumber = i.ToString();
					Console.WriteLine("Enter your 4-digit PIN");
					String PIN = ReadPassword();
                    accountHolder.Add(new Account(name, deposit, accountNumber, PIN));
                    Console.WriteLine("Your bank account has been successfully created!");
                    //accountHolder.showInfo();
                    Console.ReadLine();
                }
                else if (ans == "2")
                {
                    Console.Write("Enter your 4 digit PIN: ");
                    string Chk = ReadPassword();
                    int k = 0;
                    for (int i = 0; i < accountHolder.Count; i++)
                    {
                        if (accountHolder[i].getPIN == Chk)
                        {
                        	k++;
                        	Console.WriteLine("Welcome " + accountHolder[i].accountName);
                        	accountHolder[i].showInfo();
                        }
                    }
                    if(k == 0) {
                    	Console.WriteLine("Your account wasn't found");
                    }
                    Console.ReadLine();
                }
                else if (ans == "3")
                {
                    Console.Write("Enter your 4 digit PIN: ");
                    string Chk = ReadPassword();
                    int k = 0;
                    for (int i = 0; i < accountHolder.Count; i++)
                    {
                        if (accountHolder[i].getPIN == Chk)
                        {
                        	k++;
                        	Console.WriteLine("Welcome " + accountHolder[i].accountName);
                            Console.Write("Enter amount to Deposit: ");
                            double deposit = double.Parse(Console.ReadLine());
                            accountHolder[i].deposit(deposit);
                        }
                    }
                    if(k == 0) {
                    	Console.WriteLine("Account not found!"); 
                    }
                    Console.ReadLine();
                }
                else if (ans == "4")
                {
                    Console.Write("Enter your 4 digit PIN: ");
                    string Chk = ReadPassword();
                    int k = 0;
                    for (int i = 0; i < accountHolder.Count; i++)
                    {
                        if (accountHolder[i].getPIN == Chk)
                        {
                        	k++;
                           Console.WriteLine("Welcome " + accountHolder[i].accountName);
                           Console.Write("Enter amount to Withdraw: ");
                           double amount = double.Parse(Console.ReadLine());
                           accountHolder[i].withdraw(amount);
                        }
                    }
                    if(k == 0) {
                     	Console.WriteLine("Account not found!"); 
                    }
                    Console.ReadLine();
                }
                else if (ans == "5")
                {
                    Console.Write("Enter your 4 digit PIN: ");
                    string Chk = ReadPassword();
                    int k = 0;
                    for (int i = 0; i < accountHolder.Count; i++)
                    {
                        if (accountHolder[i].getPIN == Chk)
                        {
                        	k++;
                            Console.WriteLine("Welcome " + accountHolder[i].accountName);
                           	Console.Write("Enter account number you wish to transfer to: ");
                           	String accountNo = Console.ReadLine();
                           	int l = 0;
                           	for(int j = 0; j < accountHolder.Count; j++) {
                           		if(accountHolder[i].getAccountNumber().Equals(accountNo)) {
                           			l++;
                           		}
                           	}
                           	if(l == 0) {
                           		Console.WriteLine("Account number was not found!");
                           	}
                           	if(l > 0) {
	                           	Console.Write("Enter amount you wish to transfer: ");
	                           	double amount = double.Parse(Console.ReadLine());
	                           	accountHolder[i].transfer(accountNo, amount);
	                        }
                        }
                           	
                        
                    }
                    if(k == 0) {
                    	Console.WriteLine("Account not found!"); 
                    }
                    Console.ReadLine();
                }
                else if (ans == "6")
                {
                	Console.Write("Enter your 4 digit PIN: ");
                    string Chk = ReadPassword();
                    int k = 0;
                    for (int i = 0; i < accountHolder.Count; i++)
                    {
                    	if (accountHolder[i].getPIN == Chk)
                        {
                        	k++;
                        	Console.WriteLine("Welcome " + accountHolder[i].accountName);
		                	Console.Write("Select your network\n1. MTN\n2. Airtel\n3. Etisalat\n4. Glo\n");
		                	string chk = Console.ReadLine().ToUpper();
		                	if (chk == "1" || chk == "2" || chk == "3" || chk == "4") {
		                		Console.WriteLine("Enter your phone number: ");
		                		String number = Console.ReadLine();
		                		Console.WriteLine("Enter the amount you wish to load: ");
		                		double amount = double.Parse(Console.ReadLine());
		                		Console.WriteLine(accountHolder[i].loadAirtime(number, amount));
		                	} else {
		                		Console.WriteLine("Select a valid option");
		                	}
                    	}
                    	
                    }
                    if(k == 0) {
                    	Console.WriteLine("Account not found!"); 
                    }
                    Console.ReadLine();
                }
                else if (ans == "X")
                {
                	Environment.Exit(0);
                	break;
                }
                else
                {
                    Console.WriteLine("Invalid Syntax!");
                    Console.ReadLine();
                }
                Console.Clear();
            
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static string ReadPassword()
		   {
		      string password = "";
		      ConsoleKeyInfo info = Console.ReadKey(true);
		      while (info.Key != ConsoleKey.Enter)
		      {
		          if (info.Key != ConsoleKey.Backspace)
		          {
		             Console.Write("*");
		             password += info.KeyChar;
		          }
		          else if (info.Key == ConsoleKey.Backspace)
		          {
		             if (!string.IsNullOrEmpty(password))
		             {
		                // remove one character from the list of password characters
		                password = password.Substring(0, password.Length - 1);
		                // get the location of the cursor
		                int pos = Console.CursorLeft;
		                // move the cursor to the left by one character
		                Console.SetCursorPosition(pos - 1, Console.CursorTop);
		                // replace it with space
		                Console.Write(" ");
		                // move the cursor to the left by one character again
		                Console.SetCursorPosition(pos - 1, Console.CursorTop);
		             }
		          }
		          info = Console.ReadKey(true);
		      }
		
		      // add a new line because user pressed enter at the end of their password
		      Console.WriteLine();
		      return password;
		   }
		
	}
}