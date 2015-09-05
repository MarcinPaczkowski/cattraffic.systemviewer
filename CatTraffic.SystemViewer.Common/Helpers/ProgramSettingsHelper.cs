using System;
using CatTraffic.SystemViewer.Common.Models;

namespace CatTraffic.SystemViewer.Common.Helpers
{
    public class ProgramSettingsHelper
    {
        private static ProgramSettings _properietes;

        public static void SetProperities(ProgramSettings properities)
        {
            _properietes = properities;
        }

        public static ProgramSettings GetProperietes()
        {
            if (_properietes == null)
                throw new Exception("Nie ustawionowo parametrów programu!");
            return _properietes;
        }
    }
}