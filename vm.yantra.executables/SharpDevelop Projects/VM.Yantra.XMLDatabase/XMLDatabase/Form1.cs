/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/18/2017
 * Time: 10:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace XMLDatabase
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TabPage1DragDrop(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
			webBrowser1.Navigate(@"C:\VB Documents\General\htmlsample.html");
	
		}
		void ListView1DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}
		void ListView1ItemDrag(object sender, ItemDragEventArgs e)
		{
		
		}
	
		
	
		
	
	
		
	
	}
}
