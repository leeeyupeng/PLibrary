using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    class DelegateTest
    {
        public delegate void FuncDefault();
        public static void Test()
        {
            Func<int, int> test = print;
            Func<string> test2 = printstr;
            Func<int> test3 = print2;

            Func<int, string> test4 = str => str.ToString();

            Func<int, string> test5 = str => { Console.WriteLine(str); return str.ToString(); };

            testFunc(test4);
            testFunc(test5);

            //Func<()> test6 = () => { Console.WriteLine("1"); };

            FuncDefault test6 = () => { Console.WriteLine("1"); };

            Action test7 = () => { };

            Func<int, object[]> test8 = str => { return null; };

            Action<int, int> test9 = (a, b) => { };

            Func<int, int, int, int> test10 = (a, b, c) => { return 1; };

            //public static T[] FindAll<T>(T[] array, Predicate<T> match);
            int[] arr = { 1, 3, 2, 4, 5, 7, 7, 7 };
            int[] arr7 = Array.FindAll<int>(arr, a => { return a == 7; });
            int arr3 = Array.Find<int>(arr, a => a == 3);
        }

        public static int print2()
        {
            return 1;
        }

        public static int print(int a)
        {
            return 1;
        }

        public static string printstr()
        {
            return "a";
        }

        public static void testFunc(Func<int, string> func)
        {
        }
    }
}
