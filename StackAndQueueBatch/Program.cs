namespace StackAndQueueBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack and Queue Linked List");
            StackLinkedList stackLinkedList = new StackLinkedList();
            stackLinkedList.Push(70);
            stackLinkedList.Push(30);
            stackLinkedList.Push(56);
            stackLinkedList.Display();
        }
    }
}
