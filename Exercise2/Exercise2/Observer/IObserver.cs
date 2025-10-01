using Exercise2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Observer
{
    public interface IDeviceObserver
    {
        void Update(ISmartDevice device, string message);
    }
}
