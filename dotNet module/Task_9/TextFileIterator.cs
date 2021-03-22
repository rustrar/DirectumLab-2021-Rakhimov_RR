using System;
using System.Collections.Generic;
using System.IO;

namespace Task_9
{
  class TextFileIterator
  {
    string filePath;
    List<string> allLines = new List<string>();
    List<FileString> fileStrings = new List<FileString>();

    public void ReadFileToList()
    {
      using (StreamReader reader = new StreamReader(this.filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
          allLines.Add(line);
      }
    }

    public List<FileString> Iterate(char separator)
    {
      foreach (string line in allLines)
      {
        var dataLine = line.Split(separator, 3);
        FileString fileString = new FileString() {
          Date = DateTime.Parse($"{dataLine[0]} {dataLine[1]}"),
          Data = dataLine[2]
        };
        fileStrings.Add(fileString);
      }
      return fileStrings;
    }

    public TextFileIterator(string filePath)
    {
      this.filePath = filePath;
    }
  }
}
