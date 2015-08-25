using System;
using CatTraffic.SystemViewer.DataProcessor.Models;

namespace CatTraffic.SystemViewer.DataProcessor.Repositories
{
    public class ExternalDataRepository
    {
        public ExternalData GetFirstUnprocessedData()
        {
            var firstExternalData = new ExternalData();
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