using System.Text.Json;


public partial class Program
{
    public static async Task GenerateCountryDataFiles()
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {

                string apiUrl = "https://restcountries.com/v3.1/all";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    var countries = JsonSerializer.Deserialize<Country[]>(json);

                    Directory.CreateDirectory("CountryData");

                    foreach (var country in countries)
                    {
                        string fileName = $"CountryData/{country.Name}.txt";
                        using (StreamWriter writer = File.CreateText(fileName))
                        {
                            writer.WriteLine($"Region: {country.Region}");
                            writer.WriteLine($"Subregion: {country.Subregion}");
                            writer.WriteLine($"Latlng: {string.Join(", ", country.Latlng)}");
                            writer.WriteLine($"Area: {country.Area}");
                            writer.WriteLine($"Population: {country.Population}");
                        }
                    }

                    Console.WriteLine("Document has been created");
                }
                else
                {
                    Console.WriteLine("Could not retrieve data from API.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void Main(string[] args)
    {
        GenerateCountryDataFiles().Wait();
    }
}

