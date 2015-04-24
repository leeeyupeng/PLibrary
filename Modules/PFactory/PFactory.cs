using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFactory
{
    public class PFactory<T> where T : PiProduct
    {
        List<PiProduct> m_cacheList = new List<PiProduct>();

        public T GetInstance()
        {
            for (int i = 0; i < m_cacheList.Count; i++)
            {
                if (!m_cacheList[i].IsActive())
                    return (T)m_cacheList[i];
            }

            PiProduct p = Activator.CreateInstance<T>();
            m_cacheList.Add(p);
            return (T)p;
        }
    }
}
