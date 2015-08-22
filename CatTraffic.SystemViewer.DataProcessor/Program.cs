using CatTraffic.SystemViewer.DataProcessor.Services;

namespace CatTraffic.SystemViewer.DataProcessor
{
    class Program
    {
        private static MainService _mainService;

        static void Main()
        {
            _mainService = new MainService();
            _mainService.Start();
        }
    }
}
