using System;

namespace Task_2
{
  /// <summary>
  /// Класс "Встреча"
  /// </summary>
  public class Meeting
  {
    /// <summary>
    /// Дата начала встречи
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Дата окончания встречи
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Продолжительность встречи
    /// </summary>
    public TimeSpan Duration 
    {
      get 
      {
        return this.EndDate - this.StartDate;
      }
    }
  }
}