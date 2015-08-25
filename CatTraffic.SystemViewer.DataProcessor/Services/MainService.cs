using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.Common.Interfaces;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    public class MainService : ICameraService
    {
        private readonly ExternalDataService _externalDataService;

        public MainService()
        {
            _externalDataService = new ExternalDataService();
        }

        public void Start()
        {
            ConnectionStringHelper.SetConnectionString("CatTrafficConnection");

            while (true)
            {
                _externalDataService.ProcessFirstUnprocessedData();
            }
        }
    }
}