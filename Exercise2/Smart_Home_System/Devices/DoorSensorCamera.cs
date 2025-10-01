using Smart_Home_System.Core;
using Smart_Home_System.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Devices
{
    public class DoorSensorCamera : DeviceBase, IDeviceObserver
    {
        public DoorSensorCamera(int id) : base(id, "DoorSensorCamera") { }

        public void Update(ISmartDevice device, string message)
        {
            if (device is DoorLock)
            {
                if (message.Contains("unlocked")) TurnOn();
                else if (message.Contains("locked")) TurnOff();
            }
        }
    }
}
