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
 
namespace VM.Yantra.GUI
{
	partial class Broadcast
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnBroadcast;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBroadcast = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBroadcast
			// 
			this.btnBroadcast.Location = new System.Drawing.Point(53, 274);
			this.btnBroadcast.Margin = new System.Windows.Forms.Padding(4);
			this.btnBroadcast.Name = "btnBroadcast";
			this.btnBroadcast.Size = new System.Drawing.Size(185, 28);
			this.btnBroadcast.TabIndex = 13;
			this.btnBroadcast.Text = "Broadcast";
			this.btnBroadcast.UseVisualStyleBackColor = true;
			this.btnBroadcast.Click += new System.EventHandler(this.BtnBroadcastClick);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(16, 43);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(263, 223);
			this.txtMessage.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(235, 28);
			this.label2.TabIndex = 14;
			this.label2.Text = "Enter Text to Broadcast";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Broadcast
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(296, 321);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBroadcast);
			this.Controls.Add(this.txtMessage);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Broadcast";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Broadcast";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
