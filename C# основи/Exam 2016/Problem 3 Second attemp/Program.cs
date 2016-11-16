using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Second_attemp
{
    class Program
    {
        static void Main(string[] args)
        {
            string isEnd = Console.ReadLine();
            string result = "";
            int startNumber;
            bool isStringOrNum = Int32.TryParse(isEnd, out startNumber);
            int length;
            do
            {
                if ( startNumber == 0 )
                {
                    string isItEnd = Console.ReadLine();
                    bool isStringOrNum2 = Int32.TryParse(isItEnd, out startNumber);
                    if (isStringOrNum2 == false)
                    {
                        break;
                    }
                    
                }
                
                
                int endNumber = int.Parse(Console.ReadLine());
                string nonsense = Console.ReadLine();
                length = endNumber + 1 - startNumber;
                string workString = nonsense.Substring(startNumber, length);
                if (endNumber < 0 )
                {
                    for (int i = 0; length > i; i += 4)
                    {
                        result += workString.Substring(i, 1);
                    }
                }
                else if ( startNumber < 0)
                {

                }
                else
                {
                    


                    if (workString.Length % 2 == 0)
                    {
                        for (int i = 0; i < workString.Length; i += 3)
                        {
                            result += workString.Substring(i, 1);
                        }

                    }
                    else if (workString.Length % 2 == 1)
                    {
                        for (int i = 0; i < workString.Length; i += 4)
                        {
                            result += workString.Substring(i, 1);
                        }
                    }
                }
                
                
                
                
            }
            while (isEnd != "end");
            
            Console.WriteLine(result);
        }
    }
}