using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace PTimer
{
    public class PTimerSchedule : MonoBehaviour
    {
        public Delegate CallBack { get { return m_callBack; } }
        public float m_startTime;
        public float m_startIntervalTime;
        public float m_delayTime;
        public float m_intervalTime;
        private Delegate m_callBack;
        void Update()
        {
            float curTime = Time.realtimeSinceStartup;
            if (curTime > m_startIntervalTime)
            {
                Do();
                m_startIntervalTime += m_intervalTime;
            }
        }

        public void Init(float delayTime, float interval, Delegate callBack)
        {
            m_delayTime = delayTime;
            m_intervalTime = interval;
            m_callBack = callBack;
            m_startTime = Time.realtimeSinceStartup;
            m_startIntervalTime = m_startTime + m_delayTime;
            this.enabled = true;
        }

        public void Do()
        {
            m_callBack.DynamicInvoke();
        }
    }
}
