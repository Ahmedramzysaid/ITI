using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int read()
            {
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            static int mi_f(int a, int b)
            {
                if (a < b) return a;
                return b;
            }
            static int mx_f(int a, int b)
            {
                if (a > b) return a;
                return b;
            }
            static int Binary_search(int[] arr, int l  ,int r , int element)
            {
                if ( l<=  r)
                {
                    int mid= (l+r)/ 2;
                    if (arr[mid] == element)
                        return mid;
                    else if (arr[mid] > element)
                       return Binary_search(arr, l, mid - 1, element);
                    else
                        return Binary_search(arr, mid+1, r, element);
                }
                return -1;
            }
            static int linear(int[] arr, int element)
            {
                for (int i = 0;  i  <  arr.Length; i++)
                {
                    if (arr[i] ==  element)
                        return i;
                }
                return -1;
            }


            Console.Write("Entre size number :");
            int size_array = read();
            int[] arr = new int[size_array];
            for (int i = 0; i < size_array; i++)
            {
                Console.Write($"Entre {i + 1} number :");
                arr[i] = read();
            }


            int mi = arr[0];
            for (int i = 1; i < size_array; i++)
            {
                mi = mi_f(mi, arr[i]);
            }
            int mx = arr[0];
            for (int i = 1; i < size_array; i++)
            {
                mx = mx_f(mx, arr[i]);
            }
            Console.WriteLine($"max  element : {mx}");
            Console.WriteLine($"min  element : {mi}");
            for (int i = 0; i < size_array; i++)
            {
                for (int j = i + 1; j < size_array; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            Console.Write("This is number after sorting :");
            for (int i = 0; i < size_array; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine() ;
            Console.Write("Entre number you  want to find :");
            int element =  int.Parse(Console.ReadLine());
            int pos = Binary_search(arr, 0, size_array - 1, element);//  binary  search  basic
            if (pos == -1)
                Console.WriteLine("This is element not found ");//  غريب وانت الا مدخل الارقام  
            else Console.WriteLine($"this is exit in postione {pos + 1}");
            int pos1 = linear(arr,element);
            if (pos == -1)
                Console.WriteLine("This is element not found ");//  غريب وانت الا مدخل الارقام  
            else Console.WriteLine($"this is exit in postione {pos1 + 1}");


        }

    }
    
}