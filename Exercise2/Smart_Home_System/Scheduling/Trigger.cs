using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Home_System.Core;

namespace Smart_Home_System.Scheduling
{
    public class Trigger
    {
        public static void ExecuteCondition(Func<bool> condition, Action action)
        {
            if (condition())
            {
                action();
            }
        }
    }

}
