using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public char ReadCharA()
        {
            char result = this.ReadCharA(this.position);
            this.position += 1;
            return result;
        }
        public char ReadCharA(int position)
        {
            char result = Convert.ToChar(this.buffer[position]);
            return result;
        }

        public void WriteCharA(char value)
        {
            this.WriteCharA(value, this.position);
            this.position += 1;
        }
        public void WriteCharA(char value, int position)
        {
            if (value > 255)
            {
                this.buffer[position] = Convert.ToByte('?');
            }
            else
            {
                this.buffer[position] = Convert.ToByte(value);
            }
        }
    }
}
