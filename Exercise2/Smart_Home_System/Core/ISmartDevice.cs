using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Core
{
    public interface ISmartDevice
    {
        int Id { get; }
        string Name { get; }
        void TurnOn();   
        void TurnOff();
        string GetStatus();
    }
}
