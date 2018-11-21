using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var yeni = new Stack();

            yeni.Push(1);
            yeni.Push(2);
            yeni.Push(3);
            yeni.Push("a");

            yeni.Clear();

            Console.WriteLine(yeni.pop());
            Console.WriteLine(yeni.pop());
            Console.WriteLine(yeni.pop());

            yeni.Clear();
        }
    }
}
