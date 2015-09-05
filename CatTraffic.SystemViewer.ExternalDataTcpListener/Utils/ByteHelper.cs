using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Utils
{
    internal class ByteHelper
    {
        public static int CreateIntFromBytes(byte lsb, byte msb)
        {
            var value = (int)msb;
            value <<= 8;
            value += lsb;
            return value;
        }
    }
}
