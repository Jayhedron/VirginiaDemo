using System.Text.Json.Serialization;

public class Representative
{
    [JsonPropertyName("First Name")]
    public string? FirstName { get; set; }
    
    [JsonPropertyName("Last Name")]
    public string? LastName { get; set; }

    [JsonPropertyName("District #")]
    public string? District { get; set; }

    [JsonPropertyName("Room #")]
    public object? Room { get; set; }

    [JsonPropertyName("Party")]
    public string? Party { get; set; }

    [JsonPropertyName("Capitol Phone")]
    public string? CapitolPhone { get; set; }

    [JsonPropertyName("District Phone")]
    public string? DistrictPhone { get; set; }

    [JsonPropertyName("Email")]
    public string? Email { get; set; }
}