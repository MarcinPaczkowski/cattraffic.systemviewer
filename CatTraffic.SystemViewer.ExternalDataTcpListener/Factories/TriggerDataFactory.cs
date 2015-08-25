using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Factories
{
    internal class TriggerDataFactory
    {
        internal static TriggerData CreateData(byte[] data)
        {
            var instance = new TriggerData
            {
                Id = data[2],
                LineNumber = data[3]
            };
            var milisecond = ByteHelper.CreateIntFromBytes(data[8], data[7]);
            instance.TriggerTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, data[4], data[5], data[6], milisecond);
            return instance;
        }
    }
}
