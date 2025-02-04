using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
/*
                                                   ██████╗  █████╗ ███╗   ███╗███████╗██╗   ██╗
                                                   ██╔══██╗██╔══██╗████╗ ████║╚══███╔╝╚██╗ ██╔╝
                                                   ██████╔╝███████║██╔████╔██║  ███╔╝  ╚████╔╝
                                                   ██╔══██╗██╔══██║██║╚██╔╝██║ ███╔╝    ╚██╔╝
                                                   ██║  ██║██║  ██║██║ ╚═╝ ██║███████╗   ██║
                                                   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝   ╚═╝
*/
namespace WorkSpace
{
      class Chaos_Chaos
    {     
        public static void read(int[] arr )
        {
            string str =  Console.ReadLine();
            string[] arr_str = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(arr_str[i]);

            }
        }
        public static  void swap(ref int a , ref int b)
        {
            a = a + b;
            b = a - b;
            a  = a - b;
        }   
        public static  int  max(int a , int b)
        {
            if (a >=b ) return a;
            return b; 
        }
        public static int min(int a, int b)
        {
            if (a >= b) return b;
            return a;
        }
        public  static  bool  Binary_search(int[] arr , int l ,  int r  , int element)
        {
            if (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == element) return true;
                else if (arr[mid] < element) return Binary_search(arr, mid + 1, r, element);
                return Binary_search(arr, l, mid-1, element);
            }
            return false;
        }
        public  static int GCD(int a  , int b)
        {
            if (a == 0) return b; 
            if (a < b) swap(ref a, ref b);
            return GCD(a % b, b);
        }
        public static  int LCM(int a  , int b)
        {
            return (a * b) / GCD(a, b);
        }
        public static  bool IsPrime(int a)
        {
            if (a <= 1) return false;
            if (a==2 || a== 3) return true;
            
            for(long  i  = 2; i *i <=  a; i++)
                if (a%i  == 0 ) return false;
            return true;
        }
        public static List<long> getDivisor(long a)
        {
            List<long> res ;
            res = new List<long>();
            for (int i = 1; i*i <=a  ; i++)
            {
                if (a%i  ==0 )
                {
                    res .Add(i);
                    if(a/i  !=  i)
                        res.Add(a/i);
                }
            }
            return res;
        }

    }
    
    
}
