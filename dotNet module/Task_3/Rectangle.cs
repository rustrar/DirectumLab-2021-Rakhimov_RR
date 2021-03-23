namespace Task_3
{
  /// <summary>
  /// Класс "Прямоугольник"
  /// </summary>
  public class Rectangle : Shape
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
    /// Координата вершины D
    /// </summary>
    public Point D { get; set; }

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
    /// Длина стороны CD
    /// </summary>
    public double CD
    {
      get
      {
        return this.C.Distance(this.D);
      }
    }

    /// <summary>
    /// Длина стороны АD
    /// </summary>
    public double AD
    {
      get
      {
        return this.A.Distance(this.D);
      }
    }

    /// <summary>
    /// Периметр прямоугольника
    /// </summary>
    public double Perimeter 
    {
      get 
      {
        return 2 * (this.AB + this.BC);
      }
    }

    /// <summary>
    /// Площадь прямоугльника
    /// </summary>
    public double Area
    {
      get
      {
        return this.AB * this.BC;
      }
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="a">Координаты вершины A</param>
    /// <param name="b">Координаты вершины B</param>
    /// <param name="c">Координаты вершины C</param>
    /// <param name="d">Координаты вершины D</param>
    public Rectangle(Point a, Point b, Point c, Point d)
    {
      this.A = a;
      this.B = b;
      this.C = c;
      this.D = d;
    }
  }
}
