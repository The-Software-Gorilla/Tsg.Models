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
    [XmlElement("AccountHolderNumber")]
    [JsonPropertyName("accountHolderNumber")]
    public string? AccountHolderNumber { get; set; }

    /// <summary>
    /// Account suffix (string)
    /// </summary>
    [XmlElement("AcctSuffix")]
    [JsonPropertyName("acctSuffix")]
    public string? AcctSuffix { get; set; }

    /// <summary>
    /// Receipt transaction number (string)
    /// </summary>
    [XmlElement("ReceiptTransactionNumber")]
    [JsonPropertyName("receiptTransactionNumber")]
    public string? ReceiptTransactionNumber { get; set; }

    /// <summary>
    /// Station date and time in ISO 8601 format (string)
    /// </summary>
    [XmlElement("StationDateTime")]
    [JsonPropertyName("stationDateTime")]
    public string? StationDateTime { get; set; }

    /// <summary>
    /// Reversal flag ("Y" or "N")
    /// </summary>
    [XmlElement("IsReversalFlag")]
    [JsonPropertyName("isReversalFlag")]
    public string? IsReversalFlag { get; set; }

    /// <summary>
    /// Transaction type (e.g., "D" for deposit)
    /// </summary>
    [XmlElement("TransactionType")]
    [JsonPropertyName("transactionType")]
    public string? TransactionType { get; set; }

    /// <summary>
    /// Fee amount in decimal format (string). "0.00" if no fee.
    /// </summary>
    [XmlElement("FeeAmount")]
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