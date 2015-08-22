using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Models
{
    public class TriggerData
    {
        public int Id { get; set; }
        public int LineNumber { get; set; }
        public DateTime TriggerTime { get; set; }
    }
}
