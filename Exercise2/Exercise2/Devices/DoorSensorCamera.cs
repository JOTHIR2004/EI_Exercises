using Exercise2.Core;
using Exercise2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Devices
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
