using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_reader
{
  class Program
  {

    static IEnumerable<T> GetRecords<T>(string filename)
    {
      using (var streamReader = new StreamReader(filename))
      {
        var configuration = new Configuration
        {
          Delimiter = ",",
          HasHeaderRecord = true
        };

        using (var csvReader = new CsvReader(streamReader, configuration))
        {
          return csvReader.GetRecords<T>().ToArray();
        }
      }
    }

    static void Main(string[] args)
    {

      var people = GetRecords<Person>("MOCK_DATA.csv");

      foreach (var person in people)
      {
        Console.WriteLine(person);
      }

      Console.ReadLine();
    }
  }
}
