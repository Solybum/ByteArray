namespace Soly.Utils
{
    public partial class ByteArray
    {
        public byte ReadU8()
        {
            byte result = this.ReadU8(this.position);
            this.position += 1;
            return result;
        }
        public byte ReadU8(int position)
        {
            byte result = this.buffer[position];
            return result;
        }

        public void Write(byte value)
        {
            this.Write(value, this.position);
            this.position += 1;
        }
        public void Write(byte value, int position)
        {
            this.buffer[position] = value;
        }
    }
}
