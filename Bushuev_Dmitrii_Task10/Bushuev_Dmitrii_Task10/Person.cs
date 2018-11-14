using System;

namespace Bushuev_Dmitrii_Task10
{
    public delegate void OnCame(Person p, DateTime time);
    public delegate void OnLeave(Person p);

    public class Person
    {
        public string Name { get; set; }
        public event OnCame OnCame;
        public event OnLeave OnLeave;

        public void GoToWork()
        {
            OnCame?.Invoke(this, DateTime.Now);
        }

        public void GoHome()
        {
            OnLeave?.Invoke(this);
        }

        public void SayHello(object anotherPerson, DateTime timeOfArrival)
        {
            string greet = string.Empty;

            if (timeOfArrival.Hour < 12)
            {
                greet = "Good morning!";
            }

            if (timeOfArrival.Hour > 12 && timeOfArrival.Hour < 17)
            {
                greet = "Good afternoon!";
            }

            if (timeOfArrival.Hour > 17)
            {
                greet = "Good evening!";
            }
            
            Console.WriteLine($"{greet} '{anotherPerson}!', {Name} said.");
        }

        public void SayGoodBye(object anotherPerson)
        {
            Console.WriteLine($"Goodbay, {anotherPerson}!', {Name} said.");
        }
    }
}
