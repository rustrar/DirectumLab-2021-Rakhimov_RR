using System.Collections.Generic;
using System.IO;

namespace Task_8._4
{
  class TextFileIterator<T>
  {
    string filePath;
    List<string> allLines = new List<string>();

    public void ReadFileToList()
    {
      using (StreamReader reader = new StreamReader(filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)        
          allLines.Add(line);
      }
    }

    public void Iterate()
    {
      foreach (string line in allLines)
      {
      }
    }
  }
}
