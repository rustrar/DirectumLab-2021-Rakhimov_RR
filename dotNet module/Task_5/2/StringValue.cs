namespace Task_5._2
{
  class StringValue 
  {
    public string Value { get; private set; }

    public StringValue(string value)
    {
      this.Value = value;
    }

    public override bool Equals(object obj)
    {
      return Value.Equals((obj as StringValue).Value);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();  
    }

    public static bool operator ==(StringValue sv1, StringValue sv2)
    {
      return sv1.Value.Equals(sv2.Value);
    }

    public static bool operator !=(StringValue sv1, StringValue sv2)
    {
      return !sv1.Value.Equals(sv2.Value);
    }
  }
}
