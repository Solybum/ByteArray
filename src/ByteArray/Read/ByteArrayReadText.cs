using System;

namespace Soly.ByteArray {
    public partial class ByteArray {
        /// <summary>
        /// Read from the ByteArray an ASCII char without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public char ReadCharA(int position) {
            char result = Convert.ToChar(this.buffer[position]);
            return result;
        }
        /// <summary>
        /// Read from the ByteArray an UNICODE char without advancing the internal position
        /// </summary>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public char ReadCharW(int position) {
            char result = Convert.ToChar(this.buffer[position + 0] | this.buffer[position + 1] << 8);
            return result;
        }

        /// <summary>
        /// Read from the ByteArray an ASCII char without advancing the internal position
        /// </summary>
        /// <returns></returns>
        public char ReadCharA() {
            char result = this.ReadCharA(this.position);
            this.position += 1;
            return result;
        }
        /// <summary>
        /// Read from the ByteArray an UNICODE char without advancing the internal position
        /// </summary>
        /// <returns></returns>
        public char ReadCharW() {
            char result = this.ReadCharW(this.position);
            this.position += 2;
            return result;
        }

        /// <summary>
        /// Read from the ByteArray an ASCII string until the target length is reached or a null character is found, without advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public string ReadStringA(int length, int position) {
            string result = "";
            while (length == -1 || result.Length < length) {
                char c = ReadCharA(position);
                if (c == '\0') {
                    break;
                }
                result += c;
                position += 1;
            }
            return result;
        }
        /// <summary>
        /// Read from the ByteArray an UNICODE string until the target length is reached or a null character is found, without advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <param name="position">Position to read from</param>
        /// <returns></returns>
        public string ReadStringW(int length, int position) {
            string result = "";
            while (length == -1 || result.Length < length) {
                char c = ReadCharW(position);
                if (c == '\0') {
                    break;
                }
                result += c;
                position += 2;
            }
            return result;
        }

        /// <summary>
        /// Read from the ByteArray an ASCII string until the target length is reached or a null character is found, advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length, -1 ignores null the character</param>
        /// <returns></returns>
        public string ReadStringA(int length) {
            string result = this.ReadStringA(length, this.position);
            if (length == -1) {
                this.position += result.Length;
            } else {
                this.position += length;
            }
            return result;
        }
        /// <summary>
        /// Read from the ByteArray an UNICODE string until the target length is reached or a null character is found, advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length, -1 ignores null the character</param>
        /// <returns></returns>
        public string ReadStringW(int length) {
            string result = this.ReadStringW(length, this.position);
            if (length == -1) {
                this.position += (result.Length * 2);
            } else {
                this.position += (length * 2);
            }
            return result;
        }
    }
}
