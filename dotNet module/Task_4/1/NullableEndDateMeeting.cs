using System;

namespace Task_4._1
{
  /// <summary>
  /// Класс "Встреча"
  /// </summary>
  public class NullableEndDateMeeting : Meeting
  {
    /// <summary>
    /// Дата окончания встречи
    /// </summary>
    public new DateTime? EndDate { get; set; }
  }
}
