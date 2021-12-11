using System;

namespace WiredBrainAppStackApp
{
    class Program
    {
        static void Main(string[] args)
        {


            StackDouble();
            StackString();
            
        }

        private static void StackDouble()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Please enter key");
            Console.ReadLine();
        }

        private static void StackString()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Lee");
            stack.Push("learns");
            stack.Push("generics");


            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine($"Item: {item}");
            }

        }
    }
}
