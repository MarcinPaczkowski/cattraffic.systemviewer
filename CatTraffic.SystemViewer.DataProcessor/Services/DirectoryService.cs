using System;
using System.IO;
using System.Linq;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    internal class DirectoryService
    {
        internal void CreateWorkplace(string photoPath, string workplacePath, DateTime creationDateTime)
        {
            var directoryPath = CreateDirectory(workplacePath, creationDateTime);
            CopyPhoto(photoPath, directoryPath);
        }

        private static string CreateDirectory(string workplacePath, DateTime creationDateTime)
        {
            var path = $@"{workplacePath}/{creationDateTime.ToString("yyyymmmmmdd_HHmmssffff")}";
            Directory.CreateDirectory(path);
            return path;
        }

        private static void CopyPhoto(string sourcePath, string destinationPath)
        {
            var fileName = sourcePath.Split('\\').Last();
            destinationPath = $@"{destinationPath}\{fileName}";
            File.Copy(sourcePath, destinationPath);
            File.Delete(sourcePath);
        }
    }
}