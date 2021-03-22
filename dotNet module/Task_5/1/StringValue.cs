namespace Task_5._1
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
  }
}
