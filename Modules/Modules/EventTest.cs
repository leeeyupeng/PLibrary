using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEvent;

namespace Modules
{
    public class EventTest : iEvent
    {
        public delegate void Void();
        object[] m_params;
        public void SetParams(params object[] ps)
        {
            m_params = ps;
        }

        public void DoEvent()
        {
            Console.WriteLine("Param0:" + m_params[0].ToString());
            Console.WriteLine("Param2:" + m_params[2].ToString());

            Void func = (Void)m_params[1];
            func();
        }
    }

    public class EventProgram
    {
        public static void TestMain()
        {
            Test(new EventTest.Void(CallBack));

            Singleton<EventCenter>.self.Register("EventTest", new EventTest());

            iEvent e = Singleton<EventCenter>.self.StartEvent("EventTest");
            e.SetParams("hello world", new EventTest.Void(CallBack), "hello world 2");
            e.DoEvent();

        }

        public static void CallBack()
        {
            Console.WriteLine("hello world callback");
        }

        public static void Test(EventTest.Void func)
        {
            Console.WriteLine("hello world callbackTest");
        }
    }
}
