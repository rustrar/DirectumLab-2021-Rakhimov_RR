using System;

namespace Task_3
{
  class Ring : Round
  {
    public double InternalRadius { get; set; }
    public new double Area 
    { 
      get { 
        return base.Area - Math.PI * InternalRadius * InternalRadius; 
      } 
    }

    public double InternalLength
    {
      get
      {
        return 2 * Math.PI * InternalRadius;
      }
    }

    public Ring(double radius) : base(radius)
    {
    }
  }
}
