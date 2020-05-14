namespace Soly.Utils
{
    public partial class ByteArray
    {
        public ushort ReadU16()
        {
            ushort result = this.ReadU16(this.position, this.Endianess);
            this.position += 2;
            return result;
        }
        public ushort ReadU16(int position)
        {
            ushort result = this.ReadU16(position, this.Endianess);
            return result;
        }
        public ushort ReadU16(Endianess endianess)
        {
            ushort result = this.ReadU16(this.position, endianess);
            this.position += 2;
            return result;
        }
        public ushort ReadU16(int position, Endianess endianess)
        {
            ushort result;
            if (endianess == Endianess.BE)
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
            this.Write(value, this.position, this.Endianess);
            this.position += 2;
        }
        public void Write(ushort value, int position)
        {
            this.Write(value, position, this.Endianess);
        }
        public void Write(ushort value, Endianess endianess)
        {
            this.Write(value, this.position, endianess);
            this.position += 2;
        }
        public void Write(ushort value, int position, Endianess endianess)
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
