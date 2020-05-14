using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public float ReadF32()
        {
            float result = this.ReadF32(this.position, this.endianness);
            this.position += 4;
            return result;
        }
        public float ReadF32(int position)
        {
            float result = this.ReadF32(position, this.endianness);
            return result;
        }
        public float ReadF32(Endianness endianness)
        {
            float result = this.ReadF32(this.position, endianness);
            this.position += 4;
            return result;
        }
        public float ReadF32(int position, Endianness endianness)
        {
            float result;
            if (endianness == Endianness.BE)
            {
                this.temp[0] = this.buffer[position + 3];
                this.temp[1] = this.buffer[position + 2];
                this.temp[2] = this.buffer[position + 1];
                this.temp[3] = this.buffer[position + 0];
                result = BitConverter.ToSingle(this.temp, 0);
            }
            else
            {
                result = BitConverter.ToSingle(this.buffer, position);
            }
            return result;
        }

        public void Write(float value)
        {
            this.Write(value, this.position, this.endianness);
            this.position += 4;
        }
        public void Write(float value, int position)
        {
            this.Write(value, position, this.endianness);
        }
        public void Write(float value, Endianness endianness)
        {
            this.Write(value, this.position, endianness);
            this.position += 4;
        }
        public void Write(float value, int position, Endianness endianness)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, this.temp, 0, 4);
            if (endianness == Endianness.BE)
            {
                this.buffer[position + 3] = this.temp[0];
                this.buffer[position + 2] = this.temp[1];
                this.buffer[position + 1] = this.temp[2];
                this.buffer[position + 0] = this.temp[3];
            }
            else
            {
                this.buffer[position + 0] = this.temp[0];
                this.buffer[position + 1] = this.temp[1];
                this.buffer[position + 2] = this.temp[2];
                this.buffer[position + 3] = this.temp[3];
            }
        }
    }
}
