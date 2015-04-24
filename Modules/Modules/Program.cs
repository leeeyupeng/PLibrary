using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PEvent;

namespace Modules
{
    class Program
    {
        static void Main(string[] args)
        {
            //EventProgram.TestMain();

            PEventProgram.TestMain();

            if (new Func<bool>(() => { Console.Write("hello"); return false; }).Invoke() && false)
            {
                Console.Write("hello");
            }
            else
            {
                Console.Write("wold");
            }
        }

      
    }
}
