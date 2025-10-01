using Smart_Home_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Devices
{
    public class Light : DeviceBase
    {
        public Light(int id) : base(id, "Light") { }
    }
}
