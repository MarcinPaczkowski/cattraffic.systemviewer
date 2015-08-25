﻿using System.Linq;
using cm;
using CatTraffic.SystemViewer.DataProcessor.Exceptions;
using CatTraffic.SystemViewer.DataProcessor.Models;
using gx;

namespace CatTraffic.SystemViewer.DataProcessor.Services
{
    public class AnprService
    {
        public ExternalData GetInfoFromPhoto(ExternalData anprInfo, string pathToPhoto)
        {
            anprInfo = ProcessPhoto(anprInfo, pathToPhoto);
            return anprInfo;
        }

        private static ExternalData ProcessPhoto(ExternalData anprInfo, string path)
        {
            var anpr = new cmAnpr("default");
            var image = new gxImage("default");

            image.Load(path);

            if (!anpr.FindFirst(image))
                throw new NotFoundPhotoException($"Nie znaleziono zdjęcia o ścieżce: {path}");
            var frame = anpr.GetFrame();

            anprInfo.Vehicles.First().PlateLPR = anpr.GetText();
            anprInfo.Vehicles.First().Confidence = anpr.GetConfidence();
            anprInfo.Vehicles.First().PlateX = frame.x1;
            anprInfo.Vehicles.First().PlateY = frame.y1;
            //anprInfo.Vehicles.First().PlateHeight = ;
            //anprInfo.Vehicles.First().PlateWidth = ;

            //while (anpr.FindNext())
            //{
            //    frame = anpr.GetFrame();
            //    anprInfo.Vehicles.Add(new Vehicle
            //    {
            //        PlateLPR = anpr.GetText(),
            //        Confidence = anpr.GetConfidence(),
            //        PlateX = frame.x1,
            //        PlateY = frame.y1,
            //        //PlateHeight = 
            //        //PlateWidth = 
            //    });
            //}

            return anprInfo;
        }
    }
}