using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    #region Part 01 : Theoretical Questions
    public class BankAcount_part1
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
        private double rate = 4;// we can setting value by constructor 

        public bool Goodrate// NO backing field created
        {
            get { return rate > 3; } //it calculated in runtime and didnot stored [we can do any operation like area]
        }//in main we can print rate state > if (account.Goodrate){console.writeline ("goodrate");}
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
        #region Q4 
        //A:The static keyword means that TotalOrders belongs to the class and instaces are shared across all objects
        //and Instance members like [Item] belong to thier objects only
        //B: A static method cannot access instance members directly because it is not tied to a specific object


        //static member can be accessed by using  class name, but Instance members without creating an object cannot be accessed
        //so A static method cannot access instance members directly because it is not associated with a specific object
        #endregion

    }
    #endregion
}
