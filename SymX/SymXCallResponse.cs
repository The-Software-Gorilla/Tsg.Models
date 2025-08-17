using System.Text.Json.Serialization;

namespace Tsg.Models.SymX;

/// <summary>
/// SymX call response model.
/// </summary>
public class SymXCallResponse
{
    /// <summary>
    /// Status of the SymX call (e.g. "processed", "error").
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    
    /// <summary>
    /// HTTP status code returned by the SymX service.
    /// </summary>
    [JsonPropertyName("httpStatusCode")]
    public int HttpStatusCode { get; set; }
    
    /// <summary>
    /// Timestamp when the response was generated.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }
    
    /// <summary>
    /// Message providing additional information about the SymX call response.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    
    /// <summary>
    /// SymX call identifier for tracking the request.
    /// </summary>
    [JsonPropertyName("symxCallId")]
    public string? SymxCallId { get; set; }
    
    /// <summary>
    /// Correlation identifier for tracing the request across systems.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }
    
}