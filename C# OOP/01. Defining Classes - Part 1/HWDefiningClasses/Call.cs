using System;
using System.Text;

namespace HWDefiningClasses
{
    public class Call // Problem 8. Calls
    {
        public Call(DateTime date, string dialledPhoneNumber, double duration)
        {
            this.Date = date;
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public DateTime Date { get; private set; }

        public string DialledPhoneNumber { get; private set; }

        public double Duration { get; private set; }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"Date: {this.Date} \r\n");
            builder.Append($"Dialled Phone Number: {this.DialledPhoneNumber} \r\n");
            builder.Append($"Duration: {this.Duration} \r\n");

            return builder.ToString();
        }

    }
}

