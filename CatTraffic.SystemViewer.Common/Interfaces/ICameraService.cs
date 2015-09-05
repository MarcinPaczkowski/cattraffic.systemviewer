using CatTraffic.SystemViewer.Common.Models;

namespace CatTraffic.SystemViewer.Common.Interfaces
{
    public interface ICameraService
    {
        SerializeObject ProcessFirstUnprocessedData();
    }
}