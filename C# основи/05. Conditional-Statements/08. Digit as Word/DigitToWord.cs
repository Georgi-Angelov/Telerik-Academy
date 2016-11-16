using System;

class DigitToWord
{
    static void Main()
    {
        
        string text = Console.ReadLine();
        switch (text)
        {
            case "0":
                string digitName = "zero";
                Console.WriteLine(digitName);
                break;
            case "1":
                digitName = "one";
                Console.WriteLine(digitName);
                break;
            case "2":
                digitName = "two";
                Console.WriteLine(digitName);
                break;
            case "3":
                digitName = "three";
                Console.WriteLine(digitName);
                break;
            case "4":
                digitName = "four";
                Console.WriteLine(digitName);
                break;
            case "5":
                digitName = "five";
                Console.WriteLine(digitName);
                break;
            case "6":
                digitName = "six";
                Console.WriteLine(digitName);
                break;
            case "7":
                digitName = "seven";
                Console.WriteLine(digitName);
                break;
            case "8":
                digitName = "eight";
                Console.WriteLine(digitName);
                break;
            case "9":
                digitName = "nine";
                Console.WriteLine(digitName);
                break;
            default:
                Console.WriteLine("not a digit");
                break;
        }

    }
}