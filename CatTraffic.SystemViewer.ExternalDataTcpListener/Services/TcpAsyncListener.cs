using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Services
{
    internal class TcpAsyncListener
    {
        private static TcpListener _listener;

        public static void StartServer()
        {
            var ipAddress = IPAddress.Parse(Properties.Settings.Default.IpAddress);
            var port = Convert.ToInt32(Properties.Settings.Default.Port);
            var ipLocal = new IPEndPoint(ipAddress, port);
            _listener = new TcpListener(ipLocal);
            _listener.Start();
            WaitForConnections();
        }

        private static void WaitForConnections()
        {
            var stateObject = new object();
            _listener.BeginAcceptTcpClient(new AsyncCallback(OnConnection), stateObject);
        }

        private static void OnConnection(IAsyncResult ar)
        {
            try
            {
                var clientSocket = default(TcpClient);
                clientSocket = _listener.EndAcceptTcpClient(ar);
                var handleRequest = new HandleRequest(clientSocket);
                handleRequest.ReadClientData();
            }
            catch(Exception ex)
            {
                //logowanie błędu
            }
            WaitForConnections();
        }
    }
}
