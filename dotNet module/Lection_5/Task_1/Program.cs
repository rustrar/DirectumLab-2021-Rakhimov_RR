using System;

namespace Task_1
{
  class Program
  {
    static void Main(string[] args)
    {      
      Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
      Console.WriteLine(new StringValue("AAA").Equals(new StringValue("Aaa")));
    }
  }
}
