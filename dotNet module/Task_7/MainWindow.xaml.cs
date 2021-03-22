using System.IO;
using System.IO.Compression;
using System.Windows;
using System.Windows.Documents;

namespace Task_7
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      LoadFromGzip("q2.rtf.gz");
    }

    private void LoadFromGzip(string filePath)
    {
      TextRange doc = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
      using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (GZipStream stream = new GZipStream(file, CompressionMode.Decompress))
        {
          doc.Load(stream, DataFormats.Rtf);
        }
    }
  }
}
