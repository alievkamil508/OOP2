using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ochered_LinkedList_Exception
{
    public class QueueOverflowException : Exception
    {
        public override string Message
        {
            get
            {
                return "Нет места для добавления нового элемента!!!";
            }
        }
    }
    public class QueueOverflowEmpty : Exception
    {
        public override string Message
        {
            get
            {
                return "Очередь пуст!!!";
            }
        }
    }
}
