/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 8/20/2017
 * Time: 7:00 AM
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
	/// Description of Multicast.
	/// </summary>
	public static class Multicast
	{
			
		    private static Socket mcastSocket;
		    private static MulticastOption mcastOption;

		    public static void StartMulticast(IPAddress mcastAddress,int mcastPort, IPAddress localIPAddr) 
		    {
		
		      try 
		      {
		        mcastSocket = new Socket(AddressFamily.InterNetwork,
		                                 SocketType.Dgram, 
		                                 ProtocolType.Udp);
		
			        //IPAddress localIP = IPAddress.Any;
		        EndPoint localEP = (EndPoint)new IPEndPoint(localIPAddr, mcastPort);
		
		        mcastSocket.Bind(localEP);
		
		
		        // Define a MulticastOption object specifying the multicast group 
		        // address and the local IPAddress.
		        // The multicast group address is the same as the address used by the server.
		        mcastOption = new MulticastOption(mcastAddress, localIPAddr);
		
		        mcastSocket.SetSocketOption(SocketOptionLevel.IP, 
		                                    SocketOptionName.AddMembership, 
		                                    mcastOption);
		
		      } 
		      catch (Exception e) 
		      {
		        Console.WriteLine(e.ToString());
		      }
		      
		      
		      		
		      Console.WriteLine("Connected to...." + localIPAddr.ToString());
		    }
		    
		    
		    public static void ReceiveBroadcastMessages(IPAddress mcastAddress,int mcastPort,IPAddress localIPAddr ) 
		    {
		      bool done = false;
		      byte[] bytes = new Byte[100];
		      IPEndPoint groupEP = new IPEndPoint(mcastAddress, mcastPort);
		      EndPoint remoteEP = (EndPoint) new IPEndPoint(IPAddress.Any,0);
		
		
		      try 
		      {      
		        while (!done) 
		        {
		          Console.WriteLine("Connected to...." + localIPAddr.ToString());
		          Console.WriteLine("Waiting for multicast packets.......");
		          Console.WriteLine("Enter ^C to terminate.");
		        	          
		
		          mcastSocket.ReceiveFrom(bytes, ref remoteEP);
		          
		          string messageReceived =  Encoding.ASCII.GetString(bytes,0,bytes.Length);
		          
   		          Console.WriteLine("Received broadcast from {0} :\n {1}\n",
		            groupEP.ToString(),
		            Encoding.ASCII.GetString(bytes,0,bytes.Length));
		       
		          
		          
		          
		          VM.Yantra.Xml.XMLReader.WriteToXMLFile(localIPAddr.ToString(), messageReceived,Xml.XMLReader.YantraContentType.Data );
		
		        }
		
		        mcastSocket.Close();
		      } 
		
		      catch (Exception e) 
		      {
		        Console.WriteLine(e.ToString());
		      }
		    }
		    
		    
		    private static void MulticastOptionProperties()
		    {
		     // Console.WriteLine("Current multicast group is: " + mcastOption.Group);
		     // Console.WriteLine("Current multicast local address is: " + mcastOption.LocalAddress);
		    }



	}
}
