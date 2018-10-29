using System;
using System.Collections.Generic;

namespace Task1
{
    class Program1
    {
        private delegate int Sort(string string1, string string2);//в 3 строчки

        static void Main(string[] args)
        {
            List<string> myStringArray = new List<string> { "qwerty", "qwertyqwerty", "qwe", "abc", "bbc", "abcdef" };

            Sort sort = new Sort(CompareByLength);//в 3 строчки
            myStringArray.Sort((x, y) => sort(x, y));//в 3 строчки
            
            //myStringArray.Sort(CompareByLength); - в одну строчку

            foreach (string myStr in myStringArray)
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
