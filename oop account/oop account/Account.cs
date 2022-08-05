using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_account
{
    class Account
    {
        string accNo, name;
        int balance;

        public Account()
        {
            Console.WriteLine("Executed blank construtor");
        } 
        public Account(string ano, string na) 
        {
            this.accNo= ano;
            this.name= na;
        }
        public Account(string ano, string na, int bal)
        {
            this.accNo = ano;
            this.name = na;
            this.balance = bal;

        }
        public float calInterest()
        {
            float interest;
            interest = this.balance * 10 / 100;
            return interest;

        }

 
    

        public void showData()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Account Number : " + this.accNo);
            Console.WriteLine("Account Name : " + this.name);
            Console.WriteLine("Account Number : " + this.balance);
            
        }
        public void deposit(int amt)
        {
            this.balance = this.balance + amt;
        }
        public void withdraw(int amt)
        {
            this.balance = this.balance - amt;
        }
        
    }
}
