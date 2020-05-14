namespace Soly.Utils
{
    public partial class ByteArray
    {
        public bool ReadBool()
        {
            bool result = this.ReadBool(this.position);
            this.position += 1;
            return result;
        }
        public bool ReadBool(int position)
        {
            bool result = (this.buffer[position] != 0);
            return result;
        }

        public void Write(bool value)
        {
            this.Write(value, this.position);
            this.position += 1;
        }
        public void Write(bool value, int position)
        {
            this.buffer[position] = (byte)(value ? 1 : 0);
        }
    }
}
