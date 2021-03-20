using System;

namespace Task_1
{
  public class Triangle : Shape
  {
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set; }

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

    public double AC
    {
      get
      {
        return A.Distance(C);
      }
    }

    public double Perimeter
    {
      get
      {
        return AB + BC + AC;
      }
    }

    public double Area
    {
      get
      {
        double halfPerimeter = Perimeter / 2.0; 
        return Math.Sqrt(halfPerimeter * (halfPerimeter - AB) * (halfPerimeter - BC) * (halfPerimeter - AC));
      }
    }

    public Triangle(Point a, Point b, Point c)
    {
      A = a;
      B = b;
      C = c;
    }
  }
}
