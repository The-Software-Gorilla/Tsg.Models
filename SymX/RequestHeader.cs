using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Represents the header of a request to the SymX API.
/// </summary>
public class RequestHeader
{
    /// <summary>
    /// Message identifier for tracking the request.
    /// </summary>
    [XmlElement(ElementName = "MessageID")]
    [JsonPropertyName("messageID")]
    public string? MessageId { get; set; }
}