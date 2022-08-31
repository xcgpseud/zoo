using System.Text.Json.Serialization;

namespace Domain.DataModels.Zoo;

public class OperatingTimeModel
{
    [JsonPropertyName("openingTime")]
    public DateTime OpeningTime { get; set; }
    
    [JsonPropertyName("closingTime")]
    public DateTime ClosingTime { get; set; }
}