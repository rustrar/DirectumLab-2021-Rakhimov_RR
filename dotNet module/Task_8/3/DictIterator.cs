using System.Collections.Generic;

namespace Task_8._3
{
  /// <summary>
  /// Класс "DictIterator"
  /// </summary>
  /// <typeparam name="TKey">Тип ключа словаря</typeparam>
  /// <typeparam name="TValue">Тип значения словаря</typeparam>
  public class DictIterator<TKey, TValue>
  {
    /// <summary>
    /// Перебрать элементы словаря
    /// </summary>
    /// <param name="dict">Словарь</param>
    public void Iterate(IEnumerable<KeyValuePair<TKey, TValue>> dict)
    {
      foreach (KeyValuePair<TKey, TValue> pair in dict)
      {
        System.Console.WriteLine($"{pair.Key} : {pair.Value}");
      }
    }
  }
}