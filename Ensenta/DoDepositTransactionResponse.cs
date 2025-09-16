// DoDepositTransactionResponse.cs
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

[XmlRoot("DoDepositTransactionResponse", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
public class DoDepositTransactionResponse
{
    [XmlElement("DoDepositTransactionResult", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
    [JsonPropertyName("doDepositTransactionResult")]
    public DoDepositTransactionResult DoDepositTransactionResult { get; set; } = new();
}