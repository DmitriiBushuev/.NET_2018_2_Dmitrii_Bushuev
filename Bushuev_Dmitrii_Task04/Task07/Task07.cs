using System;
using System.Text.RegularExpressions;

namespace Task07
{
    class SearchTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст с упоминанием времени:");
            // ([01]+[0-9])|(2[0-3]):[0-5][0-9]
            //(?<hours>((^|\s)[0-9])|(1[0-9])|(2[0-3])):(?<minutes>[0-5][0-9])
            Regex myRegEx1 = new Regex(@"(?<hours>((^|\s)[0-9])|(1[0-9])|(2[0-3])):(?<minutes>[0-5][0-9])");
            //int count = 0;
            string text = Console.ReadLine();
            MatchCollection matches = myRegEx1.Matches(text);
            
            /*foreach (Match match in matches)
            {
                string hoursString = match.Groups["hours"].Value;
                if (int.TryParse(hoursString, out int hours) && hours < 24)
                {
                    string minutesString = match.Groups["minutes"].Value;
                    if (int.TryParse(minutesString, out int minutes) && hours < 60)
                    {
                        count += 1;
                    }
                }
            }*/
            Console.WriteLine($"Количество упоминаний времени в тексте: {matches.Count}.");
            Console.ReadKey();
        }
    }
}
