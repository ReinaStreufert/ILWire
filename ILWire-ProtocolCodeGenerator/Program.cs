using AssemblyGen.Serialization;
using System.Xml;

var builder = new SerializationAssemblyBuilder();
builder.IncludeDefaultElementTypes();
var xmlDocument = new XmlDocument();
xmlDocument.Load("packets.xml");
var persistedAssembly = builder.BuildFromXml(xmlDocument);
persistedAssembly.Save("packetSerializers.dll");