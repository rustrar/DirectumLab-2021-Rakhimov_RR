using System;

namespace Task_3
{
  /// <summary>
  /// Класс "Круг"
  /// </summary>
  public class Round : Circle
  {
    /// <summary>
    /// Площадь круга
    /// </summary>
    public double Area
    {
      get
      {
        return Math.PI * this.Radius * this.Radius;
      }
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    public Round(double radius) : base(radius)
    {      
    }
  }
}