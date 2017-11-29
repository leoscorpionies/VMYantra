/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 5:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using VM.Yantra;

namespace TestMulticast
{
	class Program
	{
	
	  private static IPAddress mcastAddress;
  	  private static int mcastPort;
  	  
  	  private static IPAddress localAddress;
	  
		public static void Main(string[] args)
		{
		
			// TODO: Implement Functionality Here
			
			
			  // Initialize the multicast address group and multicast port.
		      // Both address and port are selected from the allowed sets as
		      // defined in the related RFC documents. These are the same 
		      // as the values used by the sender.0
		      mcastAddress = IPAddress.Parse( VM.Yantra.Common.GetIpAddress()); //  IPAddress.Parse("224.168.100.2");
		      mcastPort = 8080;
		      		      
		      try
		      {
		      	 string cmdIPAddress = args[0];
	     	 	 localAddress = IPAddress.Parse(args[0]);
		      }
		      catch (Exception e)
		      {
		      
		     	 localAddress = IPAddress.Parse("127.0.0.1");
		      }
		      	
		   
		      // Start a multicast group.
		      Multicast.StartMulticast(mcastAddress,mcastPort,localAddress);
		
		      // Display MulticastOption properties.
		      //Multicast.MulticastOptionProperties();
		
		      // Receive broadcast messages.
		      
		      Console.WriteLine("Message will be sent to ..." + localAddress);
  			  Multicast.ReceiveBroadcastMessages(mcastAddress,mcastPort,localAddress);

           
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);

		}
		
		
	}
}