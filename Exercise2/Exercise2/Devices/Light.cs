using Exercise2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Devices
{
    public class Light : DeviceBase
    {
        public Light(int id) : base(id, "Light") { }
    }
}
