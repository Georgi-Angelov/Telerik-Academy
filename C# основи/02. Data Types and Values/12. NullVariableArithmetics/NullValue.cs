using System;

namespace _12.NullVariableArithmetics
{
    class NullValue
    {
        static void Main(string[] args)
        {
            int nullValue = 0;
            double nullDValue = 0d;
            Console.WriteLine("{0} {1}", nullValue, nullDValue );

            nullValue++;
            nullDValue--;
            
            Console.WriteLine(nullValue);
            Console.WriteLine(nullDValue);
        }
    }
}
