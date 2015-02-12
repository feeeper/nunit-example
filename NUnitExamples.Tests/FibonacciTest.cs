using MbUnitExamples;
using NUnit.Framework;

namespace NUnitExamples.Tests
{
  public class FibonacciTest
  {
    [Test]
    public void Fibonacci_of_number_greater_than_one()
    {
      var result = Fibonacci.Calculate(6);
      Assert.AreEqual(8, result);
    }

    [Test]
    public void Fibonacci_for_one()
    {
      var result = Fibonacci.Calculate(1);
      Assert.AreEqual(1, result);
    }
  }
}
