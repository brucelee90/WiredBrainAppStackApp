using System;
using Xunit;

namespace WiredBrainAppStackApp
{
    public class UnitTest1
    {
        [Fact]
        public void TestPushMethod()
        {
            var stackDouble = new SimpleStack<double>();
            double sum = 0.0;

            stackDouble.Push(1.2);
            stackDouble.Push(2.8);
            stackDouble.Push(3.0);


            while (stackDouble.Count > 0)
            {
                double item = stackDouble.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }

            Assert.Equal(7.0, sum, 1);
        }
    }
}
