/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/10/2017
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Net;
using System.Configuration;
namespace  VM.Yantra
{
	/// <summary>
	/// Description of Common.
	/// </summary>
	public static class Common
	{
		public static string GetIpAddress()  // Get IP Address
	    {
//	        string ip = "";     
//	        IPHostEntry ipEntry = Dns.GetHostEntry("");
//	        IPAddress[] addr = ipEntry.AddressList;
//	        ip = addr[2].ToString();
//	        return ip;
	        
	        return "224.168.100.2";
	    }
		
		public static string GetBlockLatestTranscationRequestIDfromLedger(string nodeID)
		{
			
			XmlDocument xmldoc = new XmlDocument();
			
			string ledgerFilePath = string.Format(ConfigurationSettings.AppSettings.Get("Ledger"),nodeID);
			
			if(!File.Exists(ledgerFilePath))
			{
			
						
				//var fs = File.Open(ledgerFilePath,FileMode.OpenOrCreate);
				//fs.Close();
				//File.WriteAllText(ledgerFilePath,@"<?xml version=""1.0"" encoding=""UTF-8""?>");
				//File.WriteAllText(ledgerFilePath,@"<?xml-stylesheet type=""text/xsl"" href=""Yantra.xsl""?>");
				File.WriteAllText(ledgerFilePath,@"<?xml version=""1.0"" encoding=""UTF-8""?> <?xml-stylesheet type=""text/xsl"" href=""Yantra.xsl""?> <YANTRA.BLOCKCHAIN>  <LEDGER> <RECORD> <ID></ID> <REQUEST>   </REQUEST> 
     												 <REFERENCE> </REFERENCE> </RECORD> </LEDGER> </YANTRA.BLOCKCHAIN>");
			}
			
				
			//@"C:\\vm.yantra\data\System\Yantra.Ledger.xml");
			xmldoc.Load(ledgerFilePath);
			
			XmlNodeList nodelist = xmldoc.SelectNodes("/YANTRA.BLOCKCHAIN/LEDGER/RECORD");
			string transReq = nodelist[nodelist.Count-1].SelectSingleNode("REQUEST").InnerText;
			transReq = transReq.Replace("\r","").Replace("\n","");
			return transReq;
	
		}
		
		public static string GetBlockLatestTransactionReferenceIDfromLedger(string nodeID)
		{
			
			XmlDocument xmldoc = new XmlDocument();
			
			string ledgerFilePath = string.Format(ConfigurationSettings.AppSettings.Get("Ledger"),nodeID);
			
			if(!File.Exists(ledgerFilePath))
			{
			
				File.WriteAllText(ledgerFilePath,@"<?xml version=""1.0"" encoding=""UTF-8""?> <?xml-stylesheet type=""text/xsl"" href=""Yantra.xsl""?> <YANTRA.BLOCKCHAIN>  <LEDGER> <RECORD> <ID></ID> <REQUEST>   </REQUEST> 
     												 <REFERENCE> </REFERENCE> </RECORD> </LEDGER> </YANTRA.BLOCKCHAIN>");
			}
			
			
			//@"C:\\vm.yantra\data\System\Yantra.Ledger.xml");
			xmldoc.Load(ledgerFilePath);
			
			XmlNodeList nodelist = xmldoc.SelectNodes("/YANTRA.BLOCKCHAIN/LEDGER/RECORD");
			string transRef = nodelist[nodelist.Count-1].SelectSingleNode("REFERENCE").InnerText;
			transRef = transRef.Replace("\r","").Replace("\n","");
			return transRef;
	
		}
		
		public static string GetBlockLatestTransactionRecordIDfromLedger(string nodeID)
		{
			
			XmlDocument xmldoc = new XmlDocument();
			
			string ledgerFilePath = string.Format(ConfigurationSettings.AppSettings.Get("Ledger"),nodeID);
			
			if(!File.Exists(ledgerFilePath))
			{
			
				File.WriteAllText(ledgerFilePath,@"<?xml version=""1.0"" encoding=""UTF-8""?> <?xml-stylesheet type=""text/xsl"" href=""Yantra.xsl""?> <YANTRA.BLOCKCHAIN>  <LEDGER> <RECORD> <ID></ID> <REQUEST>   </REQUEST> 
     												 <REFERENCE> </REFERENCE> </RECORD> </LEDGER> </YANTRA.BLOCKCHAIN>");
			}
			
			
			//@"C:\\vm.yantra\data\System\Yantra.Ledger.xml");
			xmldoc.Load(ledgerFilePath);
			
			XmlNodeList nodelist = xmldoc.SelectNodes("/YANTRA.BLOCKCHAIN/LEDGER/RECORD");
			string ID = nodelist[nodelist.Count-1].SelectSingleNode("ID").InnerText;
			ID = ID.Replace("\r","").Replace("\n","");
			ID=string.IsNullOrEmpty(ID)?"0" :ID;
			return ID;
	
		}
		
		public static void AddtoLedger(string nodeID, string ID, string requestID, string referenceID, string blockState, string workflowStatus)
		{
			
			XmlDocument xmldoc = new XmlDocument();
			
			//@"C:\\vm.yantra\data\System\Yantra.Ledger.xml");
			
			string ledgerFilePath = string.Format(ConfigurationSettings.AppSettings.Get("Ledger"),nodeID);
			
			if(!File.Exists(ledgerFilePath))
			{
			File.WriteAllText(ledgerFilePath,@"<?xml version=""1.0"" encoding=""UTF-8""?> <?xml-stylesheet type=""text/xsl"" href=""Yantra.xsl""?> <YANTRA.BLOCKCHAIN>  <LEDGER> <RECORD> <ID></ID> <REQUEST>   </REQUEST> 
     												 <REFERENCE> </REFERENCE> </RECORD> </LEDGER> </YANTRA.BLOCKCHAIN>");
			}
			
			xmldoc.Load(ledgerFilePath);
			XmlNode lastNode = xmldoc.SelectSingleNode("/YANTRA.BLOCKCHAIN/LEDGER");
	
			XmlNode newChild = xmldoc.CreateNode(XmlNodeType.Element,"","RECORD","");
			
			newChild.InnerXml = 
				string.Format
				("<ID> {0} </ID> <REQUEST> {1} </REQUEST> <REFERENCE> {2} </REFERENCE> <STATE> {3} </STATE> <STATUS> {4} </STATUS>",
			              ID,requestID,referenceID,blockState,workflowStatus);			
			
			lastNode.AppendChild(newChild);
			xmldoc.Save(ledgerFilePath);
	
		}
		
		
		
	}
}
