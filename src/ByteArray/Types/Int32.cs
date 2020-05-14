namespace Soly.Utils
{
    public partial class ByteArray
    {
        public int ReadI32()
        {
            int result = this.ReadI32(this.position, this.endianness);
            this.position += 4;
            return result;
        }
        public int ReadI32(int position)
        {
            int result = this.ReadI32(position, this.endianness);
            return result;
        }
        public int ReadI32(Endianness endianness)
        {
            int result = this.ReadI32(this.position, endianness);
            this.position += 4;
            return result;
        }
        public int ReadI32(int position, Endianness endianness)
        {
            int result = 0;
            if (endianness == Endianness.BE)
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
            return result;
        }

        public void Write(int value)
        {
            this.Write(value, this.position, this.endianness);
            this.position += 4;
        }
        public void Write(int value, int position)
        {
            this.Write(value, position, this.endianness);
        }
        public void Write(int value, Endianness endianness)
        {
            this.Write(value, this.position, endianness);
            this.position += 4;
        }
        public void Write(int value, int position, Endianness endianness)
        {
            if (endianness == Endianness.BE)
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
