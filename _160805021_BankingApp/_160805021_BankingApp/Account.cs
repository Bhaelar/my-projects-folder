
using System;

namespace _160805021_BankingApp
{
	/// <summary>
	/// Account.cs is the parent class containing the constructor, methods and functionalities of the bank application.
	/// </summary>
	public class Account
	{
		
			/// <summary>
			/// Name of the bank account
			/// </summary>
			public String accountName;
			/// <summary>
			/// Balance of the bank account
			/// </summary>
			public double balance;
			/// <summary>
			/// The account number generated randomly by the program
			/// </summary>
			public String accountNumber;
			/// <summary>
			/// The 4-digit safety PIN that the user will use to guard his account
			/// </summary>
			private String PIN;
			
			/// <summary>
			/// Constructor for the account class
			/// </summary>
			/// <param name="accountName"> Name of the bank account</param>
			/// <param name="initDeposit"> The initial amount the accountholder wishes to deposit</param>
			/// <param name="accountNumber"> The account number that will be generated randomly by the program</param>
			/// <param name="PIN"> The 4-digit safety PIN that the user will use to guard his account</param>
			public Account(String accountName, double initDeposit, String accountNumber, String PIN) {
				this.accountName = accountName;
				balance = initDeposit;
				this.accountNumber = accountNumber;
				this.PIN = PIN;
			}
			
			/// <summary>
			/// Gets Account number
			/// </summary>
			/// <returns> The bank account number </returns>
			public String getAccountNumber() {
				return this.accountNumber;
			}
			
			/// <summary>
			/// Get PIN
			/// </summary>
			/// <returns> A 4-digit PIN </returns>
			public String getPIN {
				get {
					return PIN;
				}
			}
			
			/// <summary>
			/// Method to deposit money into the bank account
			/// </summary>
			/// <param name="amount"> Amount to be deposited </param>
			public void deposit(double amount) {
		        balance += amount;
		        Console.WriteLine("Depositing #" + amount);
		        Console.WriteLine("Your account balance is " + balance);
		    }
			
			/// <summary>
			/// Method to withdraw money from the bank account
			/// </summary>
			/// <param name="amount"> Amount to be withdrawn </param>
			public void withdraw(double amount) {
				if(balance > amount && amount > 0) {
			        balance -= amount;
			        Console.WriteLine("Your account balance is " + balance);
				} else {
					Console.WriteLine("Insufficient funds!");
				}
		    }
			
			/// <summary>
			/// Method to transfer money into another bank account
			/// </summary>
			/// <param name="toWhere"> Account to transfer the money to </param>
			/// <param name="amount"> Amount to be transferred </param>
		    public void transfer(String toWhere , double amount) {
		        if(balance > amount) {
					balance -= amount;
					Console.WriteLine("Transferring #" + amount + " to " + toWhere + "...");
		        	Console.WriteLine("Your account balance is " + balance);
				}	else {
					Console.WriteLine("Insufficient funds!");
				}
		        
		    }
			
			/// <summary>
			/// Method that displays the name, account number and balance of a bank account
			/// </summary>
			public void showInfo() {
		       Console.WriteLine("NAME: " + accountName +
		                "\nACCOUNT NUMBER: " + accountNumber +
		                "\nBALANCE: " + balance 
		                );
		    }
			
			/// <summary>
			/// Method to load a mobile phone number with airtime
			/// </summary>
			/// <param name="number"> Mobile phone number to be loaded </param>
			/// <param name="amount"> Amount to be loaded on the number </param>
			public String loadAirtime(String number, double amount) {
				String answer;
				if(balance > amount) {
					balance -= amount;
					answer = "Loading " + number + " with #" + amount + "\nTransaction successful";
				}	else {
					answer = "Insufficient funds!";
				}
				return answer;
			}
		}
	}

