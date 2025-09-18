using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Deposit transaction details for Ensenta RDC processing
/// </summary>
public class DoDepositTransaction
{
    /// <summary>
    /// Account holder number (string)
    /// </summary>
    [XmlElement("accountHolderNumber")]
    [JsonPropertyName("accountHolderNumber")]
    public string? AccountHolderNumber { get; set; }

    /// <summary>
    /// Account suffix (string)
    /// </summary>
    [XmlElement("acctSuffix")]
    [JsonPropertyName("acctSuffix")]
    public string? AcctSuffix { get; set; }

    /// <summary>
    /// Receipt transaction number (string)
    /// </summary>
    [XmlElement("receiptTransactionNumber")]
    [JsonPropertyName("receiptTransactionNumber")]
    public string? ReceiptTransactionNumber { get; set; }

    /// <summary>
    /// Station date and time in ISO 8601 format (string)
    /// </summary>
    [XmlElement("stationDateTime")]
    [JsonPropertyName("stationDateTime")]
    public DateTime? StationDateTime { get; set; }

    /// <summary>
    /// Reversal flag ("Y" or "N")
    /// </summary>
    [XmlElement("isReversalFlag")]
    [JsonPropertyName("isReversalFlag")]
    public string? IsReversalFlag { get; set; }

    /// <summary>
    /// Transaction type (e.g., "D" for deposit)
    /// </summary>
    [XmlElement("transactionType")]
    [JsonPropertyName("transactionType")]
    public string? TransactionType { get; set; }

    /// <summary>
    /// Fee amount in decimal format (string). "0.00" if no fee.
    /// </summary>
    [XmlElement("feeAmount")]
    [JsonPropertyName("feeAmount")]
    public string? FeeAmount { get; set; }

    /// <summary>
    /// Deposit items list
    /// </summary>
    [XmlArray("depositItems")]
    [XmlArrayItem("DepositItem")]
    [JsonPropertyName("depositItems")]
    public List<DepositItem>? DepositItems { get; set; }
}