using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bushuev_Dmitrii_Task09
{
    class Program2
    {
        static void Main(string[] args)
        {
            List<int> myList1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            DynamicArray<int> myDynamicArray1 = new DynamicArray<int>(myList1);

            Console.WriteLine(myDynamicArray1.Length);

            foreach(int i in myDynamicArray1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
