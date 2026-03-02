using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp1
{
    #region Part 01 : Theoretical Questions
    public class BankAcount
    {
        private string owner;
        private double balance;
        private string[] _sections;
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

        public double account_rate
        {
            get { return rate +1; }
        }//in main we can print account_rate[5] but we can change the rate
        #endregion
        #region Q3
        //A: This  is indexer use it when I want to treat a object as an array <collection> and this refers to the inestance[object] that we create
        //B:output will be <IndexOutOfRangeException> becuse array lenght is 5
        //we can make indexer safer by validate first if index [10] is < lenght[5] we can set else print message
        // set
        //{
        //    if (index< 0 || index >= names.Length)
        //        console.write("Invalid index");
        //    names[index] = value;//we can create same validation in get to prevent any errors
        //}
        //C: we can do more than one indexer by using Overloaded Indexers [same indexer but change parameters]
        //For example, I want to reach to data using the index or the value
        //public string this[int index]
        //{
        //    get {return _sections[index]; }//can validate first
        //}

        //// Access by section name
        //public string this[string sectionName]
        //{
        //    get
        //    {
        //        foreach (var section in _sections) // Access by section name 
        //        {
        //            if (section == sectionName)
        //                return section;
        //        } return null;
        //    }
        //}

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
