using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public float ReadF32()
        {
            float result = this.ReadF32(this.position, this.Endianess);
            this.position += 4;
            return result;
        }
        public float ReadF32(int position)
        {
            float result = this.ReadF32(position, this.Endianess);
            return result;
        }
        public float ReadF32(Endianess endianess)
        {
            float result = this.ReadF32(this.position, endianess);
            this.position += 4;
            return result;
        }
        public float ReadF32(int position, Endianess endianess)
        {
            float result;
            if (endianess == Endianess.BE)
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
            this.Write(value, this.position, this.Endianess);
            this.position += 4;
        }
        public void Write(float value, int position)
        {
            this.Write(value, position, this.Endianess);
        }
        public void Write(float value, Endianess endianess)
        {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        public void Write(float value, int position, Endianess endianess)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, this.temp, 0, 4);
            if (endianess == Endianess.BE)
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
