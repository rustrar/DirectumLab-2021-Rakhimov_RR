using System;
using System.IO;

namespace Task_4._5
{
  /// <summary>
  /// Логгер - класс для ведения логов.
  /// </summary>
  class Logger : IDisposable
  {
    /// <summary>
    /// Файл логов.
    /// </summary>
    private FileStream logFile;

    /// <summary>
    /// Писатель в лог.
    /// </summary>
    private StreamWriter logWriter;

    private bool disposed;

    /// <summary>
    /// Создать объект.
    /// </summary>
    /// <param name="fileName">Имя файла логов.</param>
    public Logger(string fileName)
    {
      logFile = new FileStream(fileName, FileMode.Append);
      logWriter = new StreamWriter(logFile);
    }

    public void WriteString(string data)
    {
      logWriter.WriteLine(data);
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          Console.WriteLine("Закрытие StreamWriter");
          logWriter.Close();
        }
        this.disposed = true;
      }
    }

    /// <summary>
    /// Деструктор.
    /// </summary>
    ~Logger()
    {
      Dispose(false);
    }
  }

}
