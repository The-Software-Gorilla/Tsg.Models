using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Ensenta SOAP body containing the DoDepositTransaction element
/// </summary>
public class EnsentaRequestSoapBody
{
    /// <summary>
    /// DoDepositTransaction element for the SOAP body
    /// </summary>
    [XmlElement(ElementName = "DoDepositTransaction", Namespace = EnsentaRequestSoapEnvelope.EnsentaNamespace)]
    [JsonPropertyName("doDepositTransaction")]
    public DoDepositTransaction? DoDepositTransaction { get; set; }
}