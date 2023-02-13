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
        /// <summary>
        /// Uc2-Peek Top Value Of StackLinkedList
        /// </summary>
        public void peek()
        {
            if (headTop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("{0} is the top of the stack list", headTop.data);
        }
        /// <summary>
        /// Uc2-PoP-Delect top value
        /// </summary>
        public void Pop()
        {
            if (headTop==null)
            {
                Console.WriteLine("list is empty");
            }
            Console.WriteLine("value is pop "+headTop.data);
            headTop = headTop.next;
        }
        /// <summary>
        /// IsEmpty
        /// </summary>
        public void Empty()
        {
            while (headTop!=null)
            {
                peek();
                Pop();
            }
        }
        /// <summary>
        /// Size Of StackList
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node temp = this.headTop;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
                count++;
            }
            return count;
        }
    }
}
