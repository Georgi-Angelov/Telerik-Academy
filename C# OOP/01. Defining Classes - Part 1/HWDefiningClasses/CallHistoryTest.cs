using System;
namespace HWDefiningClasses
{
    public class CallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM phoneOne = new GSM("G3", "LG");

            Call testOne = new Call(DateTime.Now, "0871234049", 60);
            phoneOne.AddCallHistory(testOne);

            Call testTwo = new Call(DateTime.Now, "0878992839", 60);
            phoneOne.AddCallHistory(testTwo);

            Call testThree = new Call(DateTime.Now, "0878991234", 60);
            phoneOne.AddCallHistory(testThree);

            Call testFour = new Call(DateTime.Now, "0878913239", 60);
            phoneOne.AddCallHistory(testFour);

            Call testFive = new Call(DateTime.Now, "0878994131", 60);
            phoneOne.AddCallHistory(testFive);

            Call testSix = new Call(DateTime.Now, "0878999865", 60);
            phoneOne.AddCallHistory(testSix);

            phoneOne.PrintCallHistory();
            phoneOne.CallPrice();

            phoneOne.DeleteCallHistory(5);
            phoneOne.ClearCallHistory();
        }
    }
}
