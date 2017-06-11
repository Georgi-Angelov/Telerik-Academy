using System;
using System.Collections.Generic;
using System.Text;

namespace HWDefiningClasses
{
    public class GSM
    {
        private string _model;
        private string _manufacturer;
        private decimal? _price;
        private string _owner;
        private Battery _batteryInfo;
        private Display _displayInfo;
        private List<Call> _callHistory;
        public static readonly GSM Iphone4s = new GSM("IPhone4S", 
                                                      "Apple", 
                                                      new Battery(BatteryType.Potato), 
                                                      new Display()); // Problem 6. Static field
        // Ctrl + M + L ---- Expand all collapsed sections
        // Ctrl + M + O ---- Collapse all sections
        public GSM(string model, string manufacturer)   // Problem 2. Constructors
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();
        } 
        public GSM(string model, string manufacturer, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer) // Problem 2. Constructors 
        {
            this.BatteryInfo = batteryInfo;
            this.DisplayInfo = displayInfo;
        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer, batteryInfo, displayInfo) // Problem 2. Constructors
        {
            this.Price = price;
            this.Owner = owner;
        }
        public string Model
        {
            get { return this._model; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid model name!");
                }
                this._model = value;
            }
        }
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Enter valid manufacturer!");
                }
                this._manufacturer = value;
            }
        }
        public decimal? Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }
        public Battery BatteryInfo
        {
            get { return this._batteryInfo; }

            set { this._batteryInfo = value; }
        }
        public Display DisplayInfo
        {
            get { return this._displayInfo; }
            set { this._displayInfo = value; }
        }
        public override string ToString() // Problem 4. ToString
        {
            var builder = new StringBuilder();
            
            builder.Append("Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Manufacturer: ").Append(this.Manufacturer).Append("\r\n");
            builder.Append("Price: ").Append(this.Price).Append("\r\n");
            builder.Append("Owner: ").Append(this.Owner).Append("\r\n");

            if (this.BatteryInfo != null)
            {
                builder.Append(this.BatteryInfo.ToString());
            }
            else
            {
                builder.Append("Battery Hours Idle: ").Append("\r\n");
                builder.Append("Battery Hours Talk: ").Append("\r\n");
                builder.Append("Battery Model: ").Append("\r\n");
                builder.Append("Battery Type: ").Append("\r\n");
            }

            if (this.DisplayInfo != null)
            {
                builder.Append(this.DisplayInfo.ToString());
            }
            else
            {
                builder.Append("Display Size: ").Append("\r\n");
                builder.Append("Display Colors: ").Append("\r\n");
            }

            return builder.ToString();
        }
        public List<Call> CallHistory // Problem 9. Call History
        {
            get
            {
                return this._callHistory;
            }

            private set
            {
                this._callHistory = value;
            }
        }
        public void PrintCallHistory()
        {
            foreach (var item in this.CallHistory)
            {
                Console.WriteLine(item);
            }
        }// Problem 9.+ Print History /w foreach loop   
        public void AddCallHistory(Call call) // Problem 10. Add/Delete Call
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCallHistory(int index) // Problem 10. Add/Delete Call
        {
            this.CallHistory.Remove(this._callHistory[index]);
        }

        public void ClearCallHistory() // Problem 10. Add/Delete Call
        {
            this.CallHistory.Clear();
        }
        public void CallPrice() // problem 11. Call Price
        {
            double sum = 0;
            double sumPerMin = 0.37f;

            for (int i = 0; i < this._callHistory.Count; i++)
            {
                sum += (this.CallHistory[i].Duration / 60) * sumPerMin;
            }

            Console.WriteLine("The Total price is {0:F2} lv", sum);
        }
    }
}
