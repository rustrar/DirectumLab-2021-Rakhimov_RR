using System;

namespace Task_1
{
  public class Round : Circle
  {
    public double Area
    {
      get
      {
        return Math.PI * Radius * Radius;
      }
    }

    public Round(double radius) : base(radius)
    {      
    }
  }
}