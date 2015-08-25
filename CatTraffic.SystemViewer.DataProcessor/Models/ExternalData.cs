using System.Collections.Generic;

namespace CatTraffic.SystemViewer.DataProcessor.Models
{
    public class ExternalData
    {
        public ExternalData()
        {
            Vehicles = new List<Vehicle>();
        }

        public int SetType { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}