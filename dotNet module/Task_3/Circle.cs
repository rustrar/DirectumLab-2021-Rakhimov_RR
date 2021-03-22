using System;

namespace Task_3
{
  class Circle : Shape
  {
    public double Radius { get; set; }
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
