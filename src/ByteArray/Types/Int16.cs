namespace Soly.Utils
{
    public partial class ByteArray
    {
        public short ReadI16()
        {
            short result = this.ReadI16(this.position, this.Endianess);
            this.position += 2;
            return result;
        }
        public short ReadI16(int position)
        {
            short result = this.ReadI16(position, this.Endianess);
            return result;
        }
        public short ReadI16(Endianess endianess)
        {
            short result = this.ReadI16(this.position, endianess);
            this.position += 2;
            return result;
        }
        public short ReadI16(int position, Endianess endianess)
        {
            short result;
            if (endianess == Endianess.BE)
            {
                result = (short)(this.buffer[position + 1] | this.buffer[position + 0] << 8);
            }
            else
            {
                result = (short)(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            }
            return result;
        }

        public void Write(short value)
        {
            this.Write(value, this.position, this.Endianess);
            this.position += 2;
        }
        public void Write(short value, int position)
        {
            this.Write(value, position, this.Endianess);
        }
        public void Write(short value, Endianess endianess)
        {
            this.Write(value, this.position, endianess);
            this.position += 2;
        }
        public void Write(short value, int position, Endianess endianess)
        {
            if (endianess == Endianess.BE)
            {
                this.buffer[position + 1] = (byte)value;
                this.buffer[position + 0] = (byte)(value >> 8);
            }
            else
            {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
            }
        }
    }
}
