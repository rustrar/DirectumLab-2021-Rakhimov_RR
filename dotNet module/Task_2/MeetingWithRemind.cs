using System;
using System.Timers;

namespace Task_2
{
  /// <summary>
  /// Класс "Встреча с напоминанием"
  /// </summary>
  public class MeetingWithRemind : Meeting, IRemind
  {
    /// <summary>
    /// Событие Remind
    /// </summary>
    public event EventHandler Remind;

    /// <summary>
    /// Дата-время напоминания о событии
    /// </summary>
    public DateTime ReminderDateTime { get; set; }

    /// <summary>
    /// Таймер для проверки времени напоминания
    /// </summary>
    private Timer timer;

    /// <summary>
    /// Считать дату-время напоминания о событии
    /// </summary>
    /// <returns>Дата-время напоминания о событии</returns>
    public DateTime GetRemindDateTime()
    {
      return this.ReminderDateTime;
    }

    /// <summary>
    /// Установить дату-время напоминания о событии
    /// </summary>
    /// <param name="reminderDateTime">Дата-время напоминания о событии</param>
    public void SetRemindDateTime(DateTime reminderDateTime)
    {
      this.ReminderDateTime = reminderDateTime;
    }

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="reminderDateTime">Дата-время напоминания</param>
    public MeetingWithRemind(DateTime reminderDateTime)
    {
      this.SetRemindDateTime(reminderDateTime);
      this.SetTimer();
    }

    /// <summary>
    /// Установить таймер
    /// </summary>
    private void SetTimer()
    {
      this.timer = new Timer();
      this.timer.Interval = 60000;
      this.timer.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
      this.timer.AutoReset = true;
      this.timer.Enabled = true;
    }

    /// <summary>
    /// Обработка события таймера
    /// </summary>
    /// <param name="source">Объект, который вызвал событие</param>
    /// <param name="e">Данные для события Elapsed</param>
    private void OnTimedEvent(object source, ElapsedEventArgs e)
    {
      DateTime reminderDateTimeWithoutMs = this.TrimpMilliseconds(this.ReminderDateTime);
      DateTime signalTimeWithoutMs = this.TrimpMilliseconds(e.SignalTime);
      if (DateTime.Compare(reminderDateTimeWithoutMs, signalTimeWithoutMs) == 0)
      {
        this.OnRemind();
        this.timer.Stop();
      }
    }

    /// <summary>
    /// Генерация события
    /// </summary>
    private void OnRemind()
    {
      if (this.Remind != null)
        this.Remind(this, EventArgs.Empty);
    }

    /// <summary>
    /// Убрать миллисекунды из даты-времени
    /// </summary>
    /// <param name="dt">Исходная дата-время</param>
    /// <returns>Дата-время без миллисекунд</returns>
    private DateTime TrimpMilliseconds(DateTime dt)
    {
      return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
    }
  }
}