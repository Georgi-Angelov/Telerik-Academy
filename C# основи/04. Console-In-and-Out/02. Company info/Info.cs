using System;

namespace _02.Company_info
{
    class Info
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyNumber = Console.ReadLine();
            string fax = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            if (companyName.Length < 1)
            { 
                Console.WriteLine("Enter Name with more than 1 letter");
            }
            else
            {
                Console.WriteLine("{0}", companyName);
            }
                
               
                Console.WriteLine("Address: {0}", companyAddress);
                Console.WriteLine("Tel. {0}", companyNumber);
                if (string.IsNullOrEmpty(fax) == true)
                {
                    Console.WriteLine("Fax: (no fax)");
                }
                else
                {
                    Console.WriteLine("Fax: {0}", fax);
                }
                Console.WriteLine("Web site: {0}", webSite);
                Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
            }
            
            
        }
    }
