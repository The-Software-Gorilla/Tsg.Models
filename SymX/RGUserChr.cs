using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Represents a user defined character parameter for a SymX PowerOn script.
/// </summary>
public class RgUserChr
{
    /// <summary>
    /// Ordinal ID of the user defined character parameter as defined in the SymX PowerOn script.
    /// </summary>
    [XmlElement(ElementName = "ID")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Value of the user defined character parameter as defined in the SymX PowerOn script.
    /// </summary>
    [XmlElement(ElementName = "Value")]
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}