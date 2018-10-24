using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<string> myList1 = new List<string> { "human1", "human2", "human3", "human4", "human5", "human6", "human7", "human8"};

            LinkedList<string> myLinkedList1 = new LinkedList<string>();
            myLinkedList1.AddLast("animal1");
            myLinkedList1.AddLast("animal2");
            myLinkedList1.AddLast("animal3");
            myLinkedList1.AddLast("animal4");
            myLinkedList1.AddLast("animal5");
            myLinkedList1.AddLast("animal6");
            myLinkedList1.AddLast("animal7");
            myLinkedList1.AddLast("animal8");
            myLinkedList1.AddLast("animal9");


            RemoveEachSecondItem(myList1);
            RemoveEachSecondItem(myLinkedList1);


        }

        public static void RemoveEachSecondItem(ICollection<string> inputArray)
        {
            int counter = 1;

            while (inputArray.Count != 1)
            {
                string elementForRemove = inputArray.ElementAt(counter);
                inputArray.Remove(elementForRemove);
                counter += 1;

                if (counter > inputArray.Count)
                {
                    counter = 1;
                }

                if (counter == inputArray.Count)
                {
                    counter = 0;
                }
            }
        }
    }
}
