using System;

namespace CatTraffic.SystemViewer.Common.Infrasturcture
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class CameraLibrary : Attribute
    {
        public string CameraName { get; set; }

        public CameraLibrary(string cameraName)
        {
            CameraName = cameraName;
        }
    }
}
