using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Models
{
    public class SplittedData
    {
        public List<TriggerData> TriggerData { get; set; }
        public List<WeightData> WeightData { get; set; }
        public SplittedData()
        {
            TriggerData = new List<TriggerData>();
            WeightData = new List<WeightData>();
        }
    }
}
