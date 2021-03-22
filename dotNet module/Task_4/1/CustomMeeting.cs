namespace Task_4._1
{
  enum MeetingTypes
  {
    meeting,
    assignment,
    call,
    birthday
  }

  class CustomMeeting : Meeting
  {
    private MeetingTypes meetingType;

    public CustomMeeting(MeetingTypes meetingType)
    {
      this.meetingType = meetingType;
    }
  }
}