using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;


namespace InstrumentWizard
{
    class Microphone
    {
        //this is the main class to access microphones for audio recording

        public static WaveIn waveIn;
        public Microphone()
        {
            //constructor

        }

        public static void InitMicrophone()
        {
            waveIn = new WaveIn();
        }
    }
}
