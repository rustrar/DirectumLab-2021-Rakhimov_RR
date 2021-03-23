namespace Task_5._1
{
  /// <summary>
  /// Класс StringValue
  /// </summary>
  public class StringValue 
  {
    /// <summary>
    /// Строковое значение
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="value">Строка</param>
    public StringValue(string value)
    {
      this.Value = value;
    }

    /// <summary>
    /// Переопределенный метод для сравнения
    /// </summary>
    /// <param name="obj">Объект StringValue</param>
    /// <returns>True, если Value одинаковые. Инчае - false</returns>
    public override bool Equals(object obj)
    {
      return this.Value.Equals((obj as StringValue).Value);
    }

    /// <summary>
    /// Переопределенный метод GetHashCode
    /// </summary>
    /// <returns>HashCode</returns>
    public override int GetHashCode()
    {
      return base.GetHashCode();  
    }
  }
}
