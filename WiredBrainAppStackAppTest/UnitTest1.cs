using System;
using Xunit;

namespace WiredBrainAppStackApp
{
    public class UnitTest1
    {
        [Fact]
        public void TestPushMethod()
        {
            var stack = new SimpleStack();
            double sum = 0.0;

            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);


            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Assert.Equal(7.0, sum, 1);
        }
    }
}
