/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 6:07 PM
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

namespace NodeInstances
{
	class Program
	{
		public static void Main(string[] args)
		{
				// TODO: Implement Functionality Here
			
			// TODO: Implement Functionality Here
			Dictionary<string, string> d =new Dictionary<string, string>();
            d.Add("127.0.0.1","9090");
            d.Add("127.0.0.2","9090");
            
            // Store keys in a List.
            List<string> list = new List<string>(d.Keys);
            
            // Loop through list.
            foreach (string k in list)
            {
                
            	Console.WriteLine("{0} {1}", k, d[k]);
            	
            	string strCmdText = string.Format(@"{0}",k);
				//System.Diagnostics.Process.Start("CMD.exe",strCmdText);
         
				
				System.Diagnostics.Process process = new System.Diagnostics.Process();
				System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
				string filePath = System.Configuration.ConfigurationSettings.AppSettings.Get("exePath");
			    startInfo.FileName = filePath + "multicast.exe";
				startInfo.Arguments = strCmdText;
				process.StartInfo = startInfo;
				process.Start();
			  }
			
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}