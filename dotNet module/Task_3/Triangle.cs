using System;

namespace Task_3
{
  /// <summary>
  /// Класс "Треугольник"
  /// </summary>
  public class Triangle : Shape
  {
    /// <summary>
    /// Координата вершины A
    /// </summary>
    public Point A { get; set; }

    /// <summary>
    /// Координата вершины B
    /// </summary>
    public Point B { get; set; }

    /// <summary>
    /// Координата вершины C
    /// </summary>
    public Point C { get; set; }

    /// <summary>
    /// Длина стороны АB
    /// </summary>
    public double AB
    {
      get
      {
        return this.A.Distance(this.B);
      }
    }

    /// <summary>
    /// Длина стороны BC
    /// </summary>
    public double BC
    {
      get
      {
        return this.B.Distance(this.C);
      }
    }

    /// <summary>
    /// Длина стороны АC
    /// </summary>
    public double AC
    {
      get
      {
        return this.A.Distance(this.C);
      }
    }

    /// <summary>
    /// Периметр треугольника
    /// </summary>
    public double Perimeter
    {
      get
      {
        return this.AB + this.BC + this.AC;
      }
    }

    /// <summary>
    /// Площадь треугольника
    /// </summary>
    public double Area
    {
      get
      {
        double halfPerimeter = this.Perimeter / 2.0; 
        return Math.Sqrt(halfPerimeter * (halfPerimeter - this.AB) * (halfPerimeter - this.BC) * (halfPerimeter - this.AC));
      }
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="a">Координаты вершины A</param>
    /// <param name="b">Координаты вершины B</param>
    /// <param name="c">Координаты вершины C</param>
    public Triangle(Point a, Point b, Point c)
    {
      this.A = a;
      this.B = b;
      this.C = c;
    }
  }
}
