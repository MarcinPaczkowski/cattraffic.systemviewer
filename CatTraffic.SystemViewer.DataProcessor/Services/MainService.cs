using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.Common.Interfaces;
using CatTraffic.SystemViewer.DataProcessor.Infrastructure;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    public class MainService
    {
        private readonly ExternalDataService _externalDataService;
        private ICameraService _cameraService;

        public MainService()
        {
            _externalDataService = new ExternalDataService();
        }

        public void Start()
        {
            ConnectionStringHelper.SetConnectionString("CatTrafficConnection");
            _cameraService = CameraServiceLoader.GetCameraService("DigitalCamera");
            while (true)
            {
                _externalDataService.ProcessFirstUnprocessedData();
            }
        }
    }
}