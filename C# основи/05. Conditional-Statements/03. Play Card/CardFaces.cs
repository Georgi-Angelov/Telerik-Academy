using System;

namespace _03.Play_Card
{
    class CardFaces
    {
        static void Main(string[] args)
        {
            string playCard = Console.ReadLine();
            if (playCard == "2" 
             || playCard == "3" 
             || playCard == "4" 
             || playCard == "5" 
             || playCard == "6" 
             || playCard == "7" 
             || playCard == "8" 
             || playCard == "9" 
             || playCard == "10" 
             || playCard == "J" 
             || playCard == "Q" 
             || playCard == "K" 
             || playCard == "A")
            {
                Console.WriteLine("yes {0}", playCard);
            }
            else
            {
                Console.WriteLine("no {0}", playCard);
            }
        }
    }
}
/*  Second iteration

            }
            switch (playCard)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("YES");
                    break;

                default:
                    Console.WriteLine("NO");
                    break;
            }
*/
