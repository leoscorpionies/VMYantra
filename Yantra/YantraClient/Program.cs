/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 1/8/2018
 * Time: 6:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;

namespace YantraClient
{
	class Program
	{
		private static byte[] _buffer = new byte[1024];
		private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Connecting Client!");
			
			
			
			while(true){
				
				try
				{
				
					if(!_clientSocket.Connected)
					{
						ConnectClient();
					}
					
					if (_clientSocket.Connected)
					{
						Thread.Sleep(500);
						string serverMessage = Console.ReadLine();
						Console.WriteLine("Sending Message :: " + serverMessage);
						SendRequest(serverMessage);
						//Console.ReadLine();
					}
				}
				catch (SocketException)
					
				{ 
					Console.Clear();
					Console.WriteLine("Server not available");
				}
			
			}
			
			
	
		}
		
		private static void ConnectClient()
		{
			try
			{
				_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				_clientSocket.Connect(IPAddress.Loopback,100);
				
				
				 Console.WriteLine("Clinet Connected!" + _clientSocket.LocalEndPoint);
			}
			catch (Exception)
			{
				Console.WriteLine("server not avilable");
			}
			
		}
		
		private static void SendRequest(string request)
		{
		
			if(_clientSocket.Connected)
			{

		     	byte[] datareq = new byte[1024];
				datareq = Encoding.ASCII.GetBytes(request);
				_clientSocket.Send(datareq);
				  
				
				//Message received from server
				Thread.Sleep(500);
				int recevied= _clientSocket.Receive(_buffer);
				byte[] data = new byte[recevied];
				Array.Copy(_buffer,data, recevied);
			  
			 Console.WriteLine("Server Sent Data:" + Encoding.ASCII.GetString(data));
			}

			  			  
		 }
		
		
	}
}