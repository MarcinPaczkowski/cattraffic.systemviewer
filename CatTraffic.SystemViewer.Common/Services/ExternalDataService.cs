using CatTraffic.SystemViewer.Common.Models;
using CatTraffic.SystemViewer.Common.Repositories;

namespace CatTraffic.SystemViewer.Common.Services
{
    public class ExternalDataService
    {
        private readonly ExternalDataRepository _externalDataRepository;

        public ExternalDataService()
        {
            _externalDataRepository = new ExternalDataRepository();
        }

        public SerializeObject GetFirstUnprocessedExternalData()
        {
            return _externalDataRepository.GetFirstUnprocessedData();
        }

        public void DeleteProcessedExternalData(int externalDataId)
        {
            _externalDataRepository.DeleteProcessedData(externalDataId);
        }
    }
}