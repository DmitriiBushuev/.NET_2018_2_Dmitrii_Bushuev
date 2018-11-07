using System;
using System.Collections.Generic;
using System.IO;

namespace Bushuev_Dmitrii_Task12
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double>();

            string myFilePath = @"C:\Users\Di Ma\Desktop\.NET_2018_2_Dmitrii_Bushuev\Bushuev_Dmitrii_Task12\disposable_task_file.txt";

            using (StreamReader mySR = new StreamReader(myFilePath, System.Text.Encoding.Default))
            {
                string line;
                
                while ((line = mySR.ReadLine()) != null)
                {
                    if (double.TryParse((line), out double number))
                    {
                        Console.Write($"{number} ");
                        number = Math.Pow(number, 2);
                        myList.Add(number);
                    }
                }
            }
            Console.ReadKey();

            using (StreamWriter mySW = new StreamWriter(myFilePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in myList)
                {
                    mySW.WriteLine(item);
                }    
            }
        }
    }
}
