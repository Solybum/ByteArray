using System;

namespace Soly.ByteArray
{
    /// <summary>
    /// Wrapper to ease data type conversions to and from <see cref="byte"/> arrays
    /// </summary>
    public partial class ByteArray
    {
        /// <summary>
        /// Temporary buffer for floats.
        /// It's initialized right away
        /// </summary>
        private byte[] temp = new byte[8];
        /// <summary>
        /// Internal buffer
        /// </summary>
        private byte[] buffer;
        /// <summary>
        /// Internal position
        /// </summary>
        private int position;
        /// <summary>
        /// Internal endianess
        /// </summary>
        private Endianess endianess;

        /// <summary>
        /// Reference to the internal buffer
        /// </summary>
        public byte[] Buffer
        {
            get { return this.buffer; }
        }
        /// <summary>
        /// Length of the internal buffer
        /// </summary>
        public int Length
        {
            get { return this.buffer.Length; }
        }
        /// <summary>
        /// Position in the internal buffer
        /// </summary>
        public int Position
        {
            get { return this.position; }
            set
            {
                if (value < 0 || value > this.buffer.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                this.position = value;
            }
        }
        /// <summary>
        /// Current endianess
        /// </summary>
        public Endianess Endianess
        {
            get { return this.endianess; }
            set { this.endianess = value; }
        }

        /// <summary>
        /// Constructor intializing a new array
        /// </summary>
        /// <param name="size">Size for the internal buffer</param>
        public ByteArray(int size) : this(size, Endianess.LittleEndian)
        {
        }
        /// <summary>
        /// Constructor intializing a new array
        /// </summary>
        /// <param name="size">Size for the internal buffer</param>
        /// <param name="endianess">Default endianess of the ByteArray</param>
        public ByteArray(int size, Endianess endianess)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            this.buffer = new byte[size];
            this.endianess = endianess;
        }
        /// <summary>
        /// Alternative constructor wrapping an already existing array
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        public ByteArray(byte[] byteArray) : this(byteArray, Endianess.LittleEndian)
        {
        }
        /// <summary>
        /// Alternative constructor wrapping an already existing array
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        /// <param name="endianess">Default endianess of the ByteArray</param>
        public ByteArray(byte[] byteArray, Endianess endianess)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray));
            }
            this.buffer = byteArray;
            this.endianess = endianess;
        }
        /// <summary>
        /// Alternative constructor to copy an existing ByteArray
        /// </summary>
        /// <param name="byteArray">ByteArray to copy from</param>
        public ByteArray(ByteArray byteArray)
        {
            this.buffer = new byte[byteArray.Length];
            this.endianess = byteArray.endianess;

            byteArray.position = 0;
            byteArray.Read(this.buffer, 0, this.buffer.Length);
        }

        /// <summary>
        /// Change the size of the internal array
        /// </summary>
        /// <param name="size">New size of the internal array</param>
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

        /// <summary>
        /// Sets all the elements of the array to their default value
        /// and sets the internal position to 0
        /// </summary>
        public void Clear()
        {
            this.Clear(0, this.buffer.Length);
            this.position = 0;
        }
        /// <summary>
        /// Sets a range of elements from the array to their default value
        /// starting from the current position and advances the current position
        /// </summary>
        /// <param name="length">The number of elements to clear</param>
        public void Clear(int length)
        {
            Array.Clear(this.buffer, this.position, length);
            this.position += length;
        }
        /// <summary>
        /// Sets a range of elements from the array to their default value
        /// without advancing the current position
        /// </summary>
        /// <param name="length">Amount of elements to clear</param>
        /// <param name="position">Position to clear from</param>
        public void Clear(int length, int position)
        {
            Array.Clear(this.buffer, position, length);
        }

        /// <summary>
        /// Fills all the byte array with the provided value
        /// </summary>
        /// <param name="value"></param>
        public void Fill(byte value)
        {
            this.Fill(value, 0, this.buffer.Length);
        }
        /// <summary>
        /// Fills a range of elements from the byte array with the provided value starting at index
        /// </summary>
        /// <param name="value">Value to fill in the byte array</param>
        /// <param name="index">Index to start the fill operation</param>
        /// <param name="length">Amount of byes to fill</param>
        public void Fill(byte value, int index, int length)
        {
            for (int i1 = index; i1 < length; i1++)
            {
                this.buffer[i1] = value;
            }
        }

        /// <summary>
        /// Show up to 16 bytes from the current position
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int tslen = this.Length - this.position;
            if (tslen > 16)
            {
                tslen = 16;
            }
            return string.Format("0x{0:X8}: {1}", this.position, BitConverter.ToString(this.buffer, this.position, tslen).Replace("-", " "));
        }

        /// <summary>
        /// Indexer to access the individual bytes
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public byte this[int offset]
        {
            get { return this.buffer[offset]; }
            set { this.buffer[offset] = value; }
        }

        /// <summary>
        /// Advances the internal position until the pad boundary 
        /// is met or the end of the buffer is reached, zeroing 
        /// the padded bytes in the process
        /// </summary>
        /// <param name="padding">Number of bytes to pad</param>
        public void Pad(int padding)
        {
            while ((this.position % padding) != 0 && this.position < this.buffer.Length)
            {
                this.buffer[this.position++] = 0;
            }
        }
    }
}
