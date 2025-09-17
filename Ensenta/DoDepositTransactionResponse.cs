// DoDepositTransactionResponse.cs
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Response model for the DoDepositTransaction operation in Ensenta API
/// </summary>
[XmlRoot("DoDepositTransactionResponse", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
public class DoDepositTransactionResponse
{
    /// <summary>
    /// Result of the DoDepositTransaction operation
    /// </summary>
    [XmlElement("DoDepositTransactionResult", Namespace = EnsentaResponseSoapEnvelope.EnsentaNamespace)]
    [JsonPropertyName("doDepositTransactionResult")]
    public DoDepositTransactionResult DoDepositTransactionResult { get; set; } = new();
}