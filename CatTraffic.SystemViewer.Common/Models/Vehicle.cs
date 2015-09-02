using System;
using System.Collections.Generic;

namespace CatTraffic.SystemViewer.Common.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Axles = new List<Axle>();
        }

        public string FileBaseName { get; set; }
        public int SiteID { get; set; }
        public DateTime DateTime { get; set; }
        public int TenthSecond { get; set; }
        public int Lane { get; set; }
        public int Direction { get; set; }
        public int VehTyp { get; set; }
        public int Speed { get; set; }
        public int VehLength { get; set; }
        public int VehGap { get; set; }
        public int Violation { get; set; }
        public string PlateLPR { get; set; }
        public int PlateX { get; set; }
        public int PlateY { get; set; }
        public int PlateWidth { get; set; }
        public int PlateHeight { get; set; }
        public int Confidence { get; set; }
        public int OverviewImageId { get; set; }
        public int PictureNo { get; set; }
        public string PlateADR { get; set; }
        public int TotalLoad { get; set; }
        public int OverloadSA { get; set; }
        public int OverloadMA { get; set; }
        public int OverloadTL { get; set; }
        public int LimitTotalLoad { get; set; }
        public int LimitFirstAxle { get; set; }
        public int LimitSingleAxle { get; set; }
        public int LimitDoubleAxle { get; set; }
        public int LimitTrippleAxle { get; set; }
        public List<Axle> Axles { get; set; }
    }
}