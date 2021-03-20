using System;

namespace Task_1
{
  public class Circle : Shape
  {
    public double Radius { get; set; }
    public Point Center { get; set; }
    public double Length
    {
      get {
        return 2 * Radius * Math.PI;
      }
    }

    public Circle(double radis)
    {
      Radius = radis;
    }
  }
}
