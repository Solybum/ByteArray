using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public void Read(byte[] array, int index, int length)
        {
            this.Read(array, index, length, this.position);
            this.position += (length * 1);
        }
        public void Read(byte[] array, int index, int length, int position)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            length += index;
            while (index < length)
            {
                array[index] = this.ReadU8(position);
                position += 1;
                index++;
            }
        }

        public void Write(byte[] array, int index, int length)
        {
            this.Write(array, index, length, this.position);
            this.position += (length * 1);
        }
        public void Write(byte[] array, int index, int length, int position)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            length += index;
            while (index < length)
            {
                this.Write(array[index], position);
                position += 1;
                index++;
            }
        }
    }
}
