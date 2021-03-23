using System;

namespace Task_3
{
  /// <summary>
  /// Класс "Окружность"
  /// </summary>
  public class Circle : Shape
  {
    /// <summary>
    /// Радиус окружности
    /// </summary>
    public double Radius { get; set; }

    /// <summary>
    /// Длина окружности
    /// </summary>
    public double Length
    {
      get 
      {
        return 2 * this.Radius * Math.PI;
      }
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="radis">Радиус окружности</param>
    public Circle(double radis)
    {
      this.Radius = radis;
    }
  }
}
