using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueBatch
{
    public class QueueLinkedList
    {
        Node headTop;
        /// <summary>
        /// Uc1-Enqueue -Add data
        /// </summary>
        /// <param name="data"></param>
        public void Equeue(int data)
        {
            Node newNode = new Node(data);
            if (headTop == null)
            {
                headTop = newNode;
            }
            else
            {
                Node temp = headTop;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} inserted into Linked List", newNode.data);
        }
        /// <summary>
        /// Display
        /// </summary>
        public void Display()
        {
            Node temp = headTop;
            if (temp ==null)
            {
                Console.WriteLine("stacklist is empty");
            }
            while (temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp =temp.next;
            }
        }
    }
}
