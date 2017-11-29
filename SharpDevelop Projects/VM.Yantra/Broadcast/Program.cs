/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 5:23 PM
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


namespace TestBroadcast
{
	class Program
	{
		static IPAddress mcastAddress;
	    static int mcastPort;
	    
	    //ip address of reveiver or listner where message is sent;
	    private static IPAddress localAddress;
	    
	    
		public static void Main(string[] args)
		{
			 Console.WriteLine("Hello Welcome!");
			
				
			  // Initialize the multicast address group and multicast port.
		      // Both address and port are selected from the allowed sets as
		      // defined in the related RFC documents. These are the same 
		      // as the values used by the sender.
		      mcastAddress = IPAddress.Parse("224.168.100.2");
		      mcastPort = 8080;
		      
		    	      
		      localAddress = IPAddress.Parse("127.0.0.1");
		    
		
		      // Join the listener multicast group.
		     // Broadcast.JoinMulticastGroup(localAddress,mcastAddress,mcastPort );
		
		      // Broadcast the message to the listener.
		      Broadcast.BroadcastMessage(mcastAddress,mcastPort, "Hello multicast listener");
		      
		      Console.Write("Press any key to continue . . . ");
     		  Console.ReadKey(true);

		}
	}
}