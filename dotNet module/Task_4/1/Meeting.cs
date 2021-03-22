using System;

namespace Task_4._1
{
  class Meeting
  {
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public TimeSpan Duration {
      get {
        return EndDate - StartDate;
      }
    }
  }
}