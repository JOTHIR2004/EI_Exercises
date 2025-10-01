using Smart_Home_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Devices
{
    public class HomeCleaner : DeviceBase
    {
        public HomeCleaner(int id) : base(id, "HomeCleaner") { }

        public void RunMorningShift() => TurnOn();
        public void RunEveningShift() => TurnOn();
    }
}
