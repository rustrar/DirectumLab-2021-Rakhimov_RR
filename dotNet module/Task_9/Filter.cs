using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_9
{
  /// <summary>
  /// Класс "FilterAndSort"
  /// </summary>
  public class Filter
  {
    /// <summary>
    /// Отфильтровать строки лог-файла на указанную дату и сортировать их по времени
    /// </summary>
    /// <param name="data">Данные, которые нужно обработать</param>
    /// <param name="date">Дата, по которой нужно отфильтровать строки лог-файла</param>
    public void FilterAndSort(List<FileString> data, DateTime date)
    {
      List<FileString> query = data.Where(d => d.Date.Date == date).OrderBy(d => d.Date).ToList<FileString>();
      foreach (FileString item in query)
        Console.WriteLine($"{item.Date} {item.Data}");
    }
  }
}
