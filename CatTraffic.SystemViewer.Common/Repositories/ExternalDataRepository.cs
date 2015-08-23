using CatTraffic.SystemViewer.Common.Models;

namespace CatTraffic.SystemViewer.Common.Repositories
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