using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program3
    {
        static void Main(string[] args)
        {
            List<string> myStringArray1 = new List<string> { "qwerty", "qwertyqwerty", "qwe", "abc", "bbc", "abcdef" };
            List<string> myStringArray2 = new List<string> { "aaaa", "cccc", "bbbb", "aaa", "ccc", "bbb" };

            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            AutoResetEvent autoResetEvent2 = new AutoResetEvent(false);

            Task.Factory.StartNew(() => Sort(myStringArray1, autoResetEvent));
            Task.Factory.StartNew(() => Sort(myStringArray2, autoResetEvent2));

            //autoResetEvent.WaitOne();
            WaitHandle.WaitAll(new[] { autoResetEvent, autoResetEvent2 });

            foreach (string myStr in myStringArray1)
            {
                Console.WriteLine(myStr);
            }

            Console.WriteLine();

            foreach (string myStr in myStringArray2)
            {
                Console.WriteLine(myStr);
            }

            Console.ReadKey();
        }

        private static void Sort(List<string> list, AutoResetEvent autoResetEvent)
        {
            list.Sort(CompareByLength);
            Task.Delay(2000);
            autoResetEvent.Set();
        }

        static int CompareByLength(string string1, string string2)
        {
            if (string1 == null)
            {
                if (string2 == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (string2 == null)
                {
                    return 1;
                }
                else
                {
                    int returnValue = string1.Length.CompareTo(string2.Length);

                    if (returnValue != 0)
                    {
                        return returnValue;
                    }
                    else
                    {
                        return string1.CompareTo(string2);
                    }
                }
            }
        }
    }
}
