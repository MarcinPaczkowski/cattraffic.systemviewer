using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Models;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Repositories;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Services
{
    class HandleRequest
    {
        TcpClient _clientConnection;
        NetworkStream _networkStream = null;
        FrameSplitter _splitter = new FrameSplitter();
        DataRepository _dataRepository = new DataRepository();

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
            byte[] buffer = new byte[Properties.Settings.Default.MaxFrameSize];
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

                var buffer = result.AsyncState as byte[];
                var data = _splitter.SplitAndProcess(buffer);
                SaveData(data);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void SaveData(SplittedData data)
        {
            data.TriggerData.ForEach(t => _dataRepository.SaveTriggerData(t));
            data.WeightData.ForEach(w => _dataRepository.SaveWeigthData(w));
        }
    }
}
