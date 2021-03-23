using System.Data;
using System.Linq;
using System.Text;

namespace Task_4._2
{
  /// <summary>
  /// Класс для чтения DataSet
  /// </summary>
  public class DataSetReader
  {
    /// <summary>
    /// Вывести DataSet в одной строке
    /// </summary>
    /// <param name="dataSet">Набор данных</param>
    /// <param name="rowSeparator">Разделитель записей</param>
    /// <param name="columnSeparator">Разделитель колонок</param>
    /// <returns>DataSet в одной строке</returns>
    public string ToString(DataSet dataSet, string rowSeparator, string columnSeparator)
    {
      StringBuilder strBuilder = new StringBuilder();
      foreach (DataTable dt in dataSet.Tables)
      {
        string[] columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
        strBuilder.AppendJoin(columnSeparator, columnNames);
        strBuilder.Append(rowSeparator);

        foreach (DataRow row in dt.Rows)
          strBuilder.AppendJoin(rowSeparator, row.ItemArray);
      }
      return strBuilder.ToString();
    }
  }
}
