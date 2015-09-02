using System;
using CatTraffic.SystemViewer.Common.Models;

namespace CatTraffic.SystemViewer.Common.Repositories
{
    public class ExternalDataRepository
    {
        public SerializeObject GetFirstUnprocessedData()
        {
            var firstExternalData = new SerializeObject();
            firstExternalData.Vehicles.Add(new Vehicle
            {
                //20130107_14004709_0_1
                DateTime = new DateTime(2013, 01, 07, 14, 00, 46, 0082)
            });
            return firstExternalData;
        }

        public void DeleteProcessedData(int externalDataId)
        {
            // todo delete 
        }
    }
}