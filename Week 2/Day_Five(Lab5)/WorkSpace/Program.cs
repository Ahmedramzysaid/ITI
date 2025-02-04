/*
 ░▒▓███████▓▒░░▒▓██████▓▒░░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░
░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░
░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░    ░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░
 ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░    ░▒▓█▓▒▒▓█▓▒░░▒▓██████▓▒░
       ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░
       ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░     ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░
░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓████████▓▒░▒▓██▓▒░  ░▒▓████████▓▒░
*/
using WorkSpace;
namespace WorkSpace
{ 
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is first  task  is use stack ");
            Ramzy_Stack s = new Ramzy_Stack(5);
            while (true)
            {
                int a = default;
                a = int.Parse(Console.ReadLine());
                try
                {
                    s.push(a);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine(s.pop());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            }
            Console.WriteLine("===================================\nthis is second  task  is use stack generic ");
            Ramzy_Stack_generic<int> s1 = new Ramzy_Stack_generic<int>(5);
            while (true)
            {
                int a = default;
                a = int.Parse(Console.ReadLine());
                try
                {
                    s1.push(a);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine(s1.pop());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }

            }
            Console.WriteLine("===================================\nthis is third task  we are test my  queue");
            Ramzy_queue_cycle<int> q = new Ramzy_queue_cycle<int>(5);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("if you want add choice 1 and remove choice 2");
                // Console.WriteLine("if you want add choice 1 and remove choice 2");
                Console.Write("Entre your choice : ");
                int choice  =  int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Entre number :");
                        int a = default;
                        a = int.Parse(Console.ReadLine());
                        try
                        {
                            q.enqueue(a);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            flag = false;
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine($"this is value is removed {q.Dequeu()}"); 
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }


                }
                

            }
       
        }
    }
