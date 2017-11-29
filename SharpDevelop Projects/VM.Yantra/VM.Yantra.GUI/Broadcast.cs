/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/9/2017
 * Time: 11:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using VM.Yantra;
using System.Net;

namespace VM.Yantra.GUI
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Broadcast : Form
	{
		public Broadcast()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnBroadcastClick(object sender, EventArgs e)
		{
			IPAddress mcastAddress, localAddress;
		    int mcastPort;
	    
			  mcastAddress = IPAddress.Parse( VM.Yantra.Common.GetIpAddress());
		      mcastPort = 8080;
		     
		      //ListViewItem refObj = (ListViewItem)sender;
		             
		      //localAddress = IPAddress.Parse(refObj.Text);
	
		      // Broadcast the message to the listener.
		      VM.Yantra.Broadcast.BroadcastMessage(mcastAddress, mcastPort, txtMessage.Text);
		      MessageBox.Show("Brodacast Done!!!");
	

		}
		
		
	}
}
