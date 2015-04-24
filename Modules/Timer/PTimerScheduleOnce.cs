using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
namespace PTimer
{
    public class PTimerScheduleOnce : MonoBehaviour
    {
        public float m_startTime;
        public float m_delayTime;
        private Delegate m_callBack;
        void Update()
        {
            float curTime = Time.realtimeSinceStartup;
            if (curTime > m_startTime + m_delayTime)
            {
                Do();
                this.enabled = false;
            }
        }

        public void Init(float delayTime, Delegate callBack)
        {
            m_delayTime = delayTime;
            m_callBack = callBack;
            m_startTime = Time.realtimeSinceStartup;
            this.enabled = true;
        }

        public void Do()
        {
            m_callBack.DynamicInvoke();
        }
    }
}
