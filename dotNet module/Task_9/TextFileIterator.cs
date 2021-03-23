using System;
using System.Collections.Generic;
using System.IO;

namespace Task_9
{
  /// <summary>
  /// Класс TextFileIterator"
  /// </summary>
  public class TextFileIterator
  {
    /// <summary>
    /// Путь до текстового файла
    /// </summary>
    string filePath;

    /// <summary>
    /// Список со строками файла
    /// </summary>
    List<string> allLines = new List<string>();

    /// <summary>
    /// 
    /// </summary>
    List<FileString> fileStrings = new List<FileString>();

    /// <summary>
    /// Считать текстовый файл в список
    /// </summary>
    public void ReadFileToList()
    {
      using (StreamReader reader = new StreamReader(this.filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
          allLines.Add(line);
      }
    }

    /// <summary>
    /// Перебор списка со строками текстового файла
    /// </summary>
    /// <param name="separator">Разделитель</param>
    /// <returns>Список с элементами типа FileString</returns>
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

    /// <summary>
    /// Конструкор класса
    /// </summary>
    /// <param name="filePath">Путь до файла</param>
    public TextFileIterator(string filePath)
    {
      this.filePath = filePath;
    }
  }
}
