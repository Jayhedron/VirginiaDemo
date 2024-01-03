using System.Text.Json.Serialization;

public class TextSource
{
    [JsonPropertyName("Introduction")]
    public string? Introduction { get; set; }
    
    [JsonPropertyName("History")]
    public string? History { get; set; }

    [JsonPropertyName("Composition")]
    public string? Composition { get; set; }
}