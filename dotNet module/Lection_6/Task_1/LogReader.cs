using System;
using System.IO;

namespace Task_1
{
  class LogReader
  {
    string filePath;
    public LogReader(string filePath)
    {      
      this.filePath = filePath;
    }

    public int GetCountRecordsByDate(DateTime startDate, DateTime endDate)
    {
      int count = 0;
      string line;
      using (StreamReader reader = new StreamReader(filePath))
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
