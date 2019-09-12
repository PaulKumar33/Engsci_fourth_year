using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace InstrumentWizard
{
    
    class ComCommunication
    {
        public static SerialPort port;
        public static String[] COMPorts;
        public ComCommunication()
        {
            //init the port as null
            port = null;
        }

        public int ComportList()
        {
            COMPorts = SerialPort.GetPortNames();
            if(COMPorts.Length != 0)
            {
                Console.WriteLine("Ports available");
                foreach(string _port in COMPorts)
                {
                    Console.WriteLine(port);
                }
                return 1;
            }
            else
            {
                Console.WriteLine("No comports present");
                return 0;
            }
            
        }

        public void Connect(SerialPort connectPort, Int32 baudRate, bool dtrEnable,
            int readTimeout, int writeTimeout, bool openPort)
        {
            System.ComponentModel.IContainer components = new
                System.ComponentModel.Container();
            port = new SerialPort(components);
            port.PortName = null;
            port.BaudRate = baudRate;
            port.DtrEnable = dtrEnable;
            port.ReadTimeout = 5000;
            port.WriteTimeout = 500;
            port.Open();
        }

        public 
    }

    public void ReadIO()
    {
        while()
    }
}
