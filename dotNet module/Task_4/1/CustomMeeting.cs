namespace Task_4._1
{
  /// <summary>
  /// Тип встречи
  /// </summary>
  public enum MeetingTypes
  {
    /// <summary>
    /// Тип "Совещание"
    /// </summary>
    meeting,

    /// <summary>
    /// Тип "Поручение"
    /// </summary>
    assignment,

    /// <summary>
    /// Тип "Звонок"
    /// </summary>
    call,

    /// <summary>
    /// Тип "День рождения"
    /// </summary>
    birthday
  }

  /// <summary>
  /// Класс "Встреча" с типом встречи
  /// </summary>
  public class CustomMeeting : Meeting
  {
    /// <summary>
    /// Тип встречи
    /// </summary>
    private MeetingTypes meetingType;

    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="meetingType">Тип встречи</param>
    public CustomMeeting(MeetingTypes meetingType)
    {
      this.meetingType = meetingType;
    }
  }
}