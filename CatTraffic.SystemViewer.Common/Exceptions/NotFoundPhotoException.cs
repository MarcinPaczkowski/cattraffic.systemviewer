using System;

namespace CatTraffic.SystemViewer.Common.Exceptions
{
    public class NotFoundPhotoException : Exception
    {
        public NotFoundPhotoException(string message) : base(message) { }
    }
}