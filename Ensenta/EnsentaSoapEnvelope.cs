using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Ensenta SOAP envelope for wrapping the SOAP body
/// </summary>
[XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class EnsentaSoapEnvelope
{
    /// <summary>
    /// Body of the SOAP envelope
    /// </summary>
    [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public EnsentaSoapBody? Body { get; set; }
}