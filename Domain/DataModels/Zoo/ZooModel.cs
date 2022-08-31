using System.Text.Json.Serialization;

namespace Domain.DataModels.Zoo;

public class ZooModel
{
    [JsonPropertyName("guid")]
    public Guid Guid { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("operatingTimes")]
    public List<OperatingTimeModel> OperatingTimes { get; set; } = new();
}