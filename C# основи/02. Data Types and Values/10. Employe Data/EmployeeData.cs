using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Employe_Data
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Georgi";
            string lastName = "Angelov";
            byte age = 50;
            bool isMale = true;
            string male = "Male";
            string female = "Female";
            ulong idNum = 8306112507;
            long uniqueNumber = 27569999;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0} ", age);
            Console.WriteLine("Gender: {0}", isMale ? male : female);
            Console.WriteLine("Personal ID number: {0}", idNum);
            Console.WriteLine("Unique number:", uniqueNumber);
            
        }
    }
}
