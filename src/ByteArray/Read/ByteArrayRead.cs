using System;

namespace Soly.ByteArray {
    public partial class ByteArray {
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public bool ReadBool(int position, Endianess endianess) {
            bool result = (this.buffer[position] != 0);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public sbyte ReadI8(int position, Endianess endianess) {
            sbyte result = (sbyte)this.buffer[position];
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public byte ReadU8(int position, Endianess endianess) {
            byte result = this.buffer[position];
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public short ReadI16(int position, Endianess endianess) {
            short result;
            if (endianess == Endianess.BigEndian) {
                result = (short)(this.buffer[position + 1] | this.buffer[position + 0] << 8);
            } else {
                result = (short)(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            }
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public ushort ReadU16(int position, Endianess endianess) {
            ushort result;
            if (endianess == Endianess.BigEndian) {
                result = (ushort)(this.buffer[position + 1] | this.buffer[position + 0] << 8);
            } else {
                result = (ushort)(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            }
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public int ReadI32(int position, Endianess endianess) {
            int result;
            if (endianess == Endianess.BigEndian) {
                result = (this.buffer[position + 3] | this.buffer[position + 2] << 8 | this.buffer[position + 1] << 16 | this.buffer[position + 0] << 24);
            } else {
                result = (this.buffer[position + 0] | this.buffer[position + 1] << 8 | this.buffer[position + 2] << 16 | this.buffer[position + 3] << 24);
            }
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public uint ReadU32(int position, Endianess endianess) {
            uint result;
            if (endianess == Endianess.BigEndian) {
                result = (uint)(this.buffer[position + 3] | this.buffer[position + 2] << 8 | this.buffer[position + 1] << 16 | this.buffer[position + 0] << 24);
            } else {
                result = (uint)(this.buffer[position + 0] | this.buffer[position + 1] << 8 | this.buffer[position + 2] << 16 | this.buffer[position + 3] << 24);
            }
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public long ReadI64(int position, Endianess endianess) {
            uint lo;
            uint hi;
            if (endianess == Endianess.BigEndian) {
                lo = (uint)(this.buffer[position + 7] | this.buffer[position + 6] << 8 | this.buffer[position + 5] << 16 | this.buffer[position + 4] << 24);
                hi = (uint)(this.buffer[position + 3] | this.buffer[position + 2] << 8 | this.buffer[position + 1] << 16 | this.buffer[position + 0] << 24);
            } else {
                lo = (uint)(this.buffer[position + 0] | this.buffer[position + 1] << 8 | this.buffer[position + 2] << 16 | this.buffer[position + 3] << 24);
                hi = (uint)(this.buffer[position + 4] | this.buffer[position + 5] << 8 | this.buffer[position + 6] << 16 | this.buffer[position + 7] << 24);
            }
            long result = (long)((ulong)hi) << 32 | lo;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public ulong ReadU64(int position, Endianess endianess) {
            uint lo;
            uint hi;
            if (endianess == Endianess.BigEndian) {
                lo = (uint)(this.buffer[position + 7] | this.buffer[position + 6] << 8 | this.buffer[position + 5] << 16 | this.buffer[position + 4] << 24);
                hi = (uint)(this.buffer[position + 3] | this.buffer[position + 2] << 8 | this.buffer[position + 1] << 16 | this.buffer[position + 0] << 24);
            } else {
                lo = (uint)(this.buffer[position + 0] | this.buffer[position + 1] << 8 | this.buffer[position + 2] << 16 | this.buffer[position + 3] << 24);
                hi = (uint)(this.buffer[position + 4] | this.buffer[position + 5] << 8 | this.buffer[position + 6] << 16 | this.buffer[position + 7] << 24);
            }
            ulong result = ((ulong)hi) << 32 | lo;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public float ReadF32(int position, Endianess endianess) {
            float result;
            if (endianess == Endianess.BigEndian) {
                this.temp[0] = this.buffer[position + 3];
                this.temp[1] = this.buffer[position + 2];
                this.temp[2] = this.buffer[position + 1];
                this.temp[3] = this.buffer[position + 0];
                result = BitConverter.ToSingle(this.temp, 0);
            } else {
                result = BitConverter.ToSingle(this.buffer, position);
            }
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public double ReadF64(int position, Endianess endianess) {
            double result;
            if (endianess == Endianess.BigEndian) {
                this.temp[0] = this.buffer[position + 7];
                this.temp[1] = this.buffer[position + 6];
                this.temp[2] = this.buffer[position + 5];
                this.temp[3] = this.buffer[position + 4];
                this.temp[4] = this.buffer[position + 3];
                this.temp[5] = this.buffer[position + 2];
                this.temp[6] = this.buffer[position + 1];
                this.temp[7] = this.buffer[position + 0];
                result = BitConverter.ToDouble(this.temp, 0);
            } else {
                result = BitConverter.ToDouble(this.buffer, position);
            }
            return result;
        }

        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public bool ReadBool(int position) {
            bool result = this.ReadBool(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public sbyte ReadI8(int position) {
            sbyte result = this.ReadI8(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public byte ReadU8(int position) {
            byte result = this.ReadU8(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public short ReadI16(int position) {
            short result = this.ReadI16(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public ushort ReadU16(int position) {
            ushort result = this.ReadU16(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public int ReadI32(int position) {
            int result = this.ReadI32(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public uint ReadU32(int position) {
            uint result = this.ReadU32(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public long ReadI64(int position) {
            long result = this.ReadI64(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public ulong ReadU64(int position) {
            ulong result = this.ReadU64(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public float ReadF32(int position) {
            float result = this.ReadF32(position, this.endianess);
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public double ReadF64(int position) {
            double result = this.ReadF64(position, this.endianess);
            return result;
        }

        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public bool ReadBool(Endianess endianess) {
            bool result = this.ReadBool(this.position, endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public sbyte ReadI8(Endianess endianess) {
            sbyte result = this.ReadI8(this.position, endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public byte ReadU8(Endianess endianess) {
            byte result = this.ReadU8(this.position, endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public short ReadI16(Endianess endianess) {
            short result = this.ReadI16(this.position, endianess);
            this.position += 2;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public ushort ReadU16(Endianess endianess) {
            ushort result = this.ReadU16(this.position, endianess);
            this.position += 2;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public int ReadI32(Endianess endianess) {
            int result = this.ReadI32(this.position, endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public uint ReadU32(Endianess endianess) {
            uint result = this.ReadU32(this.position, endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public long ReadI64(Endianess endianess) {
            long result = this.ReadI64(this.position, endianess);
            this.position += 8;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public ulong ReadU64(Endianess endianess) {
            ulong result = this.ReadU64(this.position, endianess);
            this.position += 8;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public float ReadF32(Endianess endianess) {
            float result = this.ReadF32(this.position, endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <param name="endianess">Endianess to read with</param>
        /// <returns></returns>
        public double ReadF64(Endianess endianess) {
            double result = this.ReadF64(this.position, endianess);
            this.position += 8;
            return result;
        }

        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public bool ReadBool() {
            bool result = this.ReadBool(this.position, this.endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public sbyte ReadI8() {
            sbyte result = this.ReadI8(this.position, this.endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public byte ReadU8() {
            byte result = this.ReadU8(this.position, this.endianess);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public short ReadI16() {
            short result = this.ReadI16(this.position, this.endianess);
            this.position += 2;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ushort ReadU16() {
            ushort result = this.ReadU16(this.position, this.endianess);
            this.position += 2;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public int ReadI32() {
            int result = this.ReadI32(this.position, this.endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public uint ReadU32() {
            uint result = this.ReadU32(this.position, this.endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public long ReadI64() {
            long result = this.ReadI64(this.position, this.endianess);
            this.position += 8;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ulong ReadU64() {
            ulong result = this.ReadU64(this.position, this.endianess);
            this.position += 8;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public float ReadF32() {
            float result = this.ReadF32(this.position, this.endianess);
            this.position += 4;
            return result;
        }
        /// <summary>
        /// Read data from the ByteArray data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public double ReadF64() {
            double result = this.ReadF64(this.position, this.endianess);
            this.position += 8;
            return result;
        }

        /// <summary>
        /// Read data from the ByteArray data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(byte[] array, int index, int length, int position) {
            length += index;
            while (index < length) {
                array[index] = ReadU8(position, this.endianess);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Read data from the ByteArray data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(byte[] array, int index, int length) {
            this.Read(array, index, length, this.position);
            this.position += (length * 1);
        }
    }
}
