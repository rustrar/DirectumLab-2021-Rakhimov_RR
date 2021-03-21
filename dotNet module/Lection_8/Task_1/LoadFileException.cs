using System;

namespace Task_1
{
  class LoadFileException : Exception
  {
    public LoadFileException(string message, Exception innerException) : base(message, innerException)
    {
    }
  }
}
