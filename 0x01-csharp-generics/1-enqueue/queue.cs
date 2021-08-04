using System;

///<summary>Creates a new class.</summary>
public class Queue<T>
{
    ///<summary>Creates properties Queue class.</summary>
    public Node head = null;
    public Node tail = null;
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
    ///<summary>Creates a method that creates a that returns the number of nodes in the Queue.</summary>
    public int Count()
    {
        return count;
    }

    ///<summary>Creates a 2nd new class.</summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        ///<summary>Creates a constuctor for Node class.</summary>
        public Node (T v)
        {
            value = v;
        }
    }
}
