﻿using CatTraffic.SystemViewer.ExternalDataTcpListener.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpAsyncListener.StartServer();
            Console.ReadKey();
        }
    }
}
