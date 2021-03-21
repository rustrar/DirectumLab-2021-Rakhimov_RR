using System;
using System.Linq;

namespace Task_2
{
  class MaximumFinder<T> where T : IComparable<T>
  {
    public T Max(T a, T b, T c)
    {
      T[] parameters = new T[] { a, b, c };
      return parameters.Max();
    }
  }
}
