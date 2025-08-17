using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Device information for SymX API interactions
/// </summary>
public class DeviceInformation
{
    /// <summary>
    /// Device type for SymX API interactions
    /// </summary>
    [XmlAttribute(AttributeName = "DeviceType")]
    [JsonPropertyName("deviceType")]
    public string? DeviceType { get; set; }

    /// <summary>
    /// Device number for SymX API interactions
    /// </summary>
    [XmlAttribute(AttributeName = "DeviceNumber")]
    [JsonPropertyName("deviceNumber")]
    public int DeviceNumber { get; set; }
}
