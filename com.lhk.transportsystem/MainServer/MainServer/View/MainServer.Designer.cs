namespace MainServer
{
    partial class MainServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainServer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLogScreen = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.niServerNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblExtenalIP = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLogScreen);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(792, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbLogScreen
            // 
            this.tbLogScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLogScreen.Location = new System.Drawing.Point(4, 19);
            this.tbLogScreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogScreen.Name = "tbLogScreen";
            this.tbLogScreen.ReadOnly = true;
            this.tbLogScreen.Size = new System.Drawing.Size(784, 274);
            this.tbLogScreen.TabIndex = 0;
            this.tbLogScreen.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(711, 356);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Image = global::MainServer.Properties.Resources.configure1;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(17, 356);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(98, 32);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::MainServer.Properties.Resources.stop1;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(390, 356);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(105, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::MainServer.Properties.Resources.player_play2;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(270, 356);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // niServerNotify
            // 
            this.niServerNotify.ContextMenuStrip = this.contextMenuStrip1;
            this.niServerNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("niServerNotify.Icon")));
            this.niServerNotify.Text = "Server";
            this.niServerNotify.Visible = true;
            this.niServerNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niServerNotify_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 70);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblExtenalIP
            // 
            this.lblExtenalIP.AutoSize = true;
            this.lblExtenalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtenalIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExtenalIP.Location = new System.Drawing.Point(167, 19);
            this.lblExtenalIP.Name = "lblExtenalIP";
            this.lblExtenalIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblExtenalIP.Size = new System.Drawing.Size(46, 20);
            this.lblExtenalIP.TabIndex = 13;
            this.lblExtenalIP.Text = "<IP>";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(68, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Extenal IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(589, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPort.Size = new System.Drawing.Size(62, 20);
            this.lblPort.TabIndex = 15;
            this.lblPort.Text = "<Port>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(531, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port:";
            // 
            // MainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 400);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExtenalIP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainServer_FormClosing);
            this.Load += new System.EventHandler(this.MainServer_Load);
            this.Resize += new System.EventHandler(this.MainServer_Resize);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbLogScreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.NotifyIcon niServerNotify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label lblExtenalIP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label2;
    }
}

