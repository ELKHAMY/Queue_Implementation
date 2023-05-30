using System.Runtime.InteropServices;

namespace queue_implement;

class Program
{
    static void Main(string[] args)
    {
     Queue queue = new Queue(5);
        queue.enqueue(2);
        queue.enqueue(3);
        queue.enqueue(4);
        queue.enqueue(9);
        queue.enqueue(8);

        queue.dequeue();
        queue.dequeue();

        queue.printQueue();
      



    }
}

