using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatTraffic.SystemViewer.Common.Infrasturcture
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class CameraLibrary : Attribute
    {
        public string CameraName { get; set; }

        public CameraLibrary(string cameraName)
        {
            this.CameraName = cameraName;
        }
    }
}
