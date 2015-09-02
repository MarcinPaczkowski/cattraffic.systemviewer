using System.Collections.Generic;

namespace CatTraffic.SystemViewer.Common.Models
{
    public class SerializeObject : ExternalData
    {
        public SerializeObject()
        {
            Vehicles = new List<Vehicle>();
        }

        public int SetType { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}