// EnsentaResponseSoapBody.cs
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Ensenta SOAP body containing the DoDepositTransactionResponse element
/// </summary>
public class EnsentaResponseSoapBody
{
    /// <summary>
    /// DoDepositTransactionResponse element for the SOAP body
    /// </summary>
    [XmlElement("DoDepositTransactionResponse", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
    [JsonPropertyName("doDepositTransactionResponse")]
    public DoDepositTransactionResponse DoDepositTransactionResponse { get; set; } = new();
}