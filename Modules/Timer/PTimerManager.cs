using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace PTimer
{
    public class PTimerManager
    {
        public void ScheduleOnce(GameObject target,float delayTime,Delegate callback)
        {
            PTimerScheduleOnce schedule = Get<PTimerScheduleOnce>(target);
            schedule.Init(delayTime,callback);
        }

        public void Schedule(GameObject target, float delayTime,float interval, Delegate callback)
        {
            PTimerSchedule schedule = Get<PTimerSchedule>(target);
            schedule.Init(delayTime, interval,callback);
        }

        public void StopSchedule(GameObject target, Delegate callback)
        {
            PTimerSchedule[] coms = target.GetComponents<PTimerSchedule>();
            for (int i = 0; i < coms.Length; i++)
            {
                PTimerSchedule com = coms[i];
                if (com.CallBack == callback)
                {
                    com.enabled = false;
                }
            }
        }

        public void StopScheduleAll(GameObject target)
        {
            SetEnable<PTimerSchedule>(target, false);
        }

        public void SetEnable<T>(GameObject target,bool enable) where T : MonoBehaviour
        {
            T[] coms = target.GetComponents<T>();
            for (int i = 0; i < coms.Length; i++)
            {
                T com = coms[i];
                com.enabled = enable;
            }
        }

        T Get<T>(GameObject target) where T : MonoBehaviour
        {
            T com = target.GetComponent<T>();
            if (com && !com.enabled)
            {
            }
            else
            {
                com = target.AddComponent<T>();
            }
            return com;
        }
    }
}
