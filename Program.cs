using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Demo_Mock
{
    
    public class Account
    {
        public string AccountType { get; set; }
    }
    public class Loan
    {
        public string LoanType { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string ANumber { get; set; }
        public List<Account> acc = new List<Account>();
        public List<Loan> lone = new List<Loan>();
    }
    class AccountDemo
    {
        static void Main(string[] args)
        {
            List<Customer> cust = new List<Customer>()
            {
                new Customer{Name="Amar",Balance=40000,ANumber="7709852637",
                    acc={new Account{AccountType="Saving account"},
                    new Account{AccountType="Salary Account"} },
                    lone = {new Loan { LoanType="Car Loan"},
                    new Loan { LoanType="Home Loan"} } },

                new Customer
                {
                    Name = "Piyush",
                    Balance = 50000,
                    ANumber = "7020222723",
                    acc =
                    {
                       
                        new Account{AccountType="Current Account"},
                        new Account{AccountType="Saving Account"}
                    },
                    lone =
                    {
                        new Loan{LoanType="Home Loan"}
                    }
                },
                new Customer
                {
                    Name = "Akshay",
                    Balance = 70000,
                    ANumber = "8459627279",
                    acc =
                    {
                        new Account{AccountType="Saving Account"},
                        new Account{AccountType="Salary Account"}
                    },
                    lone =
                    {
                        new Loan{LoanType="Home Loan"},
                        new Loan{LoanType="Education Loan"},
                        new Loan{LoanType="Gold Loan"}
                    }
                }

            };
            foreach (var v in cust)
            {
                System.Console.WriteLine($"Name=  {v.Name}, Balance= {v.Balance}, ANumber= {v.ANumber}");
                System.Console.WriteLine("Account Type");
                foreach (var m in v.acc)
                {
                    System.Console.WriteLine(m.AccountType);

                }
                System.Console.WriteLine("Loan Type");
                foreach (var n in v.lone)
                {
                    System.Console.WriteLine(n.LoanType);
                }

                System.Console.WriteLine("**************");

            }
        }
    }
}