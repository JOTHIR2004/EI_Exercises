using Exercise2.Core;
using Exercise2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Devices
{
    public class AC : DeviceBase, IDeviceObserver
    {
        public AC(int id) : base(id, "AC") { }

        public void Update(ISmartDevice device, string message)
        {
            if (device is Thermostat thermo)
            {
                if (thermo.Temperature > 80) TurnOn();
                else if (thermo.Temperature < 22) TurnOff();
            }
        }
    }
}
