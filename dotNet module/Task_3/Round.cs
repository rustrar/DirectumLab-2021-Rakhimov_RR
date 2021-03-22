using System;

namespace Task_3
{
  class Round : Circle
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