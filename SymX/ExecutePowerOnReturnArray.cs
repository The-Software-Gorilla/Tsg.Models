using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// ExecutePowerOnReturnArray model for SymX API response
/// </summary>
public class ExecutePowerOnReturnArray
{
    /// <summary>
    /// Request property representing the request details in the SymX API response
    /// </summary>
    [XmlElement(ElementName = "Request", Namespace = "")]
    [JsonPropertyName("request")]
    public Request? Request { get; set; }    
}