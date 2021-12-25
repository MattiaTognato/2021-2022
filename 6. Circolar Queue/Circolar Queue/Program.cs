using System;

namespace Circolar_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircolarQueue<int> cq = new CircolarQueue<int>(3);
            cq.Add(0);
            Console.WriteLine(cq.ToString());
            cq.Add(1);
            Console.WriteLine(cq.ToString());
            cq.Add(2);
            Console.WriteLine(cq.ToString());
            cq.Remove();
            Console.WriteLine(cq.ToString());
            cq.Add(3);
            Console.WriteLine(cq.ToString());
            cq.Add(4);
            Console.WriteLine(cq.ToString());

        }
    }
}
