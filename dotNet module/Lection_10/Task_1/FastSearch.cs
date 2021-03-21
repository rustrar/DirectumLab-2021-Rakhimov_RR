using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_1
{
  class FastSearch<T>
  {
    public int JobCount { get; set; }
    public int HandleSize { get; set; }

    private bool useSettings = false;

    public void Configure(int jobCount, int valueCount)
    {
      JobCount = jobCount;
      HandleSize = valueCount;
      useSettings = true;
    }

    public IEnumerable<T> Search(IEnumerable<T> source, Func<T, bool> filter)
    {
      if (useSettings)
        return SearchWithParams(source, filter);

      return SearchWithoutParams(source, filter);
    }    

    private IEnumerable<T> SearchWithParams(IEnumerable<T> source, Func<T, bool> filter)
    {
      var parallelOptions = new ParallelOptions();
      parallelOptions.MaxDegreeOfParallelism = JobCount;
      var rangePartitioner = Partitioner.Create(0, source.Count(), source.Count()/HandleSize);
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

    private IEnumerable<T> SearchWithoutParams(IEnumerable<T> source, Func<T, bool> filter)
    {
      return source.AsParallel().Where(filter).ToList();
    }
    
  }
}
