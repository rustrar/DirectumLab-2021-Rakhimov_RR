using System;

namespace Task_1
{
  public interface IRemind
  {
    public DateTime ReminderDateTime { get; set; }

    public void SetRemindDateTime(DateTime reminderDateTime);    

    public DateTime GetRemindDateTime();
  }
}
