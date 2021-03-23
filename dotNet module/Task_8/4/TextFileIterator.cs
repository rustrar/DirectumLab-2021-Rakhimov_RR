using System.Collections.Generic;
using System.IO;

namespace Task_8._4
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
    /// Результирующий список со строками файла
    /// </summary>
    List<string> allLines = new List<string>();

    /// <summary>
    /// Считать текстовый файл в список
    /// </summary>
    public void ReadFileToList()
    {
      using (StreamReader reader = new StreamReader(this.filePath))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
          this.allLines.Add(line);
      }
    }

    /// <summary>
    /// Перебор списка со строками текстового файла
    /// </summary>
    public void Iterate()
    {
      foreach (string line in this.allLines)
      {
      }
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    public TextFileIterator(string filePath)
    {
      this.filePath = filePath;
    }
  }
}
