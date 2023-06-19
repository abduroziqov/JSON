using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company
            {
                Id = 1,
                Name = "Anvar",
                Cars = new List<Car> {
                new Car { Id = 1, Name = "BMW ", Price = 120000 },
                new Car { Id = 2, Name = "MERS ", Price = 125000 }
                }
            };

            string json = JsonSerializer.Serialize(company);
            Console.WriteLine(json);

            Console.ReadLine();

            string path = Directory.GetCurrentDirectory();
            path += "\\company.json";

            string json2 = JsonSerializer.Serialize(company);

            if (!File.Exists(path))
            {
                File.Create(path).Close();

                File.WriteAllText(path, json2);
            }
        }
    }
}   