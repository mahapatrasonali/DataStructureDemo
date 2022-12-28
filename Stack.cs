using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    public class Stack
    {
        public void ListDisplay()
        {
            List<int> list = new List<int>();
            list.Add(70);
            list.Add(30);
            list.Add(56);

            foreach(int ele in list)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
