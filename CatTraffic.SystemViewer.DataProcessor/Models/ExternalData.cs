using System;

namespace CatTraffic.SystemViewer.DataProcessor.Models
{
    public class ExternalData
    {
        public int Id { get; set; }
        public int TiggerId { get; set; }
        public DateTime TriggerTime { get; set; }

        public int SiteId { get; set; }
        public DateTime DateTime { get; set; }
        public int TenthSecond { get; set; }
        public int Lane { get; set; }
        public int Direction { get; set; }
        public int VehicleType { get; set; }
        public int Speed { get; set; }
        public int VehicleLength { get; set; }
        public int VehicleGap { get; set; }
        public int Violation { get; set; }
        public int TotalLoad { get; set; }
        public int OverloadSa { get; set; }
        public int OverloadMa { get; set; }
        public int OverloadTl { get; set; }
        public int LimitTotalLoad { get; set; }
        public int LimitFirstAxle { get; set; }
        public int LimitSingleAxle { get; set; }
        public int LimitDoubleAxle { get; set; }
        public int LimitTrippleAxle { get; set; }
    }
}