using System;
using System.IO;

namespace Task_4._5
{
  /// <summary>
  /// Логгер - класс для ведения логов.
  /// </summary>
  public class Logger : IDisposable
  {
    /// <summary>
    /// Файл логов.
    /// </summary>
    private FileStream logFile;

    /// <summary>
    /// Писатель в лог.
    /// </summary>
    private StreamWriter logWriter;

    /// <summary>
    /// /Флаг, что объект был Disposed
    /// </summary>
    private bool disposed;

    /// <summary>
    /// Создать объект.
    /// </summary>
    /// <param name="fileName">Имя файла логов.</param>
    public Logger(string fileName)
    {
      this.logFile = new FileStream(fileName, FileMode.Append);
      this.logWriter = new StreamWriter(this.logFile);
    }

    /// <summary>
    /// Записать данные
    /// </summary>
    /// <param name="data">Данные</param>
    public void WriteString(string data)
    {
      this.logWriter.WriteLine(data);
    }

    /// <summary>
    /// Вызвать Dispose
    /// </summary>
    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Освободить ресурсы
    /// </summary>
    /// <param name="disposing">Флаг, что нужно освободить управляемые ресурсы</param>
    private void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          Console.WriteLine("Закрытие StreamWriter");
          this.logWriter.Close();
        }
        this.disposed = true;
      }
    }

    /// <summary>
    /// Деструктор.
    /// </summary>
    ~Logger()
    {
      this.Dispose(false);
    }
  }
}
