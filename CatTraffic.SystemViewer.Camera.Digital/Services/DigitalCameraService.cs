using CatTraffic.SystemViewer.Common.Infrasturcture;
using CatTraffic.SystemViewer.Common.Interfaces;

[assembly: CameraLibrary("DigitalCamera")]
namespace CatTraffic.SystemViewer.Camera.Digital.Services
{
    public class DigitalCameraService : ICameraService
    {
        public void ProcessFirstUnprocessedData()
        {
            throw new System.NotImplementedException();
        }
    }
}