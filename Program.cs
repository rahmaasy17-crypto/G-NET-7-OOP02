namespace ConsoleApp1
{
    #region Part 01 : Theoretical Questions
    #region  Q1
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
    }
    //a: The problem is the fields are public and there is no validation in the method
    //and this will allow anyone to modify the fields ​​with invaid values without validation 

    //b: We solved the problem by making fields private to control access and first verifying that the input value is correct
    //c: public fields is bad oop beacuse We should define the access to have a specific way to modify and validate first ,
    //and so we have control over any incoming data,
    //and have specific rules to prevent accuret data and bugs
    #endregion

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}
