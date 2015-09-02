using CatTraffic.SystemViewer.Common.Infrasturcture;
using CatTraffic.SystemViewer.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CatTraffic.SystemViewer.DataProcessor.Infrastructure
{
    internal class CameraServiceLoader
    {
        internal static ICameraService GetCameraService(string cameraName)
        {
            var currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            foreach (string dll in Directory.GetFiles(currentPath, "*.dll"))
            {
                var assembly = Assembly.LoadFile(dll);
                foreach (var attribute in assembly.GetCustomAttributes(false))
                {
                    if(attribute.GetType() == typeof(CameraLibrary))
                    {
                        var assemblyCameraName = ((CameraLibrary)attribute).CameraName;
                        if(assemblyCameraName.Equals(cameraName))
                        {
                            var Icamera = assembly.GetTypes().FirstOrDefault(type => typeof(ICameraService).IsAssignableFrom(type));
                            if (Icamera != default(Type))
                            {
                                var cameraInstance = Activator.CreateInstance(Icamera);
                                return (ICameraService)cameraInstance;
                            }
                        }
                    }
                }   
            }
            throw new Exception("Brak dll z serwisem kamery: " + cameraName);
        }
    }
}
