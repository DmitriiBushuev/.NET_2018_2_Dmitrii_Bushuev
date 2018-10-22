using System;

namespace Task3
{
    class Program4
    {
        static void Main(string[] args)
        {
            MyString myStr1 = new MyString("код кот");
            Console.WriteLine(myStr1);
            Console.ReadKey();

            myStr1 = myStr1 + " котяра";
            Console.WriteLine(myStr1);
            Console.ReadKey();

            myStr1 = myStr1  - "ко";
            Console.WriteLine(myStr1);
            Console.ReadKey();

            bool myBool = myStr1 == new MyString ("кот");
            Console.WriteLine(myBool);
            Console.ReadKey();
        }
    }
}
