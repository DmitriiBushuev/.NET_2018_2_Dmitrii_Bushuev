using System;

namespace Bushuev_Dmitrii_Task10
{
    class Program2
    {
        static EventHandler<DateTimeEventArgs> greetByUs = null;
        static EventHandler bayByUs = null;

        static void Main(string[] args)
        {
            Person MrWhite = new Person { Name = "Mr. White" };
            Came(MrWhite);

            Person MrOrange = new Person { Name = "Mr. Orange" };
            Came(MrOrange);

            Person MrBlonde = new Person { Name = "Mr. Blonde" };
            Came(MrBlonde);

            GoHome(MrOrange);
            GoHome(MrWhite);
            GoHome(MrBlonde);

            Console.ReadKey();
        }

        private static void Came(Person person)
        {
            Console.WriteLine($"{person.Name} came");
            greetByUs?.Invoke(person.Name, new DateTimeEventArgs { Time = DateTime.Now });
            greetByUs += new EventHandler<DateTimeEventArgs>(person.Greet);
            bayByUs += new EventHandler(person.Goodbay);
        }

        private static void GoHome(Person person)
        {
            Console.WriteLine($"{person.Name} is gone");
            greetByUs -= new EventHandler<DateTimeEventArgs>(person.Greet);
            bayByUs -= new EventHandler(person.Goodbay);
            bayByUs?.Invoke(person.Name, EventArgs.Empty);
        }
    }
}
