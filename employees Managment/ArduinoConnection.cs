﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_Managment
{
    internal class ArduinoConnection
    {
        private string portName;
        private SerialPort port;

        public ArduinoConnection(string portName)
        {
            this.portName = portName;
            this.port = new SerialPort(portName);
        }

        public void Open()
        {
            if (!port.IsOpen)
            {
                port.Open();
                Console.WriteLine($"Opened Arduino port {portName}.");
            }
            else
            {
                Console.WriteLine($"Arduino port {portName} is already open.");
            }
        }

        public void Close()
        {
            if (port.IsOpen)
            {
                port.Close();
                Console.WriteLine($"Closed Arduino port {portName}.");
            }
            else
            {
                Console.WriteLine($"Arduino port {portName} is already closed.");
            }
        }

        public void SendData(string data)
        {
            if (port.IsOpen)
            {
                port.WriteLine(data);
                Console.WriteLine($"Sent data to Arduino: {data}");
            }
            else
            {
                Console.WriteLine($"Cannot send data to Arduino, port {portName} is not open.");
            }
        }

        public string ReceiveData()
        {
            if (port.IsOpen)
            {
                string data = port.ReadLine();
                Console.WriteLine($"Received data from Arduino: {data}");
                return data;
            }
            else
            {
                Console.WriteLine($"Cannot receive data from Arduino, port {portName} is not open.");
                return null;
            }
        }

    }
}

//public class ArduinoConnection
//{
  
//}
