using System;
using CatTraffic.SystemViewer.DataProcessor.Services;

namespace CatTraffic.SystemViewer.DataProcessor
{
    class Program
    {
        private static MainService _mainService;

        static void Main()
        {
            try
            {
                _mainService = new MainService();
                _mainService.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Krytyczny błąd programu - {0}", ex.Message);
            }
        }
    }
}
