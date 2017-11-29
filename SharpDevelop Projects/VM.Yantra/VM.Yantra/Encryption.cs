/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/12/2017
 * Time: 8:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Generic;

namespace VM.Yantra
{
	/// <summary>
	/// Description of Encryption.
	/// </summary>
	public class Encryption
	{
		public Encryption()
		{
		}
		

		private const string email = "vijayabhasker@india.Com";
		
		public static string encrypt(string content, string passwordKey)
		{
			char[] contentArray = content.ToCharArray();
			char[] contentArrayOutput = content.ToCharArray();
			int count = 0;
			
			foreach (char element in contentArray) {
				contentArrayOutput[count++] = Convert.ToChar(Convert.ToInt64(element) << (passwordKey.Length/8));
			}
			
		    string encryptedData= string.Concat(contentArrayOutput);
		    
		   return  Convert.ToBase64String(Encoding.Unicode.GetBytes(encryptedData));
		
		}
		public static string decrypt(string content, string passwordKey)
		{
			string encryptedData = Encoding.Unicode.GetString(Convert.FromBase64String(content));
			
			char[] contentArray = encryptedData.ToCharArray();
			char[] contentArrayOutput = encryptedData.ToCharArray();
			int count = 0;
			
	        count = 0;
			foreach (char element in contentArray) {
				contentArrayOutput[count++] = Convert.ToChar(Convert.ToInt64(element) >> (passwordKey.Length/8));
			}
		    
	        string decrypted = string.Concat(contentArrayOutput);
		
	        return decrypted;
		}
		
		/// <summary>
		/// Digital Signature
		/// </summary>
		/// <param name="privateKey"></param>
		/// <returns></returns>
		public static string GeneratePublicKey(string privateKey)
		{
			
		
			string strPrivateKey = Convert.ToBase64String(Encoding.Unicode.GetBytes(privateKey));
//			Console.WriteLine(privateKey);			
			
			string strPrivateKeyHash = Convert.ToBase64String(Encoding.Unicode.GetBytes(strPrivateKey.GetHashCode().ToString()));
//			Console.WriteLine(strPrivateKeyHash);
			
			string strPublickey = strPrivateKey + "$@^!&@" + strPrivateKeyHash;
//			Console.WriteLine(strPublickey);
			
			string encrypted = encrypt(strPublickey,"Yantra");
									
			return encrypted;
		}		
		public static string DecryptPublicKey(string publicKey)
		{
		
			//email address is privatekey;
			string decrytped = decrypt( publicKey,"Yantra");
			
//			Console.WriteLine(decrytped);
			
			decrytped = decrytped.Substring(0,decrytped.IndexOf("$@^!&@"));
					
			//hexa deccrypted
//			Console.WriteLine(Encoding.Unicode.GetString(Convert.FromBase64String(decrytped)));
			string key = Encoding.Unicode.GetString(Convert.FromBase64String(decrytped));
			
			return key;
		}
		
		
	}
		
}
