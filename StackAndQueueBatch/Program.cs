namespace StackAndQueueBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Linked List");
            StackLinkedList stackLinkedList = new StackLinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("A]Stack Linked List 1.Push 2.Peek 3.Pop 4.Peek 5.Pop 6.Empty 7.Size 8.exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stackLinkedList.Push(70);
                        stackLinkedList.Push(30);
                        stackLinkedList.Push(56);
                        stackLinkedList.Display();
                        break;
                    case 2:
                        stackLinkedList.peek();
                        stackLinkedList.Display();
                        break;
                    case 3:
                        stackLinkedList.Pop();
                        stackLinkedList.Display();
                        break;
                    case 4:
                        stackLinkedList.peek();
                        break;
                    case 5:
                        stackLinkedList.Pop();
                        break;
                    case 6:
                        stackLinkedList.Empty();
                        break;
                    case 7:
                        stackLinkedList.Size();
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }
    }
}
