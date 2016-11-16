using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int_Double_String
{
    class Switch
    {
        static void Main(string[] args)
        {
            string cases = Console.ReadLine();
            switch (cases)
            {
                case "integer": 
                    int number = int.Parse(Console.ReadLine()); 
                    number++; 
                    Console.WriteLine(number);
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    realNumber++;
                    Console.WriteLine("{0:F2}", realNumber);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine("{0}*", text);
                    break;
                default: Console.WriteLine("Enter correct format: intiger, real or text");
                    break;
            }
        }
    }
}
