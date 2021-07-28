using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                CallMethod();
                Thread.Sleep(2);//adding sleep to slow down Method4 execution
                Method4();
                Console.WriteLine("Completed Method4");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static async Task CallMethod()
        {
            //Tasks will be executed sequentially
            Task a = Task.Run(() => Method1());
            await Task.WhenAll(a);
            Console.WriteLine("Completed Method1");

            Task b = Task.Run(() => Method2());
            await Task.WhenAll(b);
            Console.WriteLine("Completed Method2");

            Task c = Task.Run(() => Method3());
            await Task.WhenAll(c);
            Console.WriteLine("Completed Method3");
        }
        public static void Method1()
        {
            for(int i =0;i<10;i++)
            {
                Console.WriteLine("Method 1 task " + i);
            }
        }
        public static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 task " + i);
            }
        }
        public static void Method3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 3 task " + i);
            }
        }
        public static void Method4()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 4 task " + i);
            }
        }
    }
}
