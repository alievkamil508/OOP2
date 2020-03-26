using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered_LinkedList_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            
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
                queue.Enqueue(11);
                

                queue.Show();
            }
            catch(QueueOverflowException)
            {
                Console.WriteLine("Нет места для добавления нового элемента!!!");
            }
            catch (QueueOverflowEmpty)
            {
                Console.WriteLine("Очередь пуст!!!");
            }
        }
    }
}
