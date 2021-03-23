using System;

namespace Task_3
{
  /// <summary>
  /// Класс "Точка"
  /// </summary>
  public class Point
  {
    /// <summary>
    /// Расстояние по оси X
    /// </summary>
    public double X { get; private set; }

    /// <summary>
    /// Расстояние по оси Y
    /// </summary>
    public double Y { get; private set; }

    /// <summary>
    /// Расстояние между двумя точками
    /// </summary>
    /// <param name="point">Точка, до которой нужно найти расстояние</param>
    /// <returns>Расстояние между двумя точками</returns>
    public double Distance(Point point)
    {
      return Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(this.Y - point.Y, 2));
    }
  }
}
