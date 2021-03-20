using System.Collections;

namespace Task_3
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList TwoComplexes = new ArrayList() { 
        new Complex() { Re = 3, Im = 5 },
        new Complex() { Re = 2, Im = 2}
      };
      TwoComplexes.Sort();
    }
  }
}
