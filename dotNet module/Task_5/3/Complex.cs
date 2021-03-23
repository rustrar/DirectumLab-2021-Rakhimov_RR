using System;

namespace Task_5._3
{
  /// <summary>
  /// Класс "Комплексное число"
  /// </summary>
  public class Complex : IComparable
  {
    /// <summary>
    /// Действительная часть
    /// </summary>
    public double Re { get; set; }
    
    /// <summary>
    /// Мнимая часть
    /// </summary>
    public double Im { get; set; }

    /// <summary>
    /// Реализация IComparable
    /// </summary>
    /// <param name="obj">Комплексное число, с которым нужно сравить текущее</param>
    /// <returns>Значение, указывающее, каков относительный порядок сравниваемых объектов
    /// Возвращаемое значение меньше нуля - Данный экземпляр предшествует параметру obj в порядке сортировки
    /// Нуль - Данный экземпляр занимает ту же позицию в порядке сортировки, что и параметр obj
    /// Больше нуля - Данный экземпляр следует за параметром obj в порядке сортировки</returns>    
    public int CompareTo(object obj)
    {
      Complex complex = obj as Complex;
      double thisAbs = Math.Sqrt((this.Re * this.Re) + (this.Im * this.Im));
      double targetAbs = Math.Sqrt((complex.Re * complex.Re) + (complex.Im * complex.Im));
      return thisAbs.CompareTo(targetAbs);
    }
  }
}
