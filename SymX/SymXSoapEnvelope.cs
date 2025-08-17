using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// SOAP envelope for SymX web service requests and responses.
/// </summary>
[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class SymXSoapEnvelope
{
    /// <summary>
    /// Header for the SOAP envelope. This property represents the header section of the SOAP message
    /// that is almost always empty for SymX web service calls.
    /// </summary>
    [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [JsonPropertyName("header")]
    public SymXSoapHeader? Header { get; set; }

    /// <summary>
    /// Body for the SOAP envelope. This property represents the body section of the SOAP message
    /// that contains the actual request or response data for the SymX web service call.
    /// </summary>
    [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [JsonPropertyName("body")]
    public SymXSoapBody? Body { get; set; }
}