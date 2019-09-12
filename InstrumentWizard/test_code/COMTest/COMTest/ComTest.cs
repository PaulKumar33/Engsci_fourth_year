using System;
using System.IO;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace COMTest
{

    class ATMega2560
    {
        public static Int32 baudRate = 9600;
        public static bool dtrEnable = true;
        public static int readTimeout = 5000;
        public static int writeTimeout = 500;
    }

    class JsonOperator
    {
        string fileName;
        public JsonOperator(string file)
        {
            FileInfo extension = new FileInfo(file);
            if(extension.Extension != ".json" || extension.Name != "init")
            {
                throw new ArgumentException("no init json");
            }
            fileName = file;
        }

        public Dictionary<string, object> ReadJson()
        {
            Dictionary<string, object> results = null;
            try
            {
                using (StreamReader readObj = new StreamReader(fileName))
                {
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception thrown");
                Console.WriteLine(e);

            }

            return results;
        }
    }

    class ComTest
    {

        String[] devices = {"ATMega2560"};
        private static Dictionary<string, int> controllerLUT = new Dictionary<string,int>();
        

        public ComTest(string DeviceType)
        {
            //initialize the class. initalize parameters based off of the controller being used
            controllerLUT.Add("ATMega2560", 0);
        }

        public void COMPortList()
        {

        }

        public void ConnectDevice()
        {

        }

        public void Read()
        {

        }

        public void Write()
        {

        }

        public void GPIOAccess()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Testing COM communication");
        }

        
    }
}
