using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueBatch
{
    public class StackLinkedList
    {
        Node headTop;
        /// <summary>
        /// Uc1 Push -Add data
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (headTop == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = this.headTop;
            }
            headTop =newNode;
            Console.WriteLine("added the stack value "+data);
        }
        /// <summary>
        /// Display StackList
        /// </summary>
        public void Display()
        {
            Node temp = headTop;
            if (temp ==null)
            {
                Console.WriteLine("Stacklist is empty");
            }
            while (temp !=null)
            {
                Console.WriteLine(temp.data +" ");
                temp =temp.next;
            }
        }
    }
}
