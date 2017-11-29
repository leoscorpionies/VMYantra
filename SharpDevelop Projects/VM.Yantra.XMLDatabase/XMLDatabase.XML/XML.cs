/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 9:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;

namespace VM.Yantra.XMLDatabase
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class XML
	{
		
		private XmlDocument _xmlDoc = new XmlDocument();
		private string _filePath;
		
		private  XML()
		{
			_filePath ="http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml";
			_xmlDoc.Load(_filePath);
			
		}
		
		private  XML(string filePath)
		{
			_xmlDoc.Load(filePath);
		}		
		
		public string GetXMLFileContent()
		{
			XmlReader xmlReader = XmlReader.Create(_filePath);
			return xmlReader.ReadContentAsString();
		}
		
		public List<string> GetAttributesListbyXMLStringNode(string xmlStringNode)
		{
			XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlStringNode);
            
            List<string> mylist = new List<string>();
            
            foreach(XmlNode xmlNode in xmlDoc.DocumentElement.Attributes)
            	mylist.Add(xmlNode.Value + ": " + xmlNode.Value);

            return mylist;
               
		}		
		
		public void LoadXML(string content)
		{
			 _xmlDoc.LoadXml("<test>InnerText is here</test>");
		}
		
		public XmlNode SelectSingleNode(string xQuery)
		{
          //XmlNode node = _xmlDoc.SelectSingleNode("//rss/channel/title");
			XmlNode node = _xmlDoc.SelectSingleNode(xQuery);

			return node;
        }
		
		public XmlNodeList SelectNodes(string xQuery)
		{
            
            XmlNodeList itemNodes = _xmlDoc.SelectNodes(xQuery);
            
            return itemNodes;
        }
		
		public void XmlWriteNodeToFile(string filePath, XmlNode node)
		{
            XmlWriter xmlWriter = XmlWriter.Create(filePath);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement(node.Name);

            xmlWriter.WriteStartElement(node.Name);
            foreach (int item in node.Attributes) 
            {
        		 xmlWriter.WriteAttributeString(node.Attributes[item].Name, node.Attributes[item].Value);
        	}
            xmlWriter.WriteString(node.InnerText);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
         }
		
		public void XmlAppendNodeToFile(string filePath, string xQuery, XmlNode node)
		{
        
            XmlNode rootNode = _xmlDoc.SelectSingleNode(xQuery);
            _xmlDoc.AppendChild(node);
            _xmlDoc.Save(filePath);
		}
		
		public void XmlAppendAttributeToNode(XmlAttribute attribute, string xQuery)
		{
           
            XmlNode rootNode = _xmlDoc.SelectSingleNode(xQuery);           
    		rootNode.Attributes.Append(attribute);
		}
		
		public void XmlUpdateAttributeforNode(XmlAttribute attribute, string xQuery)
		{
            XmlNode userNode = _xmlDoc.SelectSingleNode(xQuery);
            
            foreach (XmlNode item in userNode.Attributes)
            {
            	if (item.Name == attribute.Name)
            		item.ParentNode.ReplaceChild(attribute,item);
            }
		}
		
	
		                       
	}
}


//<?xml version = "1.0"?>
//<contact-info>
//   <contact1>
//      <name>Tanmay Patil</name>
//      <company>TutorialsPoint</company>
//      <phone>(011) 123-4567</phone>
//   </contact1>
//	
//   <contact2>
//      <name>Manisha Patil</name>
//      <company>TutorialsPoint</company>
//      <phone>(011) 789-4567</phone>
//   </contact2>
//</contact-info>