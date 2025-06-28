using CsvHelper;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq; // Required for ToList()

// ... inside a method or class ...
public List<MyClass> ReadCsv(string filePath)
{
    using (var reader = new StreamReader(filePath))
    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
    {
        // Assuming MyClass has properties that match the CSV columns
        return csv.GetRecords<MyClass>().ToList();
    }
}

// Example usage:
// Assuming you have a class like this:
public class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Value { get; set; }
}
// and a method to call the csv reading method
// var data = ReadCsv("path/to/your/file.csv");
