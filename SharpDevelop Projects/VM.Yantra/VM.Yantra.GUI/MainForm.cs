/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/8/2017
 * Time: 11:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Configuration;

namespace VM.Yantra.GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			lstNodes.Items.Clear();
			
			XmlDocument xmldoc = new XmlDocument();
			xmldoc.Load(@"C:\\vm.yantra\data\System\nodes.xml");
			
			XmlNodeList nodes = xmldoc.SelectNodes("/YANTRA.BLOCKCHAIN/Nodes/Node");
			foreach (XmlNode n in nodes)
			{
				XmlNode node = n;
				lstNodes.Items.Add(n.Attributes["IP"].Value + ":" + n.Attributes["Port"].Value);
			}
			
			lblSystemIP.Text = VM.Yantra.Common.GetIpAddress();
			
			
		}
		
		
		void SendTextToolStripMenuItemClick(object sender, EventArgs e)
		{
			Broadcast brd = new Broadcast();
			brd.ShowDialog(lstNodes);
		}
		void AboutYantraToolStripMenuItemClick(object sender, EventArgs e)
		{
			About abt = new About();
			abt.ShowDialog();
		}
		void BtnRemoveClick(object sender, EventArgs e)
		{
	
			lstNodes.Items.Remove(lstNodes.SelectedItem);
		}
		void BtnAddClick(object sender, EventArgs e)
		{
			lstNodes.Items.Add(txtIPAddress.Text);
		}
		void BtnNodeBackupClick(object sender, EventArgs e)
		{
			Message msg = new Message();
			msg.ShowDialog();
		}
		void BtnNetworkBackupClick(object sender, EventArgs e)
		{
			Message msg = new Message();
			msg.ShowDialog();
		}
		void NetworkStatusToolStripMenuItemClick(object sender, EventArgs e)
		{
			Message msg = new Message();
			msg.ShowDialog();
		}
		void NetworkLogToolStripMenuItemClick(object sender, EventArgs e)
		{
			Message msg = new Message();
			msg.ShowDialog();
		}
		void BtnStartClick(object sender, EventArgs e)
		{
	
			if(lstNodes.SelectedItem != null)
			{
				string selectedAddress = lstNodes.SelectedItem.ToString();
				
				if(!string.IsNullOrEmpty(selectedAddress))
				{
					//IPAddress selectedIPaddress =  IPAddress.Parse(selectedAddress);
					string strIPAdddress = selectedAddress.Substring(0,selectedAddress.IndexOf(":"));
					string strCmdText = string.Format(@"{0}",strIPAdddress);
		         				
					
					
					string filePath = ConfigurationSettings.AppSettings.Get("exePath");
					
					System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
					startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
					startInfo.FileName = filePath + "multicast.exe";
					startInfo.Arguments = strCmdText;
					
					System.Diagnostics.Process process = new System.Diagnostics.Process();
					process.StartInfo = startInfo;
					process.Start();
				}
			}
		}
		void LstNodesSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}
