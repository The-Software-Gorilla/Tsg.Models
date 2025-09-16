// EnsentaResponseSoapBody.cs
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

public class EnsentaResponseSoapBody
{
    [XmlElement("DoDepositTransactionResponse", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
    [JsonPropertyName("doDepositTransactionResponse")]
    public DoDepositTransactionResponse DoDepositTransactionResponse { get; set; } = new();
}