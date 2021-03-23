using System;
using System.IO;

namespace Task_6
{
  /// <summary>
  /// Класс LogReader
  /// </summary>
  public class LogReader
  {
    /// <summary>
    /// Путь до файла
    /// </summary>
    private string filePath;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="filePath">Путь до файла</param>
    public LogReader(string filePath)
    {      
      this.filePath = filePath;
    }

    /// <summary>
    /// Подсчитать количество записей за указный интервал
    /// </summary>
    /// <param name="startDate">Дата начала</param>
    /// <param name="endDate">Дата окончания</param>
    /// <returns>Количество записей за указный интервал</returns>
    public int GetCountRecordsByDate(DateTime startDate, DateTime endDate)
    {
      int count = 0;
      string line;
      using (StreamReader reader = new StreamReader(this.filePath))
      {
        while ((line = reader.ReadLine()) != null)
        {
          DateTime dateFromLine;
          if (!DateTime.TryParse(line.Split('\t')[0], out dateFromLine))
            continue;
          
          if (dateFromLine >= startDate && dateFromLine <= endDate)
            count++;
        }
      }      
      return count;
    }
  }
}
