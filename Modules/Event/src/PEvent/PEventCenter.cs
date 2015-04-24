using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvent
{
    public class PEventCenter
    {
        Dictionary<string, PiEvent> m_dicEvent = new Dictionary<string, PiEvent>();

        public void Register(string eventName, PiEvent ev)
        {
            m_dicEvent.Add(eventName, ev);
        }

        public void UnRegister(string eventName)
        {
            if (m_dicEvent.ContainsKey(eventName))
            {
                m_dicEvent.Remove(eventName);
            }
        }

        public void DoEvent(string eventName,params object[] ps)
        {
            PiEvent e = GetEvent(eventName);
            e.DoEvent(ps);
        }

        public PiEvent GetEvent(string eventName)
        {
            if (m_dicEvent.ContainsKey(eventName))
            {
                return m_dicEvent[eventName];
            }
            return null;
        }
    }
}
