using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Core
{
    public interface IDeviceProxy : ISmartDevice
    {
        void Authorize(string key); 
    }
}
