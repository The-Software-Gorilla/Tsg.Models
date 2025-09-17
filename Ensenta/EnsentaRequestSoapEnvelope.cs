using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Ensenta SOAP envelope for wrapping the SOAP body
/// </summary>
[XmlRoot(ElementName = "Envelope", Namespace = SoapEnvelopeNamespace)]
public class EnsentaRequestSoapEnvelope
{
    
    public const string SoapEnvelopeNamespace = "http://schemas.xmlsoap.org/soap/envelope/";
    public const string EnsentaNamespace = "http://ensenta.com/ECWebDepositHostRequest";

    [XmlNamespaceDeclarations]
    public XmlSerializerNamespaces Xmlns
    {
        get
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("soap", SoapEnvelopeNamespace);
            ns.Add("ens", EnsentaNamespace);
            ns.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            return ns;
        }
        set { }
    }

    /// <summary>
    /// Body of the SOAP envelope
    /// </summary>
    [XmlElement(ElementName = "Body", Namespace = SoapEnvelopeNamespace)]
    [JsonPropertyName("body")]
    public EnsentaRequestSoapBody? Body { get; set; }
}