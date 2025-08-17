using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// Soap body for SymX PowerOn script execution request.
/// </summary>
public class SymXSoapBody
{
    /// <summary>
    /// Encapsulates the request to executing a SymX PowerOn script.
    /// </summary>
    [XmlElement(ElementName = "executePowerOnReturnArray", Namespace = "http://www.symxchange.generated.symitar.com/poweron")]
    [JsonPropertyName("executePowerOnReturnArray")]
    public ExecutePowerOnReturnArray? ExecutePowerOnReturnArray { get; set; }
}