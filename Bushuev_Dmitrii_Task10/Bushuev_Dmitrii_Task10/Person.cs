using System;

namespace Bushuev_Dmitrii_Task10
{

    class Person
    {
        public string Name { get; set; }

        public void Greet(object anotherPerson, DateTimeEventArgs timeOfArrival)
        {
            string greet = string.Empty;

            if (timeOfArrival.Time.Hour < 12)
            {
                greet = "Good morning!";
            }

            if (timeOfArrival.Time.Hour > 12 && timeOfArrival.Time.Hour < 17)
            {
                greet = "Good afternoon!";
            }

            if (timeOfArrival.Time.Hour > 17)
            {
                greet = "Good evening!";
            }
            
            Console.WriteLine($"{greet} '{anotherPerson}!', {Name} said.");
        }

        public void Goodbay(object anotherPerson, EventArgs args)
        {
            Console.WriteLine($"Goodbay, {anotherPerson}!', {Name} said.");
        }



        /* события
        public event EventHandler<DateTimeEventArgs> Came;


        public event EventHandler Gone;

        public void OnCame()
        {
            Came?.Invoke(Name, new DateTimeEventArgs { Time = DateTime.Now });
        }

        public void OnGone()
        {
            Gone?.Invoke(Name, EventArgs.Empty);
        }

        public Person()
        {
            //Task.Factory.StartNew(() =>
            //{
            //    Thread.Sleep(5000);
            //    OnCame();
            //});
        }*/
    }
}
