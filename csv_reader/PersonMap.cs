using CsvHelper.Configuration;

namespace csv_reader
{
  public sealed class PersonMap : ClassMap<Person>
  {
    public PersonMap()
    {
      AutoMap();
    }
  }
}
