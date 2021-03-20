using System;

namespace Task_2
{
  class Program
  {
    static void Main(string[] args)
    {      
      Console.WriteLine(new StringValue("AAA").Equals(new StringValue("AAA")));
      Console.WriteLine(new StringValue("AAA").Equals(new StringValue("Aaa")));

      Console.WriteLine(new StringValue("AAA") == new StringValue("AAA"));
      Console.WriteLine(new StringValue("AAA") == new StringValue("Aaa"));

      Console.WriteLine(new StringValue("AAA") != new StringValue("Aaa"));
      Console.WriteLine(new StringValue("AAA") != new StringValue("AAA"));
    }
  }
}
