using System.Data;
using System.Linq;
using System.Text;

namespace Task_4._2
{
  class DataSetReader
  {
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
