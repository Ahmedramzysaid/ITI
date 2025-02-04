using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSpace
{
    public  class Ramzy_Stack_generic<T> 
    {
        private  T[] arr;
        private  int top ;
        private  int size;


        public Ramzy_Stack_generic()
        {
            size = 10;
            arr = new T[size];
            top = 0;
        }
        public Ramzy_Stack_generic(int n)
        {
            size = n;
            arr = new T[size];
            top = 0;
        }
        public  void push(T x)
        {
            if (top != size)
            {
                arr[top++] = x;
                Console.WriteLine($"this value {x}");

            }
            else
            {
               throw  new Exception($"Stack  is full this value {x} is not add");
            }
        }
        public  T pop()
        {
            T res = default;
            if (top != 0)
            {
                top--;
                res = arr[top];
            }
            else
            {
                throw new Exception("Stack  is empty");
            }
            return res;
        }

    }
}
