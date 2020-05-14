namespace Soly.Utils
{
    public partial class ByteArray
    {
        public uint ReadU32()
        {
            uint result = this.ReadU32(this.position, this.Endianess);
            this.position += 4;
            return result;
        }
        public uint ReadU32(int position)
        {
            uint result = this.ReadU32(position, this.Endianess);
            return result;
        }
        public uint ReadU32(Endianess endianess)
        {
            uint result = this.ReadU32(this.position, endianess);
            this.position += 4;
            return result;
        }
        public uint ReadU32(int position, Endianess endianess)
        {
            int result = 0;
            if (endianess == Endianess.BE)
            {
                result |= this.buffer[position + 3];
                result |= this.buffer[position + 2] << 8;
                result |= this.buffer[position + 1] << 16;
                result |= this.buffer[position + 0] << 24;
            }
            else
            {
                result |= this.buffer[position + 0];
                result |= this.buffer[position + 1] << 8;
                result |= this.buffer[position + 2] << 16;
                result |= this.buffer[position + 3] << 24;
            }
            return (uint)result;
        }

        public void Write(uint value)
        {
            this.Write(value, this.position, this.Endianess);
            this.position += 4;
        }
        public void Write(uint value, int position)
        {
            this.Write(value, position, this.Endianess);
        }
        public void Write(uint value, Endianess endianess)
        {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        public void Write(uint value, int position, Endianess endianess)
        {
            if (endianess == Endianess.BE)
            {
                this.buffer[position + 3] = (byte)value;
                this.buffer[position + 2] = (byte)(value >> 8);
                this.buffer[position + 1] = (byte)(value >> 16);
                this.buffer[position + 0] = (byte)(value >> 24);
            }
            else
            {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
                this.buffer[position + 2] = (byte)(value >> 16);
                this.buffer[position + 3] = (byte)(value >> 24);
            }
        }
    }
}
