using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvent
{
    public class EventCenter
    {
        Dictionary<string, iEvent> m_dicEvent = new Dictionary<string,iEvent>();

        public void Register(string eventName,iEvent ev)
        {
            m_dicEvent.Add(eventName,ev);
        }

        public void UnRegister(string eventName)
        {
            if(m_dicEvent.ContainsKey(eventName))
            {
                m_dicEvent.Remove(eventName);
            }
        }

        public iEvent StartEvent(string eventName)
        {
            if (m_dicEvent.ContainsKey(eventName))
            {
                return m_dicEvent[eventName];
            }
            return null;
        }
    }
}
