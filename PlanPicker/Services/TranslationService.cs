using System.Reflection;
using System.Text.Json;

public class TranslationService
{
    public TranslationService()
    {
        
    }

    public async Task<Dictionary<string, Dictionary<string, string>>> LoadJsonAsync()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("translations.json");
            using var reader = new StreamReader(stream);
            var json = await reader.ReadToEndAsync();

            var translations = System.Text.Json.JsonSerializer.Deserialize< Dictionary<string, Dictionary<string, string>>> (json);
            return translations ?? new();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error LoadJsonAsync:" + ex.Message);
            return new();
        }
        
    }
}