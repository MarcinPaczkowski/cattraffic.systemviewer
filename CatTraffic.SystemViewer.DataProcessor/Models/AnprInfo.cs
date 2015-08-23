using System.Collections.Generic;

namespace CatTraffic.SystemViewer.DataProcessor.Models
{
    public class AnprInfo
    {
        public AnprInfo()
        {
            Vehicles = new List<Vehicle>();
        }

        public int SetType { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}