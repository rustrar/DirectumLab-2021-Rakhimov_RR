using System;

namespace Task_1
{
  class Program
  {
    static void Main(string[] args)
    {
      LogReader reader = new LogReader("ClientConnectionLog.log");
      DateTime startDate = DateTime.Parse("11.12.2007");
      DateTime endDate = DateTime.Parse("12.12.2007");
      Console.WriteLine(reader.GetCountRecordsByDate(startDate, endDate));

      Console.WriteLine("Hello World!");
    }
  }
}
