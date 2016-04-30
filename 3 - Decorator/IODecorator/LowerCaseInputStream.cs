using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IODecorator
{
    public class LowerCaseInputStream : StreamReader
    {
        public LowerCaseInputStream(Stream stream)
            : base(stream)
        {

        }

        public override int Read()
        {
            try
            {
                int c = BaseStream.ReadByte();
                return (c == -1 ? c : char.ToLower((char)c));
            }
            catch (IOException)
            {
                throw;
            }

        }

        public int Read(byte[] b, int offset, int len)
        {
            int result = BaseStream.Read(b, offset, len);
            for (int i = offset; i < offset + result; i++)
            {
                b[i] = (byte)char.ToLower((char)b[i]);
            }
            return result;
        }
    }
}
