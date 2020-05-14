namespace Soly.Utils
{
    public partial class ByteArray
    {
        public ushort ReadU16()
        {
            ushort result = this.ReadU16(this.position, this.endianness);
            this.position += 2;
            return result;
        }
        public ushort ReadU16(int position)
        {
            ushort result = this.ReadU16(position, this.endianness);
            return result;
        }
        public ushort ReadU16(Endianness endianness)
        {
            ushort result = this.ReadU16(this.position, endianness);
            this.position += 2;
            return result;
        }
        public ushort ReadU16(int position, Endianness endianness)
        {
            ushort result;
            if (endianness == Endianness.BE)
            {
                result = (ushort)(this.buffer[position + 1] | this.buffer[position + 0] << 8);
            }
            else
            {
                result = (ushort)(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            }
            return result;
        }

        public void Write(ushort value)
        {
            this.Write(value, this.position, this.endianness);
            this.position += 2;
        }
        public void Write(ushort value, int position)
        {
            this.Write(value, position, this.endianness);
        }
        public void Write(ushort value, Endianness endianness)
        {
            this.Write(value, this.position, endianness);
            this.position += 2;
        }
        public void Write(ushort value, int position, Endianness endianness)
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
