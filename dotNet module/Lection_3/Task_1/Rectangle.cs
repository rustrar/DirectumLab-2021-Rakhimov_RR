using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
  public class Rectangle : Shape
  {
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }
    public Point D { get; set; }

    public double AB
    {
      get
      {
        return A.Distance(B);
      }
    }

    public double BC
    {
      get
      {
        return B.Distance(C);
      }
    }

    public double CD
    {
      get
      {
        return C.Distance(D);
      }
    }

    public double AD
    {
      get
      {
        return A.Distance(D);
      }
    }

    public double Perimeter {
      get {
        return 2 * (AB + BC);
      }
    }

    public double Area
    {
      get
      {
        return AB * BC;
      }
    }

    public Rectangle(Point a, Point b, Point c, Point d)
    {
      A = a;
      B = b;
      C = c;
      D = d;
    }
  }
}
