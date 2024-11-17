using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ABCS.Test.Module.Communication.Helpers
{
    internal static class Helper
    {
        #region Методы
        public static string ToXml<T>(this T value)
        {
            XmlSerializerNamespaces ns = new();
            //ns.Add("", "");
            XmlSerializer x = new(typeof(T));
            using StringWriter xw = new();
            x.Serialize(xw, value, ns);
            return xw.ToString();
        }
        public static T ToInstance<T>(this string source)
        {
            return (T)source.ToInstance(typeof(T));
        }
        public static object ToInstance(this string source, Type sourceType)
        {
            XDocument doc = XDocument.Parse(source);
            MemoryStream stream = new();
            doc.Save(stream);
            stream.Position = 0;
            _ = stream.Seek(0, SeekOrigin.Begin);
            XmlSerializer x = new(sourceType);
            using XmlReader xr = XmlReader.Create(stream);
            return x.Deserialize(xr);
        }
        #endregion
    }
}
