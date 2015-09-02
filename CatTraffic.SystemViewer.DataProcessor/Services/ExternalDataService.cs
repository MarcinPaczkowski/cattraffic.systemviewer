using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CatTraffic.SystemViewer.Common.Exceptions;
using CatTraffic.SystemViewer.Common.Models;
using CatTraffic.SystemViewer.Common.Repositories;
using CatTraffic.SystemViewer.Common.Services;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    public class ExternalDataService
    {
        private readonly ExternalDataRepository _externalDataRepository;
        private readonly AnprService _anprService;

        public ExternalDataService()
        {
            _anprService = new AnprService();
            _externalDataRepository = new ExternalDataRepository();
        }

        public void ProcessFirstUnprocessedData()
        {
            var unprocessedExternalData = GetFirstUnprocessedExternalData();
            var photoPath = FindPhotoPathByTriggerDateTime(unprocessedExternalData.Vehicles.First().DateTime);
            //unprocessedExternalData = _anprService.GetInfoFromPhoto(unprocessedExternalData, photoPath);
            //DeleteProcessedExternalData(unprocessedExternalData.Vehicles.First());
        }

        private SerializeObject GetFirstUnprocessedExternalData()
        {
            return _externalDataRepository.GetFirstUnprocessedData();
        }

        private void DeleteProcessedExternalData(int externalDataId)
        {
            _externalDataRepository.DeleteProcessedData(externalDataId);
        }

        private static string FindPhotoPathByTriggerDateTime(DateTime triggerDateTime)
        {
            var maxDelayPhoto = Properties.Settings.Default.PhotoMaxDelay;

            var dateTimeRangeDelay = new DateTimeRangeDelay
            {
                Min = triggerDateTime,
                Max = triggerDateTime.AddMilliseconds(maxDelayPhoto)
            };

            var photoPath = TryChooseBestDateTimePhoto(dateTimeRangeDelay);
            return photoPath;
        }

        private static IEnumerable<string> GetAllPhotoNameFromDirectory(string path)
        {
            var files = Directory.GetFiles(path, "*.jpg").ToList();
            return files;
        }

        private static string TryChooseBestDateTimePhoto(DateTimeRangeDelay dateTimeRangeDelay)
        {
            var pathToDirectory = Properties.Settings.Default.PhotoDirectoryPath;
            var photoPaths = GetAllPhotoNameFromDirectory(pathToDirectory);

            foreach (var path in photoPaths)
            {
                var name = path.Split('\\').Last();
                var splittedName = name.Split('_');
                var date = splittedName[0];
                var time = splittedName[1];
                var nameDateTime = CreateDateTimeFromName(date, time);

                if (nameDateTime >= dateTimeRangeDelay.Min || nameDateTime <= dateTimeRangeDelay.Max)
                    return path;
            }
            throw new PhotoFileNotFoundException();
        }

        private static DateTime CreateDateTimeFromName(string date, string time)
        {
            //2013 01 07
            var year = Convert.ToInt32(date.Substring(0, 4));
            var month = Convert.ToInt32(date.Substring(4, 2));
            var day = Convert.ToInt32(date.Substring(6, 2));

            //14 00 47 0009
            var hour = Convert.ToInt32(time.Substring(0, 2));
            var minute = Convert.ToInt32(time.Substring(2, 2));
            var second = Convert.ToInt32(time.Substring(4, 2));
            var millisecond = Convert.ToInt32(time.Substring(6, 4));

            var dateTime = new DateTime(year, month, day, hour, minute, second, millisecond);
            return dateTime;
        }
    }
}