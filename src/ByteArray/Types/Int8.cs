namespace Soly.Utils
{
    public partial class ByteArray
    {
        public sbyte ReadI8()
        {
            sbyte result = this.ReadI8(this.position);
            this.position += 1;
            return result;
        }
        public sbyte ReadI8(int position)
        {
            sbyte result = (sbyte)this.buffer[position];
            return result;
        }

        public void Write(sbyte value)
        {
            this.Write(value, this.position);
            this.position += 1;
        }
        public void Write(sbyte value, int position)
        {
            this.buffer[position] = (byte)value;
        }
    }
}
