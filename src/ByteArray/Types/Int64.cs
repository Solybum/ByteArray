namespace Soly.Utils
{
    public partial class ByteArray
    {
        public long ReadI64()
        {
            long result = this.ReadI64(this.position, this.endianness);
            this.position += 4;
            return result;
        }
        public long ReadI64(int position)
        {
            long result = this.ReadI64(position, this.endianness);
            return result;
        }
        public long ReadI64(Endianness endianness)
        {
            long result = this.ReadI64(this.position, endianness);
            this.position += 4;
            return result;
        }
        public long ReadI64(int position, Endianness endianness)
        {
            long result;
            if (endianness == Endianness.BE)
            {
                result = this.buffer[position + 7];
                result |= (long)this.buffer[position + 6] << 8;
                result |= (long)this.buffer[position + 5] << 16;
                result |= (long)this.buffer[position + 4] << 24;
                result |= (long)this.buffer[position + 3] << 32;
                result |= (long)this.buffer[position + 2] << 40;
                result |= (long)this.buffer[position + 1] << 48;
                result |= (long)this.buffer[position + 0] << 56;
            }
            else
            {
                result = this.buffer[position + 0];
                result |= (long)this.buffer[position + 1] << 8;
                result |= (long)this.buffer[position + 2] << 16;
                result |= (long)this.buffer[position + 3] << 24;
                result |= (long)this.buffer[position + 4] << 32;
                result |= (long)this.buffer[position + 5] << 40;
                result |= (long)this.buffer[position + 6] << 48;
                result |= (long)this.buffer[position + 7] << 56;
            }
            return result;
        }

        public void Write(long value)
        {
            this.Write(value, this.position, this.endianness);
            this.position += 4;
        }
        public void Write(long value, int position)
        {
            this.Write(value, position, this.endianness);
        }
        public void Write(long value, Endianness endianness)
        {
            this.Write(value, this.position, endianness);
            this.position += 4;
        }
        public void Write(long value, int position, Endianness endianness)
        {
            if (endianness == Endianness.BE)
            {
                this.buffer[position + 7] = (byte)value;
                this.buffer[position + 6] = (byte)(value >> 8);
                this.buffer[position + 5] = (byte)(value >> 16);
                this.buffer[position + 4] = (byte)(value >> 24);
                this.buffer[position + 3] = (byte)(value >> 32);
                this.buffer[position + 2] = (byte)(value >> 40);
                this.buffer[position + 1] = (byte)(value >> 48);
                this.buffer[position + 0] = (byte)(value >> 56);
            }
            else
            {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
                this.buffer[position + 2] = (byte)(value >> 16);
                this.buffer[position + 3] = (byte)(value >> 24);
                this.buffer[position + 4] = (byte)(value >> 32);
                this.buffer[position + 5] = (byte)(value >> 40);
                this.buffer[position + 6] = (byte)(value >> 48);
                this.buffer[position + 7] = (byte)(value >> 56);
            }
        }
    }
}
