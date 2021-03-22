using System;
using System.IO;
using System.IO.Compression;
using System.Windows;
using System.Windows.Documents;

namespace Task_8
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      LoadFromGzip("q2.rtf.gz1");
    }

    private void LoadFromGzip(string filePath)
    {
      TextRange doc = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
      FileStream file = null;
      GZipStream stream = null;
      try
      {
        file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        stream = new GZipStream(file, CompressionMode.Decompress);
        doc.Load(stream, DataFormats.Rtf);
      }
      catch (FileNotFoundException e)
      {
        throw new LoadFileException(e.Message, e);
      }
      catch (UnauthorizedAccessException e)
      {
        throw new LoadFileException(e.Message, e);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
      finally
      {
        if (stream != null)
          stream.Close();

        if (file != null)
          file.Close();
      }
    }
  }
}
