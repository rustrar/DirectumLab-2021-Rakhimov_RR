using System;
using System.Timers;

namespace Task_1
{
  public class MeetingWithRemind : Meeting, IRemind
  {
    public event EventHandler Remind;

    public DateTime ReminderDateTime { get; set; }

    private Timer timer;

    public DateTime GetRemindDateTime()
    {
      return ReminderDateTime;
    }

    public void SetRemindDateTime(DateTime reminderDateTime)
    {
      ReminderDateTime = reminderDateTime;
    }

    public MeetingWithRemind(DateTime reminderDateTime)
    {
      this.SetRemindDateTime(reminderDateTime);
      this.SetTimer();
    }
        
    private void SetTimer()
    {
      this.timer = new Timer();
      this.timer.Interval = 60000;
      this.timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
      this.timer.AutoReset = true;
      this.timer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
      DateTime reminderDateTimeWithoutMs = this.TrimpMilliseconds(ReminderDateTime);
      DateTime signalTimeWithoutMs = this.TrimpMilliseconds(e.SignalTime);
      if (DateTime.Compare(reminderDateTimeWithoutMs, signalTimeWithoutMs) == 0)
      {
        this.OnRemind();
        this.timer.Stop();
      }
    }

    private void OnRemind()
    {
      if (Remind != null)
        Remind(this, EventArgs.Empty);
    }

    private DateTime TrimpMilliseconds(DateTime dt)
    {
      return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
    }
  }
}