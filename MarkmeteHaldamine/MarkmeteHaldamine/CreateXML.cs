﻿using System.Xml;

namespace MarkmeteHaldamine
{
    class CreateXML
    {
        public void create()
        {
            XmlWriter xmlWriter = XmlWriter.Create("markmed.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Markmed");
            xmlWriter.WriteStartElement("Märkus");
            xmlWriter.WriteAttributeString("pealkiri", "Tere");
            xmlWriter.WriteAttributeString("tekst", "See on minu, Gert-Andry Kääramehe, märkmehaldus programm");
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
        }
    }
}
