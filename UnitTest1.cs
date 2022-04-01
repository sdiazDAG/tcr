using System;
using Xunit;

namespace tcr
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          int posotion = 1;
          int resultValue = Fibonacci.Calculate(posotion);
          int expectedValue = 0;
          Assert.Equal(expectedValue, resultValue);
        }

        public void Test2()
        {
          int posotion = 2;
          int resultValue = Fibonacci.Calculate(posotion);
          int expectedValue = 1;
          Assert.Equal(expectedValue, resultValue);
        }
  }

    public static class Fibonacci
    {
      public static int Calculate(int posotion)
      {
        return 0;
      }
    }
}
