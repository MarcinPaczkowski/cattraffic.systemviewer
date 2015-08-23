using CatTraffic.SystemViewer.DataProcessor.Models;

namespace CatTraffic.SystemViewer.DataProcessor.Repositories
{
    public class ExternalDataRepository
    {
        public ExternalData GetFirstUnprocessedData()
        {
            var firstExternalData = new ExternalData();
            return firstExternalData;
        }

        public void DeleteProcessedData(int externalDataId)
        {
            // todo delete 
        }
    }
}