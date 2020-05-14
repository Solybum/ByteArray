using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public char ReadCharW()
        {
            char result = this.ReadCharW(this.position);
            this.position += 2;
            return result;
        }
        public char ReadCharW(int position)
        {
            char result = Convert.ToChar(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            return result;
        }
        public void WriteCharW(char value)
        {
            this.WriteCharW(value, this.position);
            this.position += 2;
        }
        public void WriteCharW(char value, int position)
        {
            ushort tmp = Convert.ToUInt16(value);
            this.buffer[position + 0] = (byte)tmp;
            this.buffer[position + 1] = (byte)(tmp >> 8);
        }
    }
}
