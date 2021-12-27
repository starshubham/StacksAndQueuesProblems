using System;

/*
UC3- Ability to create a Queue of 56->30->70
- Use LinkedList to do the Queue Operations
- Here enqueue will internally call append method on LinkedList.
- So 56 will be added first then 30 and then 70 to make 56 on top of the Stack

UC4- Ability to dequeue from the beginning
- Use LinkedList to do the Queue Operations
*/

namespace StackAndQueueUsingLinkedList
{

    public class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;               
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value Dequeue is {0}", this.head.data);
            this.head = this.head.next;
        }
        internal void isEmpty()
        {
            while (this.head != null)
            {
                Dequeue();
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
