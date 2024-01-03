using System.Text.Json.Serialization;

public class RepHistory
{
    [JsonPropertyName("Years")]
    public int? Years { get; set; }
    
    [JsonPropertyName("Democrats")]
    public int? Democrats { get; set; }

    [JsonPropertyName("Republicans")]
    public int? Republicans { get; set; }

    [JsonPropertyName("Independents")]
    public int? Independents { get; set; }
}