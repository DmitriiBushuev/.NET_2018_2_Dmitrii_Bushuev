using System;

namespace Bushuev_Dmitrii_Task05
{
    class Program
    {

        static void Main(string[] args)
        {
            User user1 = new User(new DateTime(2000,12,18), "Ivan", "Ivanovich", "Ivanov");
            Console.WriteLine(user1.ToString());
            Console.ReadKey();

            try
            {
                User user2 = new User(new DateTime(2012, 12, 5), "", "Ivanovich", "Ivanov");
                Console.WriteLine(user2.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();

        }
    }
}
