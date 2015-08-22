using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Services
{
    class HandleRequest
    {
        TcpClient _clientConnection;
        NetworkStream _networkStream = null;

        public HandleRequest(TcpClient clientConnection)
        {
            _clientConnection = clientConnection;
        }

        public void ReadClientData()
        {
            _networkStream = _clientConnection.GetStream();
            WaitForRequest();
        }

        private void WaitForRequest()
        {
            byte[] buffer = new byte[_clientConnection.ReceiveBufferSize];
            _networkStream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);
        }

        private void ReadCallback(IAsyncResult result)
        {
            NetworkStream networkStream = _clientConnection.GetStream();
            try
            {
                int read = networkStream.EndRead(result);
                if (read == 0)
                {
                    _networkStream.Close();
                    _clientConnection.Close();
                    return;
                }

                byte[] buffer = result.AsyncState as byte[];
                Console.WriteLine("czytam");
                //string data = Encoding.Default.GetString(buffer, 0, read);

                //do the job with the data here
                //send the data back to client.
                //Byte[] sendBytes = Encoding.ASCII.GetBytes("Processed " + data);
                //networkStream.Write(sendBytes, 0, sendBytes.Length);
                //networkStream.Flush();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
