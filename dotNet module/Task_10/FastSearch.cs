using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_10
{
  /// <summary>
  /// Класс "FastSearch"
  /// </summary>
  /// <typeparam name="T">Тип</typeparam>
  public class FastSearch<T>
  {
    /// <summary>
    /// Максимальное количество параллельных задач 
    /// </summary>
    public int JobCount { get; set; }

    /// <summary>
    /// Минимальное количество значений, обрабатываемых в одной задаче
    /// </summary>
    public int HandleSize { get; set; }

    /// <summary>
    /// Флаг, что нужно использовать настройки
    /// </summary>
    private bool useSettings = false;

    /// <summary>
    /// Сконфигурировать класс для указания jobCount и valueCount
    /// </summary>
    /// <param name="jobCount">Максимальное количество параллельных задач </param>
    /// <param name="valueCount">Минимальное количество значений, обрабатываемых в одной задаче</param>
    public void Configure(int jobCount, int valueCount)
    {
      this.JobCount = jobCount;
      this.HandleSize = valueCount;
      this.useSettings = true;
    }

    /// <summary>
    /// Параллельный поиск
    /// </summary>
    /// <param name="source">Коллекция значений</param>
    /// <param name="filter">Условие поиска</param>
    /// <returns>Коллекция с найденными элементами</returns>
    public IEnumerable<T> Search(IEnumerable<T> source, Func<T, bool> filter)
    {
      if (this.useSettings)
        return SearchWithParams(source, filter);

      return SearchWithoutParams(source, filter);
    }

    /// <summary>
    /// Параллельный поиск с параметрами
    /// </summary>
    /// <param name="source">Коллекция значений</param>
    /// <param name="filter">Условие поиска</param>
    /// <returns>Коллекция с найденными элементами</returns>
    private IEnumerable<T> SearchWithParams(IEnumerable<T> source, Func<T, bool> filter)
    {
      var parallelOptions = new ParallelOptions();
      parallelOptions.MaxDegreeOfParallelism = this.JobCount;
      var rangePartitioner = Partitioner.Create(0, source.Count(), source.Count()/ this.HandleSize);
      var result = new ConcurrentBag<T>();

      Parallel.ForEach(rangePartitioner, parallelOptions, (range) =>
      {
        for (int i = range.Item1; i < range.Item2; i++)
        {
          var item = source.ElementAt(i);
          if (filter(item))
            result.Add(item);          
        }
      });
      return result.ToList();
    }

    /// <summary>
    /// Параллельный поиск без параметров
    /// </summary>
    /// <param name="source">Коллекция значений</param>
    /// <param name="filter">Условие поиска</param>
    /// <returns>Коллекция с найденными элементами</returns>
    private IEnumerable<T> SearchWithoutParams(IEnumerable<T> source, Func<T, bool> filter)
    {
      return source.AsParallel().Where(filter).ToList();
    }
  }
}
