using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ochered_LinkedList_Exception_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Queue<int> queue = new Queue<int>();

            try
            {
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);
                queue.Enqueue(6);
                queue.Enqueue(7);
                queue.Enqueue(8);
                queue.Enqueue(9);
                queue.Enqueue(10);
               


                foreach (int item in queue)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            catch(QueueOverflowException)
            {
                Console.WriteLine("Нет места для добавления нового элемента!!!");
            }
            

        }
    }
}
