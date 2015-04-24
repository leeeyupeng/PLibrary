using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvent
{
    public interface PiEvent
    {
        void DoEvent(params object[] ps);
    }
}
