namespace Task_1
{
  public enum MeetingTypes
  {
    meeting,
    assignment,
    call,
    birthday
  }

  public class CustomMeeting : Meeting
  {
    private MeetingTypes meetingType;

    public CustomMeeting(MeetingTypes meetingType)
    {
      this.meetingType = meetingType;
    }
  }
}