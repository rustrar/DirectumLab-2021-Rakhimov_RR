using System;

namespace Task_5._3
{
  class Complex : IComparable
  {
    public double Re { get; set; }
    public double Im { get; set; }

    public int CompareTo(object obj)
    {
      Complex complex = obj as Complex;
      double thisAbs = Math.Sqrt((Re * Re) + (Im * Im));
      double targetAbs = Math.Sqrt((complex.Re * complex.Re) + (complex.Im * complex.Im));
      return thisAbs.CompareTo(targetAbs);
    }
  }
}
