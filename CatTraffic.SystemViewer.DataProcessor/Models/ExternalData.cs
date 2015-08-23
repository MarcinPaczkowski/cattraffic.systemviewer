using System;

namespace CatTraffic.SystemViewer.DataProcessor.Models
{
    public class ExternalData
    {
        public int Id { get; set; }
        public int TiggerId { get; set; }
        public DateTime TriggerTime { get; set; }
        public DateTime WieghtDate { get; set; }
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