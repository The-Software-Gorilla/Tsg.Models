using System.Text.Json.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// SymX Call request.
/// This class represents the structure of a request to invoke a SymX PowerOn script via the SymX web service.
/// </summary>
public class SymXCall
{
    /// <summary>
    /// SymX Call identifier. This is a unique identifier for the SymX call request.
    /// </summary>
    [JsonPropertyName("symXCallId")]
    public string? SymXCallId { get; set; }
    
    /// <summary>
    /// Correlation identifier. This is used to enable the original caller to correlate the
    /// original request that triggered this SymX call.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }
    
    /// <summary>
    /// Callback queue name. This is the name of the queue to which the SymX call response
    /// should be sent once the SymX PowerOn script execution is complete.
    /// </summary>
    [JsonPropertyName("callbackQueue")]
    public string? CallbackQueue { get; set; }
    
    /// <summary>
    /// SymX instance URL. This is the URL of the SymX instance where the PowerOn script
    /// is hosted and to which the call request should be sent.
    /// </summary>
    [JsonPropertyName("symXInstanceUrl")]
    public string? SymXInstanceUrl { get; set; }
    
    /// <summary>
    /// SymX PowerOn script name. This is the name of the PowerOn script to be executed
    /// on the SymX instance.
    /// </summary>
    [JsonPropertyName("symXPowerOn")]
    public string? SymXPowerOn { get; set; }
    
    /// <summary>
    /// SymX SOAP envelope. This property contains the SOAP envelope that encapsulates
    /// the parameters and data required for the SymX PowerOn script execution. It is in
    /// JSON format and maps to the SymXSoapEnvelope class.
    /// </summary>
    [JsonPropertyName("symXEnvelope")]
    public SymXSoapEnvelope? SymXEnvelope { get; set; }
}