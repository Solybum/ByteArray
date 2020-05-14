using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        private byte[] temp = new byte[8];
        private byte[] buffer;
        private int position;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1819:Properties should not return arrays", Justification = "The user might want access to the internal buffer to use without relying in the ByteArray's array methods to pass into their own functions")]
        public byte[] Buffer
        {
            get { return this.buffer; }
        }
        public int Length
        {
            get
            {
                return this.buffer.Length;
            }
        }
        public int Position
        {
            get
            {
                return this.position;
            }
            set
            {
                if (value < 0 || value > this.buffer.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                this.position = value;
            }
        }
        public Endianess Endianess { get; set; }

        public ByteArray(int size) : this(size, Endianess.LE)
        {
        }
        public ByteArray(int size, Endianess endianess)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            this.buffer = new byte[size];
            this.Endianess = endianess;
        }
        public ByteArray(byte[] byteArray) : this(byteArray, Endianess.LE)
        {
        }
        public ByteArray(byte[] byteArray, Endianess endianess)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray));
            }
            this.buffer = byteArray;
            this.Endianess = endianess;
        }
        public ByteArray(ByteArray byteArray)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray));
            }

            this.buffer = new byte[byteArray.Length];
            this.Endianess = byteArray.Endianess;

            byteArray.position = 0;
            Array.Copy(byteArray.Buffer, this.Buffer, byteArray.Length);
        }

        public void Resize(int size)
        {
            if (size == this.buffer.Length)
            {
                return;
            }
            if (size < 0 || size > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            Array.Resize(ref this.buffer, size);
            if (this.position > size)
            {
                this.position = size;
            }
        }
        public void Clear()
        {
            this.Clear(this.buffer.Length, 0);
            this.position = 0;
        }
        public void Clear(int length)
        {
            Array.Clear(this.buffer, this.position, length);
            this.position += length;
        }
        public void Clear(int length, int position)
        {
            Array.Clear(this.buffer, position, length);
        }

        public void Fill(byte value)
        {
            this.Fill(value, 0, this.buffer.Length);
        }
        public void Fill(byte value, int index, int length)
        {
            for (int i1 = index; i1 < length; i1++)
            {
                this.buffer[i1] = value;
            }
        }
        public override string ToString()
        {
            int tslen = this.Length - this.position;
            if (tslen > 16)
            {
                tslen = 16;
            }
            return $"0x{this.position:X8}: {BitConverter.ToString(this.buffer, this.position, tslen).Replace("-", " ")}";
        }
        public byte this[int offset]
        {
            get { return this.buffer[offset]; }
            set { this.buffer[offset] = value; }
        }
        public void Pad(int padding)
        {
            while ((this.position % padding) != 0 && this.position < this.buffer.Length)
            {
                this.buffer[this.position++] = 0;
            }
        }
    }
}
