using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Represents the body of a request to the SymX API.
/// </summary>
public class RequestBody
{
    /// <summary>
    /// PowerOn Script file name to be executed.
    /// </summary>
    [XmlElement(ElementName = "File")]
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// Register Group Session identifier.
    /// </summary>
    [XmlElement(ElementName = "RGSession")]
    [JsonPropertyName("rgSession")]
    public int RgSession { get; set; }

    /// <summary>
    /// User-defined parameters for the request.
    /// </summary>
    [XmlElement(ElementName = "UserDefinedParameters")]
    [JsonPropertyName("userDefinedParameters")]
    public UserDefinedParameters? UserDefinedParameters { get; set; }

    /// <summary>
    /// User initiating the request.
    /// </summary>
    [XmlElement(ElementName = "User")]
    [JsonPropertyName("user")]
    public string? User { get; set; }
}
