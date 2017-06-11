using System.Text;

namespace HWDefiningClasses
{

    public class Display
    {
        private double? _size;
        private string _numberOfColors;

        public Display()
        {
        }

        public Display(double? size, string colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }

        public double? Size
        {
            get { return this._size; }

            set { this._size = value; }
        }

        public string NumberOfColors
        {
            get { return this._numberOfColors; }

            set { this._numberOfColors = value; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Display Size: ").Append(this.Size).Append("\r\n");
            builder.Append("Display Colors: ").Append(this.NumberOfColors).Append("\r\n");
            return builder.ToString();
        }
    }
}
