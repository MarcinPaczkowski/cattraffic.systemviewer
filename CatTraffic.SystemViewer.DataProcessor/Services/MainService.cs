using System.Linq;
using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.Common.Interfaces;
using CatTraffic.SystemViewer.Common.Models;
using CatTraffic.SystemViewer.DataProcessor.Infrastructure;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    public class MainService
    {
        private ICameraService _cameraService;
        private readonly DirectoryService _directoryService;

        public MainService()
        {
            _directoryService = new DirectoryService();
        }

        public void Start()
        {
            SetProperietes();
            ConnectionStringHelper.SetConnectionString("CatTrafficConnection");
            _cameraService = CameraServiceLoader.GetCameraService("DigitalCamera");
            var properities = ProgramSettingsHelper.GetProperietes();

            while (true)
            {
                try
                {
                    var processedData = _cameraService.ProcessFirstUnprocessedData();
                    _directoryService.CreateWorkplace(processedData.PhotoPath, properities.DestinationPath, 
                        processedData.Vehicles.First().DateTime);
                }
                catch { }
            }
        }

        private static void SetProperietes()
        {
            var properietes = Properties.Settings.Default;

            ProgramSettingsHelper.SetProperities(new ProgramSettings
            {
                PhotoDirectoryPath = properietes.PhotoDirectoryPath,
                PhotoMaxDelay = properietes.PhotoMaxDelay,
                DestinationPath = properietes.DestinationPath
            });
        }
    }
}