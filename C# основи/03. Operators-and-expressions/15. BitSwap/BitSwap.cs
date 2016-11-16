using System;


class BitSwap
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = p; i < p + k; i++)
        {
            int mask1 = 1 << i;
            int mask2 = mask1 & n;
            int bit = mask2 >> i;

            int mask3 = 1 << q;
            int mask4 = mask3 & n;
            int bit1 = mask4 >> q;

            if (bit == 0)
            {
                int mask5 = ~(1 << q);
                n = mask5 & n;
                if (bit != bit1)
                {
                    int mask6 = 1 << i;
                    n = mask6 | n;
                }
            }
            else if (bit == 1)
            {
                int mask7 = 1 << q;
                n = mask7 | n;
                if (bit != bit1)
                {
                    int mask8 = ~(1 << i);
                    n = mask8 & n;
                }
            }
            q++;
        }
        Console.WriteLine(n);
    }
}