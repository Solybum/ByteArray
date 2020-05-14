using System;

namespace Soly.Utils
{
    public partial class ByteArray
    {
        public string ReadStringW(int length)
        {
            string result = this.ReadStringW(length, this.position);
            if (length == -1)
            {
                this.position += (result.Length * 2);
            }
            else
            {
                this.position += (length * 2);
            }
            return result;
        }
        public string ReadStringW(int length, int position)
        {
            string result = "";
            while (length == -1 || result.Length < length)
            {
                char c = this.ReadCharW(position);
                if (c == '\0')
                {
                    break;
                }
                result += c;
                position += 2;
            }
            return result;
        }

        public void WriteStringW(string text, int index, int length, bool nullTerminated)
        {
            this.WriteStringW(text, index, length, nullTerminated, this.position);
            this.position += (length * 2);
            if (nullTerminated)
            {
                this.position += 2;
            }
        }
        public void WriteStringW(string text, int index, int length, bool nullTerminated, int position)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            length += index;
            while ((index < length) && (index < text.Length))
            {
                this.WriteCharW(text[index], position);
                position += 2;
                index++;
            }
            while (index < length)
            {
                this.WriteCharW('\0', position);
                position += 2;
                index++;
            }
            if (nullTerminated)
            {
                this.WriteCharW('\0', position);
            }
        }

    }
}
