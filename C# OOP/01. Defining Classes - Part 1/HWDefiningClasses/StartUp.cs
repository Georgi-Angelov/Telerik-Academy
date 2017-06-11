using System;

namespace HWDefiningClasses
{
    class StartUp
    {
        public static void Main()
        {
            GSM phoneOne = new GSM("Galaxy S6", "Samsung");

            Console.WriteLine(phoneOne.ToString());

            GSMTest printPhones = new GSMTest();
            printPhones.PrintPhones();

            printPhones.DisplayInfoIphone4S();

            CallHistoryTest.TestCallHistory();
        }
    }
}
