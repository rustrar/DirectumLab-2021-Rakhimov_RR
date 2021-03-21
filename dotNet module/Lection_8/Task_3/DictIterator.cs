using System.Collections.Generic;

namespace Task_3
{
  class DictIterator<TKey, TValue>
  {
    public void Iterate(IEnumerable<KeyValuePair<TKey, TValue>> dict)
    {
      foreach (KeyValuePair<TKey, TValue> pair in dict)
      {
        System.Console.WriteLine($"{pair.Key} : {pair.Value}");
      }
    }
  }
}