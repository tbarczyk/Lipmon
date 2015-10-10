using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lipmon
{
    public class RobotController : IDisposable
    {
        private const int fps = 20;
        private const int delay = 1000/fps;
        LeapListener _leapListener;
        Thread _controlThread;
        IDeviceController deviceController;

        public RobotController(LeapListener leapListener, Device device)
        {
            Console.WriteLine(device.ToString());
            _leapListener = leapListener;

            switch (device)
            {
                case Device.Platform:
                    deviceController = new PlatformController();
                    break;
                case Device.ArmBigger:
                    deviceController = new ArmBiggerController();
                    break;
                case Device.ArmSmaller:
                    deviceController = new ArmSmallerController();
                    break;
            }
            _controlThread = new Thread(controlRobot);
            _controlThread.Start();
        }

        void controlRobot(object obj)
        {
            while (true)
            {
                deviceController.SendControlToRobot(_leapListener.LeapInfo);
                Thread.Sleep(delay);
            }
        }

        public void Dispose()
        {
            _controlThread.Abort();
        }
    }
}
