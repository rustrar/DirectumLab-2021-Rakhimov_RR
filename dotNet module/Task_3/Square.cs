namespace Task_3
{
  /// <summary>
  /// Класс "Квадрат"
  /// </summary>
  public class Square : Rectangle
  {
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="a">Точка вершины A</param>
    /// <param name="b">Точка вершины B</param>
    /// <param name="c">Точка вершины C</param>
    /// <param name="d">Точка вершины D</param>
    public Square(Point a, Point b, Point c, Point d) : base(a, b, c, d)
    {
    }
  }
}
