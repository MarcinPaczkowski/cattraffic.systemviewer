using System;

namespace CatTraffic.SystemViewer.DataProcessor.Exceptions
{
    internal class NotFoundPhotoException : Exception
    {
        internal NotFoundPhotoException(string message) : base(message) { }
    }
}