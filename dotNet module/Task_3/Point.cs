using System;

namespace Task_3
{
  class Point
  {
    public double X { get; private set; }
    public double Y { get; private set; }

    public double Distance(Point point)
    {
      return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
    }
  }
}
