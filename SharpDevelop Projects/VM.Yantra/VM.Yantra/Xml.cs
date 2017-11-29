/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 5:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml; 

namespace VM.Yantra.Xml
{
	/// <summary>
	/// Description of Class1.
	/// </summary>

		public static class XMLReader 
        {  
			public  enum YantraContentType
			{
				Undefined = 0,
				Command = 1,
				Data = 2,
				Message = 3
					
			}
			
            public static void WriteToXMLFile(string NodeIP, string stringData, YantraContentType contentType)
            {
                // Create a new file                  
    			string selectedAddress = NodeIP;
    			
    			string strIPAdddress ="";
    			if(NodeIP.IndexOf(":") > 0)
					 strIPAdddress = selectedAddress.Substring(0,selectedAddress.IndexOf(":"));
    			else
    				strIPAdddress = NodeIP;
				string strIP = string.Format(@"{0}",strIPAdddress);
                
				//latest block request ID is new block's reference ID.
				string lastBlockRequest = VM.Yantra.Common.GetBlockLatestTranscationRequestIDfromLedger(strIPAdddress );

				int ID = int.Parse(VM.Yantra.Common.GetBlockLatestTransactionRecordIDfromLedger(strIPAdddress)) + 1;
				string version = ID.ToString();
				
				string File_BlockServer_GUID_version = string.Format("{0}_{1}_{2}.xml",strIP,Guid.NewGuid() ,version);
                string File_BlockServer_GUID_version_Ref = lastBlockRequest;
                
                string filePath = "C:\\vm.yantra\\data\\" + File_BlockServer_GUID_version;
                
                Console.WriteLine(File_BlockServer_GUID_version);
                //Console.ReadLine();
                
                XmlTextWriter textWriter = new XmlTextWriter(filePath, null);  
                // Opens the document  
                textWriter.WriteStartDocument();  
                
                // Write comments  
                textWriter.WriteComment("Block Sample");  
                textWriter.WriteComment("Only for demo purpose");  
                
                // Write first element  
                textWriter.WriteStartElement("YANTRA.BLOCKCHAIN");  
                //textWriter.WriteStartElement("r", "RECORD", "urn:record");
 
                // Write first element  
                textWriter.WriteStartElement("BLOCK");  
                     
                 // Write next element  
                textWriter.WriteStartElement("STATE", "");  
                textWriter.WriteString("ACTIVE");  
                textWriter.WriteEndElement();
                    
                // Write next element  
                textWriter.WriteStartElement("TIMESTAMP", "");  
                textWriter.WriteString(System.DateTime.Now.ToString());  
                textWriter.WriteEndElement();
                
                // Write next element  
                textWriter.WriteStartElement("TRANSACTION_REQUEST", "");  
                textWriter.WriteString(File_BlockServer_GUID_version);  
                textWriter.WriteEndElement();  
                
                // Write one more element  wkflow based
                textWriter.WriteStartElement("STATUS", "");  
                textWriter.WriteString("VERFICATION PENDING");  
                textWriter.WriteEndElement();  
                
                 // Write one more element  
                textWriter.WriteStartElement("CERTIFICATE", "");  
                textWriter.WriteString("Publickey");  
                textWriter.WriteEndElement();
                
                 // Write one more element  
                textWriter.WriteStartElement("DATA", "");  
                textWriter.WriteString("<RECORD> <ACTION_UPDATE> <ATTRIBUTE Name='Price' value='24.60' Remarks=" + stringData + " /> </ACTION_UPDATE> </RECORD>");  
                textWriter.WriteEndElement();
                
                 // Write one more element  
                textWriter.WriteStartElement("CHECKSUM", "");  
                textWriter.WriteString("DEEREDCEETTSQERBXXWWRG");  
                textWriter.WriteEndElement();
                
                 // Write one more element  
                textWriter.WriteStartElement("TRANSACTION_REFERENCE", "");  
                textWriter.WriteString(File_BlockServer_GUID_version_Ref);  
                textWriter.WriteEndElement();
 
                textWriter.WriteEndElement();
                textWriter.WriteEndElement();
                
                // Ends the document.  
                textWriter.WriteEndDocument();  
                // close writer  
                textWriter.Close();  
                
                VM.Yantra.Common.AddtoLedger(strIPAdddress,version,File_BlockServer_GUID_version,File_BlockServer_GUID_version_Ref,"ACTIVE","PENDING");
            }  
            
            public static void ReadXMLString(string xmlString)
            {
            	string mystring = @"<ContentType Type=" + "Command" + "/>";
            	XmlDocument mydoc = new XmlDocument();
            	mydoc.LoadXml(mystring);
            	Console.WriteLine(mydoc.Attributes[0]);
            	
            }
        }
	
}
