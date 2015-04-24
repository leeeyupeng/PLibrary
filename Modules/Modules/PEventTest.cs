using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEvent;
namespace Modules
{
    public class PEventTest : PiEvent
    {
        public delegate void Void();

        public void DoEvent(params object[] ps)
        {
            object[] m_params = ps;
            Console.WriteLine("Param0:" + m_params[0].ToString());
            Console.WriteLine("Param2:" + m_params[2].ToString());

            Void func = (Void)m_params[1];
            func();
        }
    }

    public class PEventProgram
    {
        public static void TestMain()
        {
            Test(new PEventTest.Void(CallBack));

            Singleton<PEventCenter>.self.Register("EventTest", new PEventTest());

            Singleton<PEventCenter>.self.DoEvent("EventTest","hello world", new PEventTest.Void(CallBack), "hello world 2");

        }

        public static void CallBack()
        {
            Console.WriteLine("hello world callback");
        }

        public static void Test(PEventTest.Void func)
        {
            Console.WriteLine("hello world callbackTest");
        }
    }
}
