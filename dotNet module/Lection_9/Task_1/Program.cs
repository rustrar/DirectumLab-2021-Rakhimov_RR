using System;
using Task_4;

namespace Task_1
{
  class Program
  {
    static void Main(string[] args)
    {
      TextFileIterator textFileIterator = new TextFileIterator("ClientConnectionLog.log");
      textFileIterator.ReadFileToList();
      Filter filter = new Filter();
      DateTime date = DateTime.Parse("12.12.2007").Date;
      filter.FilterAndSort(textFileIterator.Iterate('\t'), date);
    }
  }
}
