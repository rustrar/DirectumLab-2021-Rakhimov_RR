using System;

namespace Task_2
{
  interface IRemind
  {
    DateTime ReminderDateTime { get; set; }

    void SetRemindDateTime(DateTime reminderDateTime);    

    DateTime GetRemindDateTime();
  }
}
