using System.Collections.Generic;

namespace Task_8._3
{
  /// <summary>
  /// Класс "ListIterator"
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class ListIterator<T>
  {
    /// <summary>
    /// Перебрать элементы списка
    /// </summary>
    /// <param name="dict">Список</param>
    public void Iterate(IEnumerable<T> collection)
    {
      foreach (T item in collection)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}