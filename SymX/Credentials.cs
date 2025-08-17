using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Credentials required for SymX API access
/// </summary>
public class Credentials
{
    /// <summary>
    /// Processor user for SymX API access
    /// </summary>
    [XmlAttribute(AttributeName = "ProcessorUser", Namespace = "http://www.symxchange.generated.symitar.com/common/dto/common")]
    [JsonPropertyName("processorUser")]
    public string? ProcessorUser { get; set; }

    /// <summary>
    /// Administrative credentials for SymX API access
    /// </summary>
    [XmlElement(ElementName = "AdministrativeCredentials")]
    [JsonPropertyName("administrativeCredentials")]
    public AdministrativeCredentials? AdministrativeCredentials { get; set; }
    
}