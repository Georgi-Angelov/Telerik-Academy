using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string n = Console.ReadLine();
            string cards = "23456789JQKA";
            if (n.Length >= 1 && n.Length <= 5)
                if (n == "10")
                    Console.WriteLine("yes {0}", n);
                else
                {
                    int cardin = cards.IndexOf(n);
                    if (cardin == -1)
                        Console.WriteLine("no {0}", n);
                    else
                        Console.WriteLine("yes {0}", n);
                }
        }
    }
}