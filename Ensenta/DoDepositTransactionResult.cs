using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

public class DoDepositTransactionResult
{
    [XmlElement("ResponseDescription")]
    [JsonPropertyName("responseDescription")]
    public string? ResponseDescription { get; set; }

    [XmlElement("ResponseCode")]
    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; set; }

    [XmlElement("SystemTraceNumber")]
    [JsonPropertyName("systemTraceNumber")]
    public string? SystemTraceNumber { get; set; }

    [XmlElement("TransmitZuluDateTime")]
    [JsonPropertyName("transmitZuluDateTime")]
    public DateTime TransmitZuluDateTime { get; set; }

    [XmlElement("TransactionId", IsNullable = true)]
    [JsonPropertyName("transactionId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Guid? TransactionId { get; set; }
}
