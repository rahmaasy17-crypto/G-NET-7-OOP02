using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    #region Part 01 : Theoretical Questions
    public class BankAcount
    {
        private string owner;
        private double balance;
        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else Console.WriteLine("invalid amount");
        }

        #region  Q1
        //a: The problem is the fields are public and there is no validation in the method
        //and this will allow anyone to modify the fields ​​with invaid values without validation 

        //b: We solved the problem by making fields private to control access and first verifying that the input value is correct
        //c: public fields is bad oop beacuse We should define the access to have a specific way to modify and validate first ,
        //and so we have control over any incoming data,
        //and have specific rules to prevent accuret data and bugs
        #endregion
        #region Q2
        // Field :Direct data storage , No validation and Breaks encapsulation[unsafe can make bugs]
        // Property:Controlled access ,Can validate before store data and Enforces encapsulation and can contain logic like validate
        //or calculate or modifing data  before setting and limit getting [can prevent getting ]
        // read only property :
        private double rate=4;// we can setting value by constructor 

        public bool Goodrate// NO backing field created
        {
            get { return rate>3; } //it calculated in runtime and didnot stored [we can do any operation like area]
        }//in main we can print rate state > if (account.Goodrate){console.writeline ("goodrate");}
        #endregion
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         BankAcount first =new BankAcount();
        }
    }
}
