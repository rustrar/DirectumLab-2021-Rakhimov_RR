using System;

namespace Task_3
{
  /// <summary>
  /// Класс "Кольцо"
  /// </summary>
  public class Ring : Round
  {
    /// <summary>
    /// Внутренний радиус
    /// </summary>
    public double InternalRadius { get; set; }
    
    /// <summary>
    /// Площадь кольца
    /// </summary>
    public new double Area 
    { 
      get
      { 
        return base.Area - (Math.PI * this.InternalRadius * this.InternalRadius); 
      } 
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="radius">Внешний радиус</param>
    public Ring(double radius) : base(radius)
    {
    }
  }
}
