namespace CatTraffic.SystemViewer.Common.Helpers
{
    public class ByteHelper
    {
        public static int CreateIntFromBytes(byte lsb, byte msb)
        {
            var value = (int)msb;
            value <<= 8;
            value += msb;
            return value;
        } 
    }
}