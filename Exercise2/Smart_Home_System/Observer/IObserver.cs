using Smart_Home_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Observer
{
    public interface IDeviceObserver
    {
        void Update(ISmartDevice device, string message);
    }
}
