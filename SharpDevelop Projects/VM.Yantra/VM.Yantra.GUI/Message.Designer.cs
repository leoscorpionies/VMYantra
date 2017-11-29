/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/10/2017
 * Time: 12:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VM.Yantra.GUI
{
	partial class Message
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblMessage;
		
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.Location = new System.Drawing.Point(17, 9);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(334, 48);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "Implementation under progress.";
			// 
			// Message
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 74);
			this.Controls.Add(this.lblMessage);
			this.MaximizeBox = false;
			this.Name = "Message";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Message";
			this.ResumeLayout(false);

		}
	}
}
