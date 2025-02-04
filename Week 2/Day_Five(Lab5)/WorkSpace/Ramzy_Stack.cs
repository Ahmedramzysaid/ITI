using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    public  class Ramzy_Stack
    {
        private  int[] arr;
        private   int top;
        int size;
        public Ramzy_Stack()
        {
            size = 10; 
            arr = new int[size];
            top  = 0;
        }
        public Ramzy_Stack(int n)
        {
            size = n;
            arr = new int[size];
            top = 0;
        }
        public  void push(int x)
        {
            if(top != size)
            {
                arr[top] = x;
                Console.WriteLine($"value {x} is add");
                top++;
            }
            else
            {
                throw new Exception($"Stack  is full  is {x} is not add"); 
            }
        }
        public  int pop()
        {
            int res = -1;
            if (top != 0)
            {
                top--;
                res = arr[top];
            }
            else
            {
              throw new Exception("Stack  is empty");
            }
            return res ;
        }

    }
}
