using System;

namespace Task_9
{
  /// <summary>
  /// Класс, представляющий строку лог-файла
  /// </summary>
  public class FileString
  {
    /// <summary>
    /// Дата и время строки
    /// </summary>
    public DateTime Date { get; set; }
    
    /// <summary>
    /// Прочая информация в строке
    /// </summary>
    public string Data { get; set; }
  }
}
