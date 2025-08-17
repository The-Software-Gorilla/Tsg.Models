using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Represents a user defined numeric parameter for a SymX PowerOn script.
/// </summary>
public class RgUserNum
{
    /// <summary>
    /// Ordinal Id of the user defined numeric parameter as defined in the SymX PowerOn script.
    /// </summary>
    [XmlElement(ElementName = "ID")]
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Value of the user defined numeric parameter as defined in the SymX PowerOn script.
    /// </summary>
    [XmlElement(ElementName = "Value")]
    [JsonPropertyName("value")]
    public int Value { get; set; }
}