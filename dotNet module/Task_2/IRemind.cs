using System;

namespace Task_2
{
  /// <summary>
  /// Интерфейс "Напоминание"
  /// </summary>
  public interface IRemind
  {
    /// <summary>
    /// Дата-время напоминания о событии
    /// </summary>
    DateTime ReminderDateTime { get; set; }

    /// <summary>
    /// Установить дату-время напоминания о событии
    /// </summary>
    /// <param name="reminderDateTime">Дата-время напоминания о событии</param>
    void SetRemindDateTime(DateTime reminderDateTime);

    /// <summary>
    /// Считать дату-время напоминания о событии
    /// </summary>
    /// <returns>Дата-время напоминания о событии</returns>
    DateTime GetRemindDateTime();
  }
}
