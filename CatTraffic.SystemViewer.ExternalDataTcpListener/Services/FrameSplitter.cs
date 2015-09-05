using CatTraffic.SystemViewer.ExternalDataTcpListener.Factories;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Models;
using CatTraffic.SystemViewer.ExternalDataTcpListener.Utils;
using System.Linq;

namespace CatTraffic.SystemViewer.ExternalDataTcpListener.Services
{
    public class FrameSplitter
    {
        int _currentPosition;
        byte[] _buffer;
        SplittedData _splittedData;
        const int TRIGGER_DATA_LENGTH = 10;
        

        public SplittedData SplitAndProcess(byte[] buffer)
        {
            _buffer = buffer;
            _splittedData = new SplittedData();
            for (_currentPosition = 0; _currentPosition < buffer.Length; _currentPosition++)
            {
                if (buffer.Length - _currentPosition < 10)
                    break;
                var currentByte = buffer[_currentPosition];
                if (currentByte == 0xA5)
                    _currentPosition += ProcessTriggerFrame();
                else
                {
                    var nextByte = buffer[_currentPosition + 1];
                    if (nextByte == 0x68)
                        _currentPosition += ProcessWeightFrame();
                    else
                        break;
                }
            }
            return _splittedData;
        }

        private int ProcessWeightFrame()
        {
            var lengthLsb = _buffer[_currentPosition + 2];
            var lengthMsb = _buffer[_currentPosition + 3];
            var frameLength = ByteHelper.CreateIntFromBytes(lengthLsb, lengthMsb) + 7;
            var weigthBytes = _buffer.Skip(_currentPosition).Take(frameLength).ToArray();
            var weigthData = WeightDataFactory.CreateData(weigthBytes);
            _splittedData.WeightData.Add(weigthData);
            return frameLength -1;
        }

        private int ProcessTriggerFrame()
        {       
            var triggerbytes = _buffer.Skip(_currentPosition).Take(TRIGGER_DATA_LENGTH).ToArray();
            var triggerData = TriggerDataFactory.CreateData(triggerbytes);
            _splittedData.TriggerData.Add(triggerData);
            return TRIGGER_DATA_LENGTH -1;
        }
    }
}
