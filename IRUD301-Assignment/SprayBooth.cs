using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Singleton
namespace IRUD301_Assignment
{
    public sealed class SprayBooth
    {
        private static SprayBooth _instance;
        private static object _lockThis = new object();
        private static object _paintLock = new object(); // ensures one Paint() Method at a time
        public static SprayBooth GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    
                    if (_instance == null)
                    {
                        _instance = new SprayBooth();
                    }
                }
            }
            return _instance;
        }

        public void Paint(Automobile automobile, string colour, Action<string> updateSprayUI)
        {
            lock (_paintLock)
            {
                if (automobile is Car)
                {
                    updateSprayUI($"Spraying {colour} LUX1000");
                    Thread.Sleep(5000);
                }
                else
                {
                    updateSprayUI($"Spraying {colour} MV500");
                    Thread.Sleep(7000);
                }

                automobile.Colour = colour;
                updateSprayUI("Idle");
            }
        }
    }
}
    
