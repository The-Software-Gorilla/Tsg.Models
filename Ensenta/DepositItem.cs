using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Deposit item details for Ensenta RDC processing
/// </summary>
public class DepositItem
{
    /// <summary>
    /// Amount in decimal format
    /// </summary>
    [XmlElement]
    [JsonPropertyName("Amount")]
    public string? Amount { get; set; }

    /// <summary>
    /// Code line associated with the deposit item
    /// </summary>
    [XmlElement]
    [JsonPropertyName("CodeLine")]
    public string? CodeLine { get; set; }

    /// <summary>
    /// Host hold code for the deposit item
    /// </summary>
    [XmlElement]
    [JsonPropertyName("HostHoldCode")]
    public string? HostHoldCode { get; set; }

    /// <summary>
    /// Front image file contents as Base64-encoded string
    /// </summary>
    [XmlElement]
    [JsonPropertyName("FrontFileContents")]
    public string? FrontFileContents { get; set; }

    /// <summary>
    /// Back image file contents as Base64-encoded string
    /// </summary>
    [XmlElement]
    [JsonPropertyName("BackFileContents")]
    public string? BackFileContents { get; set; }
}