using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class Stack
    {
        public void StackDisplay()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);


            foreach (int ele in stack)
            {
                Console.WriteLine("ele");

            }
            Console.WriteLine("peek", stack.Peek);

            Console.WriteLine("-------------");

            stack.Pop();
            Console.WriteLine("peek", stack.Peek);

            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
