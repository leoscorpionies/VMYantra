/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/8/2017
 * Time: 11:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VM.Yantra.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox lstNodes;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtIPAddress;
		private System.Windows.Forms.Label lblSystemIP;
		private System.Windows.Forms.Button btnNodeBackup;
		private System.Windows.Forms.Button btnNetworkBackup;
		private System.Windows.Forms.PictureBox picYantra;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem nodesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem networkStatusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutYantraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem networkLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sendTextToolStripMenuItem;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblList;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lstNodes = new System.Windows.Forms.ListBox();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtIPAddress = new System.Windows.Forms.TextBox();
			this.lblSystemIP = new System.Windows.Forms.Label();
			this.btnNodeBackup = new System.Windows.Forms.Button();
			this.btnNetworkBackup = new System.Windows.Forms.Button();
			this.picYantra = new System.Windows.Forms.PictureBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.nodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.networkStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.networkLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sendTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutYantraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblList = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picYantra)).BeginInit();
			this.menuStripMain.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstNodes
			// 
			this.lstNodes.FormattingEnabled = true;
			this.lstNodes.ItemHeight = 16;
			this.lstNodes.Items.AddRange(new object[] {
			"127.0.0.1:9090",
			"127.0.0.2:9090",
			"127.0.0.3:9090"});
			this.lstNodes.Location = new System.Drawing.Point(17, 69);
			this.lstNodes.Margin = new System.Windows.Forms.Padding(4);
			this.lstNodes.Name = "lstNodes";
			this.lstNodes.Size = new System.Drawing.Size(251, 132);
			this.lstNodes.Sorted = true;
			this.lstNodes.TabIndex = 0;
			this.lstNodes.SelectedIndexChanged += new System.EventHandler(this.LstNodesSelectedIndexChanged);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Location = new System.Drawing.Point(0, 350);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStripMain.Size = new System.Drawing.Size(578, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(17, 207);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(123, 24);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove Node";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(121, 52);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(124, 22);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add Node";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// txtIPAddress
			// 
			this.txtIPAddress.Location = new System.Drawing.Point(7, 22);
			this.txtIPAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtIPAddress.Name = "txtIPAddress";
			this.txtIPAddress.Size = new System.Drawing.Size(238, 22);
			this.txtIPAddress.TabIndex = 4;
			// 
			// lblSystemIP
			// 
			this.lblSystemIP.Location = new System.Drawing.Point(275, 43);
			this.lblSystemIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSystemIP.Name = "lblSystemIP";
			this.lblSystemIP.Size = new System.Drawing.Size(284, 22);
			this.lblSystemIP.TabIndex = 5;
			this.lblSystemIP.Text = "System IP:";
			this.lblSystemIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnNodeBackup
			// 
			this.btnNodeBackup.Location = new System.Drawing.Point(275, 305);
			this.btnNodeBackup.Margin = new System.Windows.Forms.Padding(4);
			this.btnNodeBackup.Name = "btnNodeBackup";
			this.btnNodeBackup.Size = new System.Drawing.Size(137, 28);
			this.btnNodeBackup.TabIndex = 6;
			this.btnNodeBackup.Text = "Node Backup";
			this.btnNodeBackup.UseVisualStyleBackColor = true;
			this.btnNodeBackup.Click += new System.EventHandler(this.BtnNodeBackupClick);
			// 
			// btnNetworkBackup
			// 
			this.btnNetworkBackup.Location = new System.Drawing.Point(420, 305);
			this.btnNetworkBackup.Margin = new System.Windows.Forms.Padding(4);
			this.btnNetworkBackup.Name = "btnNetworkBackup";
			this.btnNetworkBackup.Size = new System.Drawing.Size(136, 28);
			this.btnNetworkBackup.TabIndex = 7;
			this.btnNetworkBackup.Text = "Network Backup";
			this.btnNetworkBackup.UseVisualStyleBackColor = true;
			this.btnNetworkBackup.Click += new System.EventHandler(this.BtnNetworkBackupClick);
			// 
			// picYantra
			// 
			this.picYantra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.picYantra.Image = ((System.Drawing.Image)(resources.GetObject("picYantra.Image")));
			this.picYantra.Location = new System.Drawing.Point(275, 69);
			this.picYantra.Margin = new System.Windows.Forms.Padding(4);
			this.picYantra.Name = "picYantra";
			this.picYantra.Size = new System.Drawing.Size(284, 224);
			this.picYantra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picYantra.TabIndex = 8;
			this.picYantra.TabStop = false;
			this.picYantra.UseWaitCursor = true;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nodesToolStripMenuItem,
			this.optionsToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStripMain.Size = new System.Drawing.Size(578, 25);
			this.menuStripMain.TabIndex = 9;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// nodesToolStripMenuItem
			// 
			this.nodesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.networkStatusToolStripMenuItem,
			this.networkLogToolStripMenuItem});
			this.nodesToolStripMenuItem.Name = "nodesToolStripMenuItem";
			this.nodesToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.nodesToolStripMenuItem.Text = "Nodes";
			// 
			// networkStatusToolStripMenuItem
			// 
			this.networkStatusToolStripMenuItem.Name = "networkStatusToolStripMenuItem";
			this.networkStatusToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.networkStatusToolStripMenuItem.Text = "Network Status";
			this.networkStatusToolStripMenuItem.Click += new System.EventHandler(this.NetworkStatusToolStripMenuItemClick);
			// 
			// networkLogToolStripMenuItem
			// 
			this.networkLogToolStripMenuItem.Name = "networkLogToolStripMenuItem";
			this.networkLogToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.networkLogToolStripMenuItem.Text = "Network Log";
			this.networkLogToolStripMenuItem.Click += new System.EventHandler(this.NetworkLogToolStripMenuItemClick);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.sendTextToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
			this.optionsToolStripMenuItem.Text = "Broadcast";
			// 
			// sendTextToolStripMenuItem
			// 
			this.sendTextToolStripMenuItem.Name = "sendTextToolStripMenuItem";
			this.sendTextToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.sendTextToolStripMenuItem.Text = "Send Text";
			this.sendTextToolStripMenuItem.Click += new System.EventHandler(this.SendTextToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutYantraToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutYantraToolStripMenuItem
			// 
			this.aboutYantraToolStripMenuItem.Name = "aboutYantraToolStripMenuItem";
			this.aboutYantraToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.aboutYantraToolStripMenuItem.Text = "About Yantra";
			this.aboutYantraToolStripMenuItem.Click += new System.EventHandler(this.AboutYantraToolStripMenuItemClick);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(199, 207);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(69, 23);
			this.btnStart.TabIndex = 12;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtIPAddress);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new System.Drawing.Point(16, 247);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(252, 84);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter IP Address to add to list.";
			// 
			// lblList
			// 
			this.lblList.Location = new System.Drawing.Point(17, 43);
			this.lblList.Name = "lblList";
			this.lblList.Size = new System.Drawing.Size(251, 23);
			this.lblList.TabIndex = 16;
			this.lblList.Text = "Nodes Connected.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 372);
			this.Controls.Add(this.lblList);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.picYantra);
			this.Controls.Add(this.btnNetworkBackup);
			this.Controls.Add(this.btnNodeBackup);
			this.Controls.Add(this.lblSystemIP);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.menuStripMain);
			this.Controls.Add(this.lstNodes);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStripMain;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VM.Yantra.GUI Blockchain";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.picYantra)).EndInit();
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
