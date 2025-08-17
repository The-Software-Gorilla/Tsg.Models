using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// User defined parameters for a SymX PowerOn script execution.
/// </summary>
public class UserDefinedParameters
{
    /// <summary>
    /// Region for user defined character parameters.
    /// </summary>
    [XmlElement(ElementName = "RGUserChr")]
    [JsonPropertyName("rgUserChr")]
    public List<RgUserChr>? RgUserChr { get; set; }

    /// <summary>
    /// Region for user defined numeric parameters.
    /// </summary>
    [XmlElement(ElementName = "RGUserNum")]
    [JsonPropertyName("rgUserNum")]
    public List<RgUserNum>? RgUserNum { get; set; }
}
