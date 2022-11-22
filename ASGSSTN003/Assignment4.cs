using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASGSSTN003
{
    public class Stack_
    {
        public static void Main(string[] args)
        {
            Stack<string> fruits = new Stack<string>();
            fruits.Push("Mango");
            fruits.Push("Apple");
            fruits.Push("Peach");
            fruits.Push("Banana");
            fruits.Push("Orange");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Peek element: " + fruits.Peek());
            Console.WriteLine("Pop: " + fruits.Pop());
            Console.WriteLine(" ");
            Console.WriteLine("After Pop,");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }
    }
}
