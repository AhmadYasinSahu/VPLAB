using System;
using System.Xml;

class Program
{
    static void Main()
    {
        // XML Writer: Create the XML file
        CreateXML();

        // XML Reader: Read and display the XML file
        ReadXML();
    }

    static void CreateXML()
    {
        XmlWriterSettings settings = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "\t"
        };

        using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
        {
            writer.WriteStartDocument(); // Start document
            writer.WriteStartElement("GPS_Log"); // Root element

            // Write Position element
            writer.WriteStartElement("Position");
            writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
            writer.WriteElementString("x", "65.8973342");
            writer.WriteElementString("y", "72.3452346");

            // Write SatteliteInfo sub-element
            writer.WriteStartElement("SatteliteInfo");
            writer.WriteElementString("Speed", "40");
            writer.WriteElementString("NoSatt", "7");
            writer.WriteEndElement(); // End SatteliteInfo

            writer.WriteEndElement(); // End Position

            // Write Image element
            writer.WriteStartElement("Image");
            writer.WriteAttributeString("Resolution", "1024x800");
            writer.WriteElementString("Path", @"\images\1.jpg");
            writer.WriteEndElement(); // End Image

            writer.WriteEndElement(); // End GPS_Log
            writer.WriteEndDocument(); // End document
        }

        Console.WriteLine("XML file 'GPS.xml' created successfully.");
    }

    static void ReadXML()
    {
        Console.WriteLine("\nReading XML file:");

        using (XmlReader reader = XmlReader.Create("GPS.xml"))
        {
            while (reader.Read())
            {
                // Display XML nodes
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.Write($"<{reader.Name}>");

                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.Write($" {reader.Name}=\"{reader.Value}\"");
                        }
                    }

                    Console.WriteLine();
                }

                if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(reader.Value);
                }

                if (reader.NodeType == XmlNodeType.EndElement)
                {
                    Console.WriteLine($"</{reader.Name}>");
                }
            }
        }
    }
}
