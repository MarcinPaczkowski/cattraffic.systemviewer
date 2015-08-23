using CatTraffic.SystemViewer.DataProcessor.Repositories;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    internal class MainService
    {
        private readonly ExternalDataRepository _externalDataRepository;

        public MainService()
        {
            _externalDataRepository = new ExternalDataRepository();
        }

        internal void Start()
        {
            while (true)
                ProcessFirstExternalData();
        }

        private void ProcessFirstExternalData()
        {
            var firstExternalData = _externalDataRepository.GetFirstUnprocessedData();
        }
    }
}