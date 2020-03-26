using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ochered_LinkedList_Exception_2
{
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;


        public void Enqueue(T data)
        {

            if(count==10)
            {
                throw new QueueOverflowException();
            }

            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                tempNode.Next = tail;
            }
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }

}
