using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Request model for SymX API interactions
/// </summary>
public class Request
{
    /// <summary>
    /// Branch ID for the request, corresponds to the branch making the request
    /// </summary>
    [XmlAttribute(AttributeName = "BranchId")]
    [JsonPropertyName("branchId")]
    public int BranchId { get; set; }

    /// <summary>
    /// Credentials required for SymX API access
    /// </summary>
    [XmlElement(ElementName = "Credentials")]
    [JsonPropertyName("credentials")]
    public Credentials? Credentials { get; set; }

    /// <summary>
    /// Device information for SymX API interactions
    /// </summary>
    [XmlElement(ElementName = "DeviceInformation")]
    [JsonPropertyName("deviceInformation")]
    public DeviceInformation? DeviceInformation { get; set; }

    /// <summary>
    /// Header information for the request
    /// </summary>
    [XmlElement(ElementName = "Header")]
    [JsonPropertyName("header")]
    public RequestHeader? Header { get; set; }

    /// <summary>
    /// Body content for the request
    /// </summary>
    [XmlElement(ElementName = "Body")]
    [JsonPropertyName("body")]
    public RequestBody? Body { get; set; }
    
}