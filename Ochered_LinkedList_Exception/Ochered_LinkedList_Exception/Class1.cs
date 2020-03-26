using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered_LinkedList_Exception
{
    public class Queue
    {
        LinkedList<int> queue = new LinkedList<int>();


        public void Enqueue(int value)
        {
            if(queue.Count == 10)
            {
                throw new QueueOverflowException();
            }
            queue.AddLast(value);
        }

        public int Dequeue()
        {
            if(queue.Count == 0)
            {
                throw new QueueOverflowEmpty();
            }
            int First = queue.First();
            queue.RemoveFirst();
            return First;            
        }
        public void Show()
        {
            foreach (int i in queue)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
