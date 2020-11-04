using stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var sstack = new sstack <int>();

            sstack.Push(47);
            sstack.Push(78);
            sstack.Push(58);

            var item = sstack.Pop();
            var item2 = sstack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadLine();
        }
    }
}
