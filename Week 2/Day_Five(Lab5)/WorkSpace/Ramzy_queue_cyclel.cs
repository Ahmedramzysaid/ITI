using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    public class Ramzy_queue_cycle<T>
    {
        private T[] arr;
        private int size;
        private int front;
        private int last;
        private int count; 

        public Ramzy_queue_cycle()
        {
            size = 4;
            arr = new T[size];
            front = 0;
            last = 0;
            count = 0;
        }

        public Ramzy_queue_cycle(int n)
        {
            size = n;
            arr = new T[size];
            front = 0;
            last = 0;
            count = 0;
        }

        public void enqueue(T a)
        {
            if (count == size)
            {
                throw new Exception($"Queue is full and {a} is not add");
            }

            arr[last] = a;
            last = (last + 1) % size;
            count++;
            Console.WriteLine($"this value is add {a}");
        }

        public T Dequeu()
        {
            if (count == 0)
            {
                throw new Exception("Queue is empty");
            }

            T res = arr[front];
            front = (front + 1) % size;
            count--;
            return res;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == size;
        }
    }
}
