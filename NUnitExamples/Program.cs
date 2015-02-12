using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbUnitExamples
{
  class Program
  {
    static void Main(string[] args)
    {
      Debug.WriteLine(Fibonacci.Calculate(6));
    }
  }

  public class Fibonacci
  {
    public static int Calculate(int x)
    {
      if (x <= 0)
        return 0;

      if (x == 1)
        return 1;

      return Calculate(x - 1) + Calculate(x - 2);
    }
  }
}
