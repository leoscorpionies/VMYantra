/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/11/2017
 * Time: 8:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace Test
{
	class Program
	{
		
		public  enum YantraContentType
		{
			Undefined = 0,
			Command = 1,
			Data = 2,
			Message = 3
				
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			string NodeIP = "127.0.0.1";
			
			string reference = VM.Yantra.Common.GetBlockLatestTransactionReferenceIDfromLedger(NodeIP);
			string request = VM.Yantra.Common.GetBlockLatestTranscationRequestIDfromLedger(NodeIP);
			string ID = VM.Yantra.Common.GetBlockLatestTransactionRecordIDfromLedger(NodeIP);
			
			VM.Yantra.Common.AddtoLedger( NodeIP, "8","wewewewewewE","2232323232332","ACTIVE","PENDING");
			
			Console.WriteLine(reference);
			Console.WriteLine(request);
				
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}