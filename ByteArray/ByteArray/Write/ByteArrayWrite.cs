using System;

namespace Soly.ByteArray {
    public partial class ByteArray {
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(bool value, int position, Endianess endianess) {
            this.buffer[position] = (byte)(value ? 1 : 0);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(sbyte value, int position, Endianess endianess) {
            this.buffer[position] = (byte)value;
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(byte value, int position, Endianess endianess) {
            this.buffer[position] = value;
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(short value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 1] = (byte)value;
                this.buffer[position + 0] = (byte)(value >> 8);
            } else {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
            }
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(ushort value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 1] = (byte)value;
                this.buffer[position + 0] = (byte)(value >> 8);
            } else {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
            }
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(int value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 3] = (byte)value;
                this.buffer[position + 2] = (byte)(value >> 8);
                this.buffer[position + 1] = (byte)(value >> 16);
                this.buffer[position + 0] = (byte)(value >> 24);
            } else {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
                this.buffer[position + 2] = (byte)(value >> 16);
                this.buffer[position + 3] = (byte)(value >> 24);
            }
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(uint value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 3] = (byte)value;
                this.buffer[position + 2] = (byte)(value >> 8);
                this.buffer[position + 1] = (byte)(value >> 16);
                this.buffer[position + 0] = (byte)(value >> 24);
            } else {
                this.buffer[position + 0] = (byte)value;
                this.buffer[position + 1] = (byte)(value >> 8);
                this.buffer[position + 2] = (byte)(value >> 16);
                this.buffer[position + 3] = (byte)(value >> 24);
            }
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(long value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 7] = (byte)value;
                this.buffer[position + 6] = (byte)(value >> 8);
                this.buffer[position + 5] = (byte)(value >> 16);
                this.buffer[position + 4] = (byte)(value >> 24);
                this.buffer[position + 3] = (byte)(value >> 32);
                this.buffer[position + 2] = (byte)(value >> 40);
                this.buffer[position + 1] = (byte)(value >> 48);
                this.buffer[position + 0] = (byte)(value >> 56);
            } else {
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
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(ulong value, int position, Endianess endianess) {
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 7] = (byte)value;
                this.buffer[position + 6] = (byte)(value >> 8);
                this.buffer[position + 5] = (byte)(value >> 16);
                this.buffer[position + 4] = (byte)(value >> 24);
                this.buffer[position + 3] = (byte)(value >> 32);
                this.buffer[position + 2] = (byte)(value >> 40);
                this.buffer[position + 1] = (byte)(value >> 48);
                this.buffer[position + 0] = (byte)(value >> 56);
            } else {
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
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(float value, int position, Endianess endianess) {
            Array.Copy(BitConverter.GetBytes(value), 0, this.temp, 0, 4);
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 3] = this.temp[0];
                this.buffer[position + 2] = this.temp[1];
                this.buffer[position + 1] = this.temp[2];
                this.buffer[position + 0] = this.temp[3];
            } else {
                this.buffer[position + 0] = this.temp[0];
                this.buffer[position + 1] = this.temp[1];
                this.buffer[position + 2] = this.temp[2];
                this.buffer[position + 3] = this.temp[3];
            }
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(double value, int position, Endianess endianess) {
            Array.Copy(BitConverter.GetBytes(value), 0, this.temp, 0, 8);
            if (endianess == Endianess.BigEndian) {
                this.buffer[position + 7] = this.temp[0];
                this.buffer[position + 6] = this.temp[1];
                this.buffer[position + 5] = this.temp[2];
                this.buffer[position + 4] = this.temp[3];
                this.buffer[position + 3] = this.temp[4];
                this.buffer[position + 2] = this.temp[5];
                this.buffer[position + 1] = this.temp[6];
                this.buffer[position + 0] = this.temp[7];
            } else {
                this.buffer[position + 0] = this.temp[0];
                this.buffer[position + 1] = this.temp[1];
                this.buffer[position + 2] = this.temp[2];
                this.buffer[position + 3] = this.temp[3];
                this.buffer[position + 4] = this.temp[4];
                this.buffer[position + 5] = this.temp[5];
                this.buffer[position + 6] = this.temp[6];
                this.buffer[position + 7] = this.temp[7];
            }
        }

        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(bool value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(sbyte value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(byte value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(short value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(ushort value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(int value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(uint value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(long value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(ulong value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(float value, int position) {
            this.Write(value, position, this.endianess);
        }
        /// <summary>
        /// Write data to the ByteArray without advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(double value, int position) {
            this.Write(value, position, this.endianess);
        }

        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(bool value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(sbyte value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(byte value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(short value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 2;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(ushort value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 2;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(int value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(uint value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(long value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 8;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(ulong value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 8;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(float value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        /// <param name="endianess">Endianess to write in</param>
        public void Write(double value, Endianess endianess) {
            this.Write(value, this.position, endianess);
            this.position += 8;
        }

        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(bool value) {
            this.Write(value, this.position, this.endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(sbyte value) {
            this.Write(value, this.position, this.endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(byte value) {
            this.Write(value, this.position, this.endianess);
            this.position += 1;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(short value) {
            this.Write(value, this.position, this.endianess);
            this.position += 2;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(ushort value) {
            this.Write(value, this.position, this.endianess);
            this.position += 2;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(int value) {
            this.Write(value, this.position, this.endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(uint value) {
            this.Write(value, this.position, this.endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(long value) {
            this.Write(value, this.position, this.endianess);
            this.position += 8;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(ulong value) {
            this.Write(value, this.position, this.endianess);
            this.position += 8;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(float value) {
            this.Write(value, this.position, this.endianess);
            this.position += 4;
        }
        /// <summary>
        /// Write data to the ByteArray advancing the internal position
        /// </summary>
        /// <param name="value">Value to write</param>
        public void Write(double value) {
            this.Write(value, this.position, this.endianess);
            this.position += 8;
        }

        /// <summary>
        /// Write data to the ByteArray from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(byte[] array, int index, int length, int position) {
            length += index;
            while (index < length) {
                Write(array[index], position, this.endianess);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Write data to the ByteArray from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(byte[] array, int index, int length) {
            this.Write(array, index, length, this.position);
            this.position += (length * 1);
        }
    }
}
