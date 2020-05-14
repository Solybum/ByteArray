using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public string ReadStringA(int length)
        {
            string result = this.ReadStringA(length, this.position);
            if (length == -1)
            {
                this.position += result.Length;
            }
            else
            {
                this.position += length;
            }
            return result;
        }
        public string ReadStringA(int length, int position)
        {
            string result = "";
            while (length == -1 || result.Length < length)
            {
                char c = this.ReadCharA(position);
                if (c == '\0')
                {
                    break;
                }
                result += c;
                position += 1;
            }
            return result;
        }

        public void WriteStringA(string text, int index, int length, bool nullTerminated)
        {
            this.WriteStringA(text, index, length, nullTerminated, this.position);
            this.position += length;
            if (nullTerminated)
            {
                this.position += 1;
            }
        }
        public void WriteStringA(string text, int index, int length, bool nullTerminated, int position)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            length += index;
            while ((index < length) && (index < text.Length))
            {
                this.WriteCharA(text[index], position);
                position += 1;
                index++;
            }
            while (index < length)
            {
                this.WriteCharA('\0', position);
                position += 1;
                index++;
            }
            if (nullTerminated)
            {
                this.WriteCharA('\0', position);
            }
        }
    }
}
