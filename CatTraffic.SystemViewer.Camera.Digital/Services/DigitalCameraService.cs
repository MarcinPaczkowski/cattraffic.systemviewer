using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CatTraffic.SystemViewer.Common.Exceptions;
using CatTraffic.SystemViewer.Common.Helpers;
using CatTraffic.SystemViewer.Common.Infrasturcture;
using CatTraffic.SystemViewer.Common.Interfaces;
using CatTraffic.SystemViewer.Common.Models;
using CatTraffic.SystemViewer.Common.Services;

[assembly: CameraLibrary("DigitalCamera")]
namespace CatTraffic.SystemViewer.Camera.Digital.Services
{
    public class DigitalCameraService : ICameraService
    {
        private readonly AnprService _anprService;
        private readonly ExternalDataService _externalDataService;
        private ProgramSettings _properietes;

        public DigitalCameraService()
        {
            _anprService = new AnprService();
            _externalDataService = new ExternalDataService();
        }

        public SerializeObject ProcessFirstUnprocessedData()
        {
            _properietes = ProgramSettingsHelper.GetProperietes();
            var unprocessedData = _externalDataService.GetFirstUnprocessedExternalData();
            unprocessedData.PhotoPath = FindPhotoPathByTriggerDateTime(unprocessedData.Vehicles.First().DateTime);
            unprocessedData = _anprService.GetInfoFromPhoto(unprocessedData);
            _externalDataService.DeleteProcessedExternalData(unprocessedData.Id);

            return unprocessedData;
        }

        private  string FindPhotoPathByTriggerDateTime(DateTime triggerDateTime)
        {
            var photoMaxDelay = _properietes.PhotoMaxDelay;

            var dateTimeRangeDelay = new DateTimeRangeDelay
            {
                Min = triggerDateTime,
                Max = triggerDateTime.AddMilliseconds(photoMaxDelay)
            };

            var photoPath = TryChooseBestDateTimePhoto(dateTimeRangeDelay);
            return photoPath;
        }

        private static IEnumerable<string> GetAllPhotoNameFromDirectory(string path)
        {
            var files = Directory.GetFiles(path, "*.jpg").ToList();
            return files;
        }

        private string TryChooseBestDateTimePhoto(DateTimeRangeDelay dateTimeRangeDelay)
        {
            var pathToDirectory = _properietes.PhotoDirectoryPath;
            var photoPaths = GetAllPhotoNameFromDirectory(pathToDirectory);

            foreach (var path in photoPaths)
            {
                var name = path.Split('\\').Last();
                var splittedName = name.Split('_');
                var date = splittedName[0];
                var time = splittedName[1];
                var nameDateTime = DataTimeHelper.CreateDateTimeFromText(date, time);

                if (nameDateTime >= dateTimeRangeDelay.Min || nameDateTime <= dateTimeRangeDelay.Max)
                    return path;
            }
            throw new PhotoFileNotFoundException();
        }
    }
}