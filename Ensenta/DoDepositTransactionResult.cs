using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Deposit transaction result model for Ensenta API response
/// </summary>
public class DoDepositTransactionResult
{
    /// <summary>
    /// Response description providing details about the transaction result
    /// </summary>
    [XmlElement("ResponseDescription")]
    [JsonPropertyName("responseDescription")]
    public string? ResponseDescription { get; set; }

    /// <summary>
    /// Response code indicating the status of the transaction
    /// </summary>
    [XmlElement("ResponseCode")]
    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; set; }

    /// <summary>
    /// System trace number for tracking the transaction
    /// </summary>
    [XmlElement("SystemTraceNumber")]
    [JsonPropertyName("systemTraceNumber")]
    public string? SystemTraceNumber { get; set; }

    /// <summary>
    /// Transmit date and time in Zulu (UTC) format
    /// </summary>
    [XmlElement("TransmitZuluDateTime")]
    [JsonPropertyName("transmitZuluDateTime")]
    public DateTime TransmitZuluDateTime { get; set; }

    /// <summary>
    /// Transaction ID as a GUID, nullable
    /// </summary>
    [XmlElement("TransactionId", IsNullable = true)]
    [JsonPropertyName("transactionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Guid? TransactionId { get; set; }
}
