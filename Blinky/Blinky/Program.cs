using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Blinky
{
    public class Program
    {

        public static void Main()
        {
            var onboardpin = new OutputPort(Pins.GPIO_PIN_D5, true);
            while (true)
            {
                onboardpin.Write(false);
                Thread.Sleep(500);
                onboardpin.Write(true);
                Thread.Sleep(500);
            }
            // write your code here


        }

    }
}
