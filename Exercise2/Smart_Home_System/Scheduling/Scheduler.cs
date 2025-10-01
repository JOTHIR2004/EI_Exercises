using Smart_Home_System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_System.Scheduling
{
    public static class Scheduler
    {
        private static List<(ISmartDevice device, string time, Action action)> tasks = new List<(ISmartDevice, string, Action)>();

        public static void SetSchedule(ISmartDevice device, string time, Action action)
        {
            if (device == null) throw new ArgumentNullException(nameof(device));
            if (time == null) throw new ArgumentNullException(nameof(time));
            if (action == null) throw new ArgumentNullException(nameof(action));

            tasks.Add((device, time, action));
        }

        public static void RunSchedule(string currentTime)
        {
            if (currentTime == null) throw new ArgumentNullException(nameof(currentTime));
            foreach (var task in tasks.Where(t => t.time == currentTime))
            {
                task.action.Invoke();
            }
        }
    }
}
