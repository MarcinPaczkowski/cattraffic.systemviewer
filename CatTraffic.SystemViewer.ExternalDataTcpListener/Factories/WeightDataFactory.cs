using CatTraffic.SystemViewer.ExternalDataTcpListener.Models;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Factories
{
    internal class WeightDataFactory
    {
        internal static WeightData CreateData(byte[] data)
        {
            var instance = new WeightData
            {
                Id = (int)data[8],
                Lane = (int)data[17],
                VehicleType = ByteHelper.CreateIntFromBytes(data[20], data[21]),
                VehicleLength = ByteHelper.CreateIntFromBytes(data[22], data[23]),
                Speed = ByteHelper.CreateIntFromBytes(data[24], data[25]),
                VehicleGap = ByteHelper.CreateIntFromBytes(data[26], data[27]),
                Volation = ByteHelper.CreateIntFromBytes(data[28], data[29]),
                TotalLoad = ByteHelper.CreateIntFromBytes(data[30], data[31]),
            };
            var year = ByteHelper.CreateIntFromBytes(data[10], data[11]);
            var milisecond = ByteHelper.CreateIntFromBytes(data[17], data[18]);
            instance.WeightDate = new DateTime(DateTime.Now.Year, data[12],
                data[13], data[14], data[15], data[16], milisecond);
            return instance;
        }
    }
}
