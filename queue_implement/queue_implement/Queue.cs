using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_implement
{
    class Queue
    {
        #region fieldsss
        private int[] arr;
        private int front;
        private int rear;
        private int max;
        #endregion

        #region constructor
        public Queue(int size)
        {
            arr = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }
        #endregion

        #region enqueue
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("completed");
                return;
            }
            else
            {
                arr[++rear] = item;
            }
        }
        #endregion

        #region dequeue

        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("empty");
                return -1;
            }
            else
            {
                return arr[front++];
            }
        }
        #endregion

        #region printqueue
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine( arr[i]);
                }
            }


        }
        #endregion
    }
}
