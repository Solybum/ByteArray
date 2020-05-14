namespace Soly.Utils
{
    public partial class ByteArray
    {
        public short ReadI16()
        {
            short result = this.ReadI16(this.position, this.endianness);
            this.position += 2;
            return result;
        }
        public short ReadI16(int position)
        {
            short result = this.ReadI16(position, this.endianness);
            return result;
        }
        public short ReadI16(Endianness endianness)
        {
            short result = this.ReadI16(this.position, endianness);
            this.position += 2;
            return result;
        }
        public short ReadI16(int position, Endianness endianness)
        {
            short result;
            if (endianness == Endianness.BE)
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
            this.Write(value, this.position, this.endianness);
            this.position += 2;
        }
        public void Write(short value, int position)
        {
            this.Write(value, position, this.endianness);
        }
        public void Write(short value, Endianness endianness)
        {
            this.Write(value, this.position, endianness);
            this.position += 2;
        }
        public void Write(short value, int position, Endianness endianness)
        {
            if (endianness == Endianness.BE)
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
