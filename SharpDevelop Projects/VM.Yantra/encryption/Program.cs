/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/8/2017
 * Time: 8:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Generic;

namespace encryption
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here	
			
			string content = "I am going to encrypt this content for testing purpose. I am also going to generate public and private keys";
			string encrypted = VM.Yantra.Encryption.encrypt(content,"vijayabhasker@india.com");
			Console.WriteLine(encrypted);
			
			string decrypted = VM.Yantra.Encryption.decrypt(encrypted,"vijayabhasker@india.com");
			Console.WriteLine(decrypted);
			
			
			string PublicKey = VM.Yantra.Encryption.GeneratePublicKey("vijayabhasker@india.com");
			Console.WriteLine("Given Public Key is  " + PublicKey);
			
			Console.WriteLine(" ");
			string y = VM.Yantra.Encryption.DecryptPublicKey(PublicKey);
			Console.WriteLine("given private key is "+ y);
			Console.ReadKey(true);			
#region asymeetric	
			
//			//hexa crypted
//			privateKey = Convert.ToBase64String(Encoding.Unicode.GetBytes("vijayabhasker@india.com"));
//			Console.WriteLine(privateKey);			
//			
//			string privateKeyHash = Convert.ToBase64String(Encoding.Unicode.GetBytes(privateKey.GetHashCode().ToString()));
//			Console.WriteLine(privateKeyHash);
//			
//			string publickey = privateKey + "$@^!&@" + privateKeyHash;
//			Console.WriteLine(publickey);
//			
//			Console.WriteLine(Encoding.Unicode.GetString( Convert.FromBase64String(privateKey)));
//			
//		    encrypted = encrypt(publickey,"vijayabhasker@india.com");
//			Console.WriteLine(Convert.ToBase64String(Encoding.Unicode.GetBytes(encrypted)));
//			
//			decrytped = decrypt( encrypted,"vijayabhasker@india.com");
//			Console.WriteLine(decrytped);
//			
//			Console.WriteLine(decrytped.Contains(privateKey));
//			
//			//hexa deccrypted
//			Console.WriteLine(Encoding.Unicode.GetString(Convert.FromBase64String(privateKey)));
#endregion
			
		}
		
		public static string encrypt(string content, string passwordKey)
		{
			char[] contentArray = content.ToCharArray();
			char[] contentArrayOutput = content.ToCharArray();
			int count = 0;
			
			foreach (char element in contentArray) {
				contentArrayOutput[count++] = Convert.ToChar(Convert.ToInt64(element) << (passwordKey.Length/8));
			}
			
		    return string.Concat(contentArrayOutput);
		
		}
		
		public static string decrypt(string content, string passwordKey)
		{
			char[] contentArray = content.ToCharArray();
			char[] contentArrayOutput = content.ToCharArray();
			int count = 0;
			
	        count = 0;
			foreach (char element in contentArray) {
				contentArrayOutput[count++] = Convert.ToChar(Convert.ToInt64(element) >> (passwordKey.Length/8));
			}
		    
		    return string.Concat(contentArrayOutput);
		
		}
		
		public static bool GetAllIPAdderess()
		{
			foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
			{

				foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
			    {
			        if(!ip.IsDnsEligible)
			        {
			            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
			            {
			                // All IP Address in the LAN
			                Console.WriteLine(ip.Address + "  " + ip.IsDnsEligible + "  " + ip.PrefixOrigin + "  " + ni.Name);
			                //string machineName = GetMachineNameFromIPAddress(ip.Address.ToString());
			                //Console.WriteLine("Computer name is {0}",machineName);
			            }
			        }
				}
			}
					
   			return true;
		}	

	 	private static string GetMachineNameFromIPAddress(string ipAdress)
        {
            string machineName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);

                machineName = hostEntry.HostName;
            }
            catch(Exception ex)
            {
            	//throw new Exception(ex.ToString());
            }
            return machineName;
     	 }
		
		
	}
}