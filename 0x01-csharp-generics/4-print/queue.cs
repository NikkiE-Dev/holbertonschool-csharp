using System;

///<summary>Creates a new class.</summary>
public class Queue<T>
{
    ///<summary>Creates properties for head of the queue.</summary>
    public Node head = null;

    ///<summary>Creates properties for tail of the queue.</summary>
    public Node tail = null;

    ///<summary>Creates properties counts how many nodes are in the queue.</summary>
    public int count = 0;
    
    ///<summary>Creates a method that returns the Queue’s type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    ///<summary>Creates a method that creates a new Node and adds it to the end of the queue.</summary>
    public void Enqueue(T value)
    {
        Node nxt = new Node(value);
        if (head == null && tail == null)
        {
            head = nxt;
            tail = nxt;
        }
        else
        {
            tail.next = nxt;
            tail = nxt;
        }
        count += 1;
    }

    ///<summary>Method that returns the value of the first node of the queue.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }

    ///<summary>Method that removes the first node in the queue and returns its value.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node rmv = head;
        head = rmv.next;
        count -= 1;
        return (rmv.value);
    }

    ///<summary>Method that removes the first node in the queue and returns its value.</summary>
    public void Print()
    {
        Node first = head;
        if (first == null)
        {
            Console.WriteLine("Queue is empty");
        }
        if (first != null)
        {
            Console.WriteLine(first.value.ToString());
            first = first.next;
        }
    }    

    ///<summary>Creates a method that creates a that returns the number of nodes in the Queue.</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>Creates a 2nd new class.</summary>
    public class Node
    {
        ///<summary>Creates a generic variable value.</summary>   
        public T value = default(T);

        ///<summary>Creates a Node variable.</summary>
        public Node next = null;

        ///<summary>Creates a constuctor for Node class.</summary>
        public Node (T v)
        {
            value = v;
        }
    }
}
