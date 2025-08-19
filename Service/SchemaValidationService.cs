using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Tsg.Models.Service;

public static class SchemaValidationService
{
    public static void ValidateObject<T>(T obj, XmlSchemaSet schemaSet)
    {
        var serializer = new XmlSerializer(typeof(T));
        var settings = new XmlWriterSettings { Indent = true };
        var xml = string.Empty;

        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, settings))
        {
            serializer.Serialize(xmlWriter, obj);
            xml = stringWriter.ToString();
        }

        var xmlReaderSettings = new XmlReaderSettings
        {
            ValidationType = ValidationType.Schema,
            Schemas = schemaSet
        };

        xmlReaderSettings.ValidationEventHandler += (sender, args) =>
        {
            if (args.Severity == XmlSeverityType.Error)
            {
                throw new XmlSchemaValidationException($"Validation error: {args.Message}");
            }
        };

        using (var stringReader = new StringReader(xml))
        using (var xmlReader = XmlReader.Create(stringReader, xmlReaderSettings))
        {
            while (xmlReader.Read()) 
            { 
                // Read through the XML to trigger validation
            }
        }

        Console.WriteLine("Validation successful.");
    }
    
}