using System.Collections.Generic;

namespace Task_8._3
{
  class ListIterator<T>
  {
    public void Iterate(IEnumerable<T> collection)
    {
      foreach (T item in collection)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}