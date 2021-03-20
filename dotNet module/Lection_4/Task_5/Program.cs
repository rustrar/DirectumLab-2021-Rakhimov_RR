using System;

namespace Task_5
{
  class Program
  {
    static void Main(string[] args)
    {
      //Logger logger = new Logger("test.txt");
      //logger.WriteString("Data");

      Logger logger2 = null;
      try
      {
        logger2 = new Logger("test.txt");
        logger2.WriteString("Data2");
      }
      finally
      {
        if (logger2 != null)
          logger2.Dispose();
      }

      using (Logger logger3 = new Logger("test.txt"))
        logger3.WriteString("Data3");

      Console.WriteLine("Конец метода");
    }
  }
}
