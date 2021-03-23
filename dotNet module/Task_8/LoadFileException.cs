using System;

namespace Task_8
{
  /// <summary>
  /// Класс исключения "LoadFileException"
  /// </summary>
  class LoadFileException : Exception
  {
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="message">Сообщение исключения</param>
    /// <param name="innerException">Исходное исключение</param>
    public LoadFileException(string message, Exception innerException) : base(message, innerException)
    {
    }
  }
}
