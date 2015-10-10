using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lipmon
{
    public interface IDeviceController
    {
        void SendControlToRobot(LeapFrame leapFrame);
        void SetConnectionWithRobot();
    }
}
