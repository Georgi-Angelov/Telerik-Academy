using System;

namespace _11.Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstName = "Georgi";
            string middleName = "Nikolaev";
            string lastName = "Angelov";
            string fullName = firstName + middleName + lastName; 
            decimal balance = 500.012345m;
            string bankName = "Magnat G Bank Holding (all your money)";
            string iban = "MGBH 9204 2424 2341 1234 12";
            string creditCardOne = "9876 5432 1234 5678";
            string creditCardTwo = "2345 3465 4567 5678";
            string creditCardThree = "4321 5423 6543 7654";


            Console.WriteLine(fullName);
            Console.WriteLine(balance);
            Console.WriteLine(bankName);
            Console.WriteLine(iban);
            Console.WriteLine(creditCardOne);
            Console.WriteLine(creditCardTwo);
            Console.WriteLine(creditCardThree);


        }
    }
}
