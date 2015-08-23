using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.Common.Repositories;

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
            var value = ByteHelper.CreateIntFromBytes(1, 1);
            //while (true)
            //    ProcessFirstExternalData();
        }

        private void ProcessFirstExternalData()
        {
            var firstExternalData = _externalDataRepository.GetFirstUnprocessedData();
        }
    }
}