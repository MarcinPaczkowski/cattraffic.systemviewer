using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Models
{
    public class WeightData
    {
        public int Id { get; set; }
        public DateTime WeightDate { get; set; }
        public int Lane { get; set; }
        public int Direction { get; set; }
        public int VehicleType { get; set; }
        public int Speed { get; set; }
        public int VehicleLength { get; set; }
        public int VehicleGap { get; set; }
        public int Volation { get; set; }
        public int TotalLoad { get; set; }
        public int OverloadSA { get; set; }
        public int OverloadMA { get; set; }
        public int OverloadTL { get; set; }
    }
}
