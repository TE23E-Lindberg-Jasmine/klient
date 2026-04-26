using System;
using System.Text.Json;
using System.Text.Json.Serialization;


string jsonText = "{\"city\": \"Stockholm\", \"temp\": 15}";

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

// Vi använder try-catch ifall jsonText skulle vara trasig
try 
{
    Weather myWeather = JsonSerializer.Deserialize<Weather>(jsonText, options);
    Console.WriteLine($"Det är {myWeather.Temperature} grader i {myWeather.City}.");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine($"Hoppsan! Det gick inte att tyda JSON: {ex.Message}");
        Console.ReadLine();
}


public class Weather
{
    [JsonPropertyName("city")] 
    public string City { get; set; } 
    
    [JsonPropertyName("temp")]
    public int Temperature { get; set; }
}


