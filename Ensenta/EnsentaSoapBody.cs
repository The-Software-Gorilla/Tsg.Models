using System.Xml.Serialization;

namespace Tsg.Models.Ensenta;

/// <summary>
/// Ensenta SOAP body containing the DoDepositTransaction element
/// </summary>
public class EnsentaSoapBody
{
    /// <summary>
    /// DoDepositTransaction element for the SOAP body
    /// </summary>
    [XmlElement(ElementName = "DoDepositTransaction", Namespace = "http://ensenta.com/ECWebDepositHostRequest")]
    public DoDepositTransaction? DoDepositTransaction { get; set; }
}