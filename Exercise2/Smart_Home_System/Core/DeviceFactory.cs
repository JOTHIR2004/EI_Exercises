using Smart_Home_System.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Core
{
    public static class DeviceFactory
    {
        public static ISmartDevice CreateDevice(string type, int id)
        {
            return type switch
            {
                "Light" => new Light(id),
                "Thermostat" => new Thermostat(id),
                "DoorLock" => new DoorLock(id),
                "AC" => new AC(id),
                "DoorSensorCamera" => new DoorSensorCamera(id),
                "HomeCleaner" => new HomeCleaner(id),
                _ => throw new ArgumentException("Unknown device type")
            };
        }
    }
}
