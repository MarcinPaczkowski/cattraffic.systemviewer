using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Services;
using System.Collections.Generic;

namespace CatTraffic.SystemViewer.Test
{
    [TestClass]
    public class FrameTests
    {
        [TestMethod]
        public void TestDataSplitter()
        {
            var frame = new List<byte>();
            frame.AddRange(GetWeightFrame());
            var splitter = new FrameSplitter();
            var result = splitter.SplitAndProcess(frame.ToArray());
        }

        private List<byte> GetTriggerFrame()
        {
            return new List<byte> { 0xA5, 0x01, 1, 2, 12, 24, 06, 1, 2, 0 };
        }

        private List<byte> GetWeightFrame()
        {
            return new List<byte>
            {
                0x02, 0x68, 0x2e, 0x00, 0x68,
                0x4d, 0x00, 0x00, 0x00, 0x01,
                0xdf, 0x07, 0x07, 0x0f, 0x0c,
                0x23, 0x23, 0x01, 0x02, 0x01, 0x00, 0x00,
                0x31, 0x1c, 0x2a, 0x00, 0x01, 0x6b,
                0x00, 0x08, 0x00, 0x5b, 0x00,
                0x00, 0x00, 0x00, 0x02, 0x01,
                0x17, 0x00, 0x17, 0x00, 0x6b,
                0x00, 0x01, 0x17, 0x00, 0x17,
                0x00, 0xfa, 0x00, 0xa7, 0x16
            };
        }
    }
}
