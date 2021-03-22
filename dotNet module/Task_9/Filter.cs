using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_9
{
  class Filter
  {
    public void FilterAndSort(List<FileString> data, DateTime date)
    {
      List<FileString> query = data.Where(d => d.Date.Date == date).OrderBy(d => d.Date).ToList<FileString>();
      foreach (FileString item in query)
        Console.WriteLine($"{item.Date} {item.Data}");
    }
  }
}
