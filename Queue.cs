using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class Queue
    {
        public void QueueDisplay()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(70);
            queue.Enqueue(30);
            queue.Enqueue(56);

            foreach(int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
