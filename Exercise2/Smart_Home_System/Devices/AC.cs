using Smart_Home_System.Core;
using Smart_Home_System.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Devices
{
    public class AC : DeviceBase, IDeviceObserver
    {
        public AC(int id) : base(id, "AC") { }

        public void Update(ISmartDevice device, string message)
        {
            if (device is Thermostat thermo)
            {
                if (thermo.Temperature > 70) TurnOn();
                else if (thermo.Temperature < 22) TurnOff();
            }
        }
    }
}
