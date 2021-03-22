using System;

namespace Task_8
{
  class LoadFileException : Exception
  {
    public LoadFileException(string message, Exception innerException) : base(message, innerException)
    {
    }
  }
}
