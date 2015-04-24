using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEvent
{
    public class Singleton<T> where T : new()
    {
        static T m_self;
        public static T self {
            get
            {
                if (m_self == null)
                    m_self = new T();
                return m_self;
            }
        }
    }
}
