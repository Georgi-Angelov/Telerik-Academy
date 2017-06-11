namespace HWDefiningClasses
{
    using System.Text;
    public class Battery
    {
        private string _model;
        private double? _hoursIdle;
        private double? _hoursTalk;
        private BatteryType _type;

        public Battery()
        {
        }

        public Battery(BatteryType type)
        {
            this.Type = type;
        }

        public Battery(BatteryType type, string model)
            : this(type)
        {
            this.Model = model;
        }

        public Battery(BatteryType type, string model, double hoursIdle, double hoursTalk)
            : this(type, model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get
            {
                return this._model;
            }

            set
            {
                this._model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this._hoursIdle;
            }

            set
            {
                this._hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this._hoursTalk;
            }

            set
            {
                this._hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this._type;
            }

            set
            {
                this._type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Battery Hours Idle: ").Append(this.HoursIdle).Append("\r\n");
            builder.Append("Battery Hours Talk: ").Append(this.HoursTalk).Append("\r\n");
            builder.Append("Battery Model: ").Append(this.Model).Append("\r\n");
            builder.Append("Battery Type: ").Append(this.Type).Append("\r\n");

            return builder.ToString();
        }
    }
}