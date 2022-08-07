using System;
using System.Linq;
using System.IO.Ports;
using System.Diagnostics;

namespace ContrastechLightController.Classes
{
    public class VT_LT4_24150PWDC_4
    {
        private SerialPort      _SerialPort;
        private readonly object _ComPortMutex;
        private readonly int    _CommunicationTimeoutMs;

        public VT_LT4_24150PWDC_4(int communicationTimeoutMs = 500)
        {
            _ComPortMutex           = new object();
            _CommunicationTimeoutMs = communicationTimeoutMs;
        }

        public void OpenConnection(string comPortName)
        {
            if (IsConnOpen)
            {
                throw new Exception("There is existing connection to " + _SerialPort.PortName);
            }
            lock (_ComPortMutex)
            {
                _SerialPort = new SerialPort();
                _SerialPort.PortName = comPortName;
                _SerialPort.DataBits = 8;
                _SerialPort.BaudRate = 9600;
                _SerialPort.StopBits = StopBits.One;
                _SerialPort.Parity   = Parity.None;
                _SerialPort.Open();
            }
        }

        public void CloseConnection()
        {
            lock (_ComPortMutex)
            {
                if (IsConnOpen)
                {
                    try
                    {
                        _SerialPort.Close();
                    }
                    catch { }
                }
            }
        }

        public bool IsConnOpen
        {
            get
            {
                return _SerialPort != null && _SerialPort.IsOpen;
            }
        }

        public void SetBrightness(Commands.ChannelWord channel, byte brightness)
        {
            const string SUCCESS_RESPONSE = "#";

            if (IsConnOpen)
            {
                string command = Commands.CHARACTER_WORD + Commands.SET_BRIGHTNESS + ((byte)channel).ToString();
                command += ConvertBrightnessToNormalizedHex(brightness);
                command += XORCheckWord(command);

                lock (_ComPortMutex)
                {
                    _SerialPort.WriteLine(command);

                    Stopwatch watchdog = Stopwatch.StartNew();
                    do
                    {
                        string response = _SerialPort.ReadExisting();

                        if (String.IsNullOrEmpty(response))
                        {
                            continue;
                        }
                        else if (response == SUCCESS_RESPONSE)
                        {
                            return;
                        }
                        else if (response == Commands.FAIL_RESPONSE)
                        {
                            throw new Exception("Controller has failed to receive brightness set command.");
                        }
                        else
                        {
                            throw new Exception("Unexpected response from controller: " + response);
                        }
                    }
                    while (watchdog.ElapsedMilliseconds < _CommunicationTimeoutMs);
                }
                throw new Exception("Controller did not respond.");
            }
            else
            {
                throw new InvalidOperationException("The serial port has not yet opened a connection.");
            }
        }

        public static Commands.ChannelWord ConvertByteToChannelWord(byte value) => (Commands.ChannelWord)Enum.Parse(typeof(Commands.ChannelWord), value.ToString());

        private static string ConvertBrightnessToNormalizedHex(byte brightness)
        {
            string hexBrightness = brightness.ToString("X");
            while (hexBrightness.Length < 3)
            {
                hexBrightness = "0" + hexBrightness;
            }
            return hexBrightness;
        }

        private static string XORCheckWord(string cccd)
        {
            if (cccd.Length != 6)
            {
                throw new FormatException("The input command must be 6 characters long. Passed string: " + cccd);
            }
            byte character = (byte)cccd.ElementAt(0);
            byte command   = (byte)cccd.ElementAt(1);
            byte channel   = (byte)cccd.ElementAt(2);

            byte[] data = new byte[3]
            {
                (byte)cccd.ElementAt(3),
                (byte)cccd.ElementAt(4),
                (byte)cccd.ElementAt(5)
            };
            string xorCheckWord = (character ^ command ^ channel ^ data[0] ^ data[1] ^ data[2]).ToString("X");
            return xorCheckWord;
        }

        public static class Commands
        {
            public const string CHARACTER_WORD   = "#";
            public const string OPEN_CHANNEL     = "1";
            public const string TURN_OFF_CHANNEL = "2";
            public const string SET_BRIGHTNESS   = "3";
            public const string READ_LUMINANCE   = "4";
            public const string FAIL_RESPONSE    = "&";

            public enum ChannelWord : byte
            {
                Channel1 = 1,
                Channel2,
                Channel3,
                Channel4
            }
        }
    }
}
