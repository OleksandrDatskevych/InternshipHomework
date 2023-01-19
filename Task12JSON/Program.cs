using Task12JSON;
using System.Text.Json;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Person> listOfPeople = new()
        {
            new(26, "Oleksandr"),
            new(27, "Oleksandr"),
            new(53, "Serhii")
        };
        City city = new("Kherson", 12, false, DateTime.Parse("2022-02-24 05:30"), listOfPeople);
        var pathToSolution = "C:\\Users\\oleksandr.datskevych\\source\\repos\\InternshipHomework\\";
        var options = new JsonSerializerOptions { WriteIndented = true };
        var fileName = pathToSolution + "json\\city.json";
        string jsonString = JsonSerializer.Serialize(city, options);
        File.WriteAllText(fileName, jsonString);
        var fileName2 = pathToSolution + "json\\listOfPeople.json";
        string jsonString2 = JsonSerializer.Serialize(listOfPeople, options);
        File.WriteAllText(fileName2, jsonString2);
        var fileName3 = pathToSolution + "\\json\\city2.json";
        City? city2 = JsonSerializer.Deserialize<City>(File.ReadAllText(fileName3), options);
        Console.WriteLine($"ID: {city2.Id}\nCity: {city2.CityName}\nDate: {city2.DateAndTime}\nIsOkay: {city2.IsOkay}\n" +
            $"1st person:\n{city2.ListOfPeople[0].Name} {city2.ListOfPeople[0].Age}");
        var fileName4 = pathToSolution + "json\\listOfPeople2.json";
        List<Person>? listOfPeople2 = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(fileName4), options);
        Console.WriteLine($"Person in list:\nAge: {listOfPeople2[0].Age}, Name: {listOfPeople2[0].Name}");
    }
}