using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Services;

namespace CatTraffic.SystemViewer.Test
{
    [TestClass]
    public class FrameTests
    {
        [TestMethod]
        public void TestDataSplitter()
        {
            var triggerFrame = new byte[] { 0xA5, 0x01, 1, 2, 12, 24, 06, 0, 10, 0 };

            var splitter = new FrameSplitter();
            var result = splitter.SplitAndProcess(triggerFrame);
        }
    }
}
