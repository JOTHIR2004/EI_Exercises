using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2.Core;

namespace Exercise2.Scheduling
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
