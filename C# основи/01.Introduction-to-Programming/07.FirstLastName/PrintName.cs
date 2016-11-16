using System;

namespace PrintFirstAndLastName
{
    class PrintName
    {
        static void Main(string[] args)
        {
            string[] firstLastName = { "FirstName", "LastName" };
            for (int i = 0; i < firstLastName.Length; i++)
            {
                Console.WriteLine(firstLastName[i]);
            }
        }
    }
}
