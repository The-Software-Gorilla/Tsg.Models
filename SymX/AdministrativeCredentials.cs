using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Administrative credentials for SymX API access
/// </summary>
public class AdministrativeCredentials
{
    /// <summary>
    /// Password for SymX administrative access
    /// </summary>
    [XmlElement(ElementName = "Password")]
    [JsonPropertyName("password")]
    public string? Password { get; set; }
    
}