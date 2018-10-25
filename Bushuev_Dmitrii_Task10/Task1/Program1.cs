using System;
using System.Collections.Generic;

namespace Task1
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<string> myStringArray = new List<string> { "qwerty", "qwertyqwerty", "qwe", "abc", "bbc", "abcdef" };

            myStringArray.Sort(CompareByLength);

            foreach(string myStr in myStringArray)
            {
                Console.WriteLine(myStr);
            }

            Console.ReadKey();
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
