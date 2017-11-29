/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 8/20/2017
 * Time: 7:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;  

namespace VM.Yantra
{
	/// <summary>
	/// Description of Broadcast.
	/// </summary>
	public static class Broadcast
	{

	    static Socket mcastSocket;

		
		public static void JoinMulticastGroup(IPAddress localIPAddress, IPAddress mcastAddress,int mcastPort)
	    {
	       try 
		      {
		        mcastSocket = new Socket(AddressFamily.InterNetwork,
		                                 SocketType.Dgram, 
		                                 ProtocolType.Udp);
		
			        //IPAddress localIP = IPAddress.Any;
		        EndPoint localEP = (EndPoint)new IPEndPoint(localIPAddress, mcastPort);
		
		        mcastSocket.Bind(localEP);
		
		
		        // Define a MulticastOption object specifying the multicast group 
		        // address and the local IPAddress.
		        // The multicast group address is the same as the address used by the server.
		       		
		        mcastSocket.SetSocketOption(SocketOptionLevel.IP, 
		                                    SocketOptionName.AddMembership, 
		                                    new MulticastOption(mcastAddress, localIPAddress));
		
		      } 
		
		      catch (Exception e) 
		      {
		        Console.WriteLine(e.ToString());
		      }
	    }

	    public static void BroadcastMessage(IPAddress mcastAddress, int mcastPort, string message)
	    {
	      IPEndPoint endPoint;
	
	      try
	      {
	          mcastSocket = new Socket(AddressFamily.InterNetwork,
		                                 SocketType.Dgram, 
		                                 ProtocolType.Udp);
		
	      	
	      	//Send multicast packets to the listener.
	        endPoint = new IPEndPoint(mcastAddress,mcastPort);
	        mcastSocket.SendTo(Encoding.ASCII.GetBytes(message), endPoint);			
	        Console.WriteLine("Multicast data sent.....");
	      }
	      catch (Exception e)
	      {
	        Console.WriteLine("\n" + e.ToString());
	      }
	
	      mcastSocket.Close();
	    }

		
	}
}
