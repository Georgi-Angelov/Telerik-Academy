using System;

namespace _04.Print_a_Deck
{
    class DeckPrint
    {
        static void Main(string[] args)
        {
            string sign = Console.ReadLine();
            int cardNumber = 0 ;
         
            switch (sign)
            {
              
                case "J": 
                    cardNumber = 11; 
                    break;
                case "Q":
                    cardNumber = 12; 
                    break;
                case "K": 
                    cardNumber = 13; 
                    break;
                case "A": 
                    cardNumber = 14; 
                    break;
                default:
                    cardNumber = int.Parse(sign);
                break;
            }
            
            for (int i = 2; i <= cardNumber; i++)
            {
                sign = string.Empty;
                switch (i)
                {
                    case 11:
                        sign = "J";
                        break;
                    case 12:
                        sign = "Q";
                        break;
                    case 13:
                        sign = "K";
                        break;
                    case 14:
                        sign = "A";
                        break;
                    default:
                        sign = string.Empty + i;
                        break;
                }
                    string output = "{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds";
                    Console.WriteLine(output, sign);
            }
        }
    }
}
