using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public double ReadF64()
        {
            double result = this.ReadF64(this.position, this.Endianess);
            this.position += 4;
            return result;
        }
        public double ReadF64(int position)
        {
            double result = this.ReadF64(position, this.Endianess);
            return result;
        }
        public double ReadF64(Endianess endianess)
        {
            double result = this.ReadF64(this.position, endianess);
            this.position += 4;
            return result;
        }
        public double ReadF64(int position, Endianess endianess)
        {
            double result;
            if (endianess == Endianess.BE)
            {
                this.temp[0] = this.buffer[position + 7];
                this.temp[1] = this.buffer[position + 6];
                this.temp[2] = this.buffer[position + 5];
                this.temp[3] = this.buffer[position + 4];
                this.temp[4] = this.buffer[position + 3];
                this.temp[5] = this.buffer[position + 2];
                this.temp[6] = this.buffer[position + 1];
                this.temp[7] = this.buffer[position + 0];
                result = BitConverter.ToDouble(this.temp, 0);
            }
            else
            {
                result = BitConverter.ToDouble(this.buffer, position);
            }
            return result;
        }

        public void Write(double value)
        {
            this.Write(value, this.position, this.Endianess);
            this.position += 4;
        }
        public void Write(double value, int position)
        {
            this.Write(value, position, this.Endianess);
        }
        public void Write(double value, Endianess endianess)
        {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        public void Write(double value, int position, Endianess endianess)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, this.temp, 0, 8);
            if (endianess == Endianess.BE)
            {
                this.buffer[position + 7] = this.temp[0];
                this.buffer[position + 6] = this.temp[1];
                this.buffer[position + 5] = this.temp[2];
                this.buffer[position + 4] = this.temp[3];
                this.buffer[position + 3] = this.temp[4];
                this.buffer[position + 2] = this.temp[5];
                this.buffer[position + 1] = this.temp[6];
                this.buffer[position + 0] = this.temp[7];
            }
            else
            {
                this.buffer[position + 0] = this.temp[0];
                this.buffer[position + 1] = this.temp[1];
                this.buffer[position + 2] = this.temp[2];
                this.buffer[position + 3] = this.temp[3];
                this.buffer[position + 4] = this.temp[4];
                this.buffer[position + 5] = this.temp[5];
                this.buffer[position + 6] = this.temp[6];
                this.buffer[position + 7] = this.temp[7];
            }
        }
    }
}
