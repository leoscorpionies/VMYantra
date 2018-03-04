/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 1/8/2018
 * Time: 5:15 PM
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


namespace Yantra
{
	class Program
	{
		
		private static byte[] _buffer = new byte[1024];
		private static List<Socket> _clientSockets = new List<Socket>();
		private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Initilizing Server!");
			
			while(true)
			{
				InitilizeServer();
				//Console.ReadLine();
			}
		}
		
		private static void InitilizeServer()
		{
			//Console.WriteLine("Initilizing Server!");
					
				try
				{
					//_serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					_serverSocket.Bind(new IPEndPoint(IPAddress.Any,100));
					_serverSocket.Listen(1);
								
					_serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), _serverSocket);
				}
				catch (Exception)
				{
					//Console.WriteLine("Socket Execption");
				}
			
		}
		
		private static void AcceptCallback(IAsyncResult AR)
		{
			
			
			Socket socket = _serverSocket.EndAccept(AR);
		
			if(socket.Connected)
			{
				try
				{
					
					//Console.WriteLine(socket.LocalEndPoint);
					_clientSockets.Add(socket);
				
				
					socket.BeginReceive(_buffer,0,_buffer.Length,SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
							
					_serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), _serverSocket);
					Console.Clear();
					Console.WriteLine("Connected to client:"+ _clientSockets.Count);
					
				}
				
				catch (SocketException ex)
				{
					_clientSockets.Remove(socket);
				}
			}
								
		
		}
		
		private static void ReceiveCallback(IAsyncResult AR)
		{
			Socket socket = null;
			
			try
			{
			
				socket = (Socket)AR.AsyncState;
			
					
				if(socket.Connected)
				{
					int recevied = socket.EndReceive(AR);
					byte[] data = new byte[recevied];
					Array.Copy(_buffer,data,recevied);
					string text = Encoding.ASCII.GetString(data);
					
					Console.WriteLine("Text recevied:" + text);
					Console.WriteLine("Sending Data:" + text.ToUpper());
							
					byte[] sendData = Encoding.ASCII.GetBytes(text.ToUpper());
					socket.BeginSend(sendData,0,sendData.Length,SocketFlags.None, new AsyncCallback(SendCallback), socket);
					
					
					socket.BeginReceive(_buffer,0,_buffer.Length,SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
				}
			}
			catch (Exception)
			{
				_clientSockets.Remove(socket);
				Console.Clear();
				Console.WriteLine("Connected to client:"+ _clientSockets.Count);
			}
		}
		
		private static void SendCallback(IAsyncResult AR)
		{
			Socket socket = (Socket)AR.AsyncState;
			int recevied = socket.EndReceive(AR);
				
		}
		
		private static void BroadCast(string message)
		{
			
			byte[] sendData = Encoding.ASCII.GetBytes(message);
			foreach(Socket soc in _clientSockets)
			{
			  soc.BeginSend(sendData,0,sendData.Length,SocketFlags.None, new AsyncCallback(SendCallback), soc);
			}
		}
	}
}