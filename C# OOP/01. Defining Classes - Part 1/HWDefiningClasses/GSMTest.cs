using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefiningClasses
{
    public class GSMTest // Problem 7. GSM test
    {
        public void PrintPhones()
        {
            GSM[] mobilePhones = this.CreatePhones();
            foreach (var phone in mobilePhones)
            {
                Console.WriteLine(phone);
            }
        }

        public GSM[] CreatePhones()
        {
            GSM[] mobilePhones =
            {
                new GSM("ZenPhone", "Asus"),
                new GSM("G3", "LG", 650, "Gosho Petrov", new Battery(BatteryType.UraniumMaxed), new Display(5.5, "13M")),
                new GSM("M2", "Sony", 60, "Petyr Goshov", new Battery(BatteryType.LiIon, "HS4-555", 80, 20), new Display(5, "16M")),
                new GSM("Maple", "Syrup", new Battery(BatteryType.Mapled), new Display()),
                new GSM("SomeSong", "Universe", decimal.MaxValue, "Program Writer", new Battery(BatteryType.StarCore, "Stardust 5000", 20, 10 ), new Display(7.6, "All of them"))
            };

            return mobilePhones;
        }

        public void DisplayInfoIphone4S()
        {
            Console.WriteLine(GSM.Iphone4s);
        }
    }
}
