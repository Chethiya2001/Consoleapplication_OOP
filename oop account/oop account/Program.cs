using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_account
{
    class Program
    {
        static void Main(string[] args)
        {
            //createing object

            Account a1 = new Account("1","Tom");
            Account a2 = new Account("2","Bob",80000);
            Account a3 = new Account("3", "jhon", 200000);
            Account a4 = new Account();

            a1.deposit(1000);
            a1.showData();
            a2.deposit(2000);
            a2.showData();
            a3.showData();
            float z = a2.calInterest();
            Console.WriteLine("Interest is :" + z);
            a4.showData();
            Console.ReadLine();





        }
    }
}
