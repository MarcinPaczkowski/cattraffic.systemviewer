﻿using System.Linq;
using cm;
using CatTraffic.SystemViewer.Common.Exceptions;
using CatTraffic.SystemViewer.Common.Models;
using gx;

namespace CatTraffic.SystemViewer.Common.Services
{
    public class AnprService
    {
        public SerializeObject GetInfoFromPhoto(SerializeObject anprInfo)
        {
            anprInfo = ProcessPhoto(anprInfo);
            return anprInfo;
        }

        private static SerializeObject ProcessPhoto(SerializeObject anprInfo)
        {
            var anpr = new cmAnpr("default");
            var image = new gxImage("default");

            image.Load(anprInfo.PhotoPath);

            if (!anpr.FindFirst(image))
                throw new NotFoundPhotoException($"Nie znaleziono zdjęcia o ścieżce: {anprInfo.PhotoPath}");
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