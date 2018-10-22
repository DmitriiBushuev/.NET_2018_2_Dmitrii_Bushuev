using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class MyString
    {
        List<char> chars = new List<char>();

        public MyString(string myString)
        {
            chars.AddRange(myString);   
        }

        public static MyString operator +(MyString myString, string addStr)
        {
            myString.chars.AddRange(addStr);
            return myString;
        }

        public static MyString operator -(MyString myString, string removeStr)
        {
           String newString = myString.ToString().Replace(removeStr, string.Empty);
            return new MyString(newString);
        }

        public override string ToString()
        {
            StringBuilder strBuild1 = new StringBuilder();
            strBuild1.Append(chars.ToArray());
            return strBuild1.ToString();
        }

        public static bool operator ==(MyString myString, MyString strForCompare)
        {
            return myString.chars == strForCompare.chars;
        }

        public static bool operator !=(MyString myString, MyString strForCompare)
        {
            return !(myString == strForCompare);
        }

        public override int GetHashCode()
        {
            return chars.GetHashCode();
        }
    }
}
//myString.chars = myString.chars.Except(removeStr).ToList(); 25