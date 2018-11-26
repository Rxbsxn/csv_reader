namespace csv_reader
{
  public class Person
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
      return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}";
    }
  }
}
