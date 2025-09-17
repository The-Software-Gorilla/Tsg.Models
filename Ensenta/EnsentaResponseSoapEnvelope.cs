using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

[XmlRoot("Envelope", Namespace = SoapEnvelopeNamespace)]
public class EnsentaResponseSoapEnvelope
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

    [XmlElement("Body", Namespace = SoapEnvelopeNamespace)]
    [JsonPropertyName("body")]
    public EnsentaResponseSoapBody? Body { get; set; } = new();
}