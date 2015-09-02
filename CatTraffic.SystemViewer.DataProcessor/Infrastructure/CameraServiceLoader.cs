using CatTraffic.SystemViewer.Common.Infrasturcture;
using CatTraffic.SystemViewer.Common.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CatTraffic.SystemViewer.DataProcessor.Infrastructure
{
    internal class CameraServiceLoader
    {
        internal static ICameraService GetCameraService(string cameraName)
        {
            var currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (var dll in Directory.GetFiles(currentPath, "*.dll"))
            {
                var assembly = Assembly.LoadFile(dll);
                foreach (var attribute in assembly.GetCustomAttributes(false))
                {
                    if (attribute.GetType() != typeof (CameraLibrary))
                        continue;
                    var assemblyCameraName = ((CameraLibrary)attribute).CameraName;
                    if (!assemblyCameraName.Equals(cameraName))
                        continue;
                    var cameraType = assembly.GetTypes().FirstOrDefault(type => typeof(ICameraService).IsAssignableFrom(type));
                    if (cameraType == default(Type))
                        continue;
                    var cameraInstance = Activator.CreateInstance(cameraType);
                    return (ICameraService)cameraInstance;
                }   
            }
            throw new Exception("Brak dll z serwisem kamery: " + cameraName);
        }
    }
}
