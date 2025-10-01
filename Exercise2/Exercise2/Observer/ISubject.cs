using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Observer
{
    public interface IDeviceSubject
    {
        void RegisterObserver(IDeviceObserver observer);
        void RemoveObserver(IDeviceObserver observer);
        void NotifyObservers(string message);
    }
}
