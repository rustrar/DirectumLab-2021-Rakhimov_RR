using System;
using System.Linq;

namespace Task_8._2
{
  /// <summary>
  /// Класс "MaximumFinder"
  /// </summary>
  /// <typeparam name="T">Тип значения</typeparam>
  public class MaximumFinder<T> where T : IComparable<T>
  {
    /// <summary>
    /// Найти максимальное из трех значений
    /// </summary>
    /// <param name="a">Значение 1</param>
    /// <param name="b">Значение 1</param>
    /// <param name="c">Значение 1</param>
    /// <returns>Максимальное из трех значений</returns>
    public T Max(T a, T b, T c)
    {
      T[] parameters = new T[] { a, b, c };
      return parameters.Max();
    }
  }
}
