namespace GAS
{
    partial class Principal
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgMinimize = new System.Windows.Forms.PictureBox();
            this.imgInfo = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnChat = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtMessageHistory = new System.Windows.Forms.TextBox();
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.flowConsoles = new System.Windows.Forms.FlowLayoutPanel();
            this.gamePlatform1 = new GAS.Components.GamePlatform();
            this.gamePlatform2 = new GAS.Components.GamePlatform();
            this.gamePlatform3 = new GAS.Components.GamePlatform();
            this.gamePlatform4 = new GAS.Components.GamePlatform();
            this.initialize = new System.Windows.Forms.Timer(this.components);
            this.snesGamePlatform1 = new GAS.Components.GamePlatform();
            this.snesGamePlatform2 = new GAS.Components.GamePlatform();
            this.snesGamePlatform3 = new GAS.Components.GamePlatform();
            this.snesGamePlatform4 = new GAS.Components.GamePlatform();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnChat.SuspendLayout();
            this.flowConsoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Blue;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.imgClose);
            this.pnHeader.Controls.Add(this.imgMinimize);
            this.pnHeader.Controls.Add(this.imgInfo);
            this.pnHeader.Location = new System.Drawing.Point(5, 7);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(890, 48);
            this.pnHeader.TabIndex = 3;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GAS.Properties.Resources.star_alt;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pericles", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gamer All Stars";
            // 
            // imgClose
            // 
            this.imgClose.BackColor = System.Drawing.Color.Transparent;
            this.imgClose.Image = global::GAS.Properties.Resources.sign_error;
            this.imgClose.Location = new System.Drawing.Point(842, 0);
            this.imgClose.Margin = new System.Windows.Forms.Padding(0);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(48, 48);
            this.imgClose.TabIndex = 1;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // imgMinimize
            // 
            this.imgMinimize.BackColor = System.Drawing.Color.Transparent;
            this.imgMinimize.Image = global::GAS.Properties.Resources.sign_down;
            this.imgMinimize.Location = new System.Drawing.Point(794, 0);
            this.imgMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.imgMinimize.Name = "imgMinimize";
            this.imgMinimize.Size = new System.Drawing.Size(48, 48);
            this.imgMinimize.TabIndex = 2;
            this.imgMinimize.TabStop = false;
            this.imgMinimize.Click += new System.EventHandler(this.imgMinimize_Click);
            // 
            // imgInfo
            // 
            this.imgInfo.BackColor = System.Drawing.Color.Transparent;
            this.imgInfo.Image = global::GAS.Properties.Resources.sign_question;
            this.imgInfo.Location = new System.Drawing.Point(746, 0);
            this.imgInfo.Margin = new System.Windows.Forms.Padding(0);
            this.imgInfo.Name = "imgInfo";
            this.imgInfo.Size = new System.Drawing.Size(48, 48);
            this.imgInfo.TabIndex = 0;
            this.imgInfo.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Controls.Add(this.pnChat);
            this.pnMain.Controls.Add(this.flowConsoles);
            this.pnMain.Location = new System.Drawing.Point(5, 58);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(890, 538);
            this.pnMain.TabIndex = 6;
            // 
            // pnChat
            // 
            this.pnChat.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnChat.Controls.Add(this.label3);
            this.pnChat.Controls.Add(this.label2);
            this.pnChat.Controls.Add(this.listBox1);
            this.pnChat.Controls.Add(this.txtMessageHistory);
            this.pnChat.Controls.Add(this.txtSendMessage);
            this.pnChat.Location = new System.Drawing.Point(3, 288);
            this.pnChat.Name = "pnChat";
            this.pnChat.Size = new System.Drawing.Size(884, 242);
            this.pnChat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "C H A T   H I S T O R Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "O N L I N E   P L A Y E R S";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(4, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 214);
            this.listBox1.TabIndex = 2;
            // 
            // txtMessageHistory
            // 
            this.txtMessageHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMessageHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageHistory.Location = new System.Drawing.Point(421, 25);
            this.txtMessageHistory.Multiline = true;
            this.txtMessageHistory.Name = "txtMessageHistory";
            this.txtMessageHistory.Size = new System.Drawing.Size(459, 188);
            this.txtMessageHistory.TabIndex = 1;
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendMessage.Location = new System.Drawing.Point(421, 214);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(459, 26);
            this.txtSendMessage.TabIndex = 0;
            this.txtSendMessage.Text = "Type your text here (press enter to send)";
            this.txtSendMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSendMessage.Enter += new System.EventHandler(this.txtSendMessage_Enter);
            this.txtSendMessage.Leave += new System.EventHandler(this.txtSendMessage_Leave);
            // 
            // flowConsoles
            // 
            this.flowConsoles.AutoScroll = true;
            this.flowConsoles.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowConsoles.Controls.Add(this.gamePlatform1);
            this.flowConsoles.Controls.Add(this.gamePlatform2);
            this.flowConsoles.Controls.Add(this.gamePlatform3);
            this.flowConsoles.Controls.Add(this.gamePlatform4);
            this.flowConsoles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowConsoles.Location = new System.Drawing.Point(3, 3);
            this.flowConsoles.Name = "flowConsoles";
            this.flowConsoles.Size = new System.Drawing.Size(884, 279);
            this.flowConsoles.TabIndex = 0;
            // 
            // gamePlatform1
            // 
            this.gamePlatform1.BackColor = System.Drawing.Color.Silver;
            this.gamePlatform1.BackgroundImage = global::GAS.Properties.Resources.game_controller_1;
            this.gamePlatform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePlatform1.ConsoleName = "Super Nintendo";
            this.gamePlatform1.ConsoleNamePositionX = 28;
            this.gamePlatform1.Location = new System.Drawing.Point(3, 3);
            this.gamePlatform1.Name = "gamePlatform1";
            this.gamePlatform1.Size = new System.Drawing.Size(256, 256);
            this.gamePlatform1.TabIndex = 0;
            this.gamePlatform1.Click += new System.EventHandler(this.gamePlatform1_Click);
            // 
            // gamePlatform2
            // 
            this.gamePlatform2.BackColor = System.Drawing.Color.Silver;
            this.gamePlatform2.BackgroundImage = global::GAS.Properties.Resources.game_controller_5;
            this.gamePlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePlatform2.ConsoleName = "Playstation 1";
            this.gamePlatform2.ConsoleNamePositionX = 48;
            this.gamePlatform2.Location = new System.Drawing.Point(265, 3);
            this.gamePlatform2.Name = "gamePlatform2";
            this.gamePlatform2.Size = new System.Drawing.Size(256, 256);
            this.gamePlatform2.TabIndex = 1;
            this.gamePlatform2.Click += new System.EventHandler(this.gamePlatform2_Click);
            // 
            // gamePlatform3
            // 
            this.gamePlatform3.BackColor = System.Drawing.Color.Silver;
            this.gamePlatform3.BackgroundImage = global::GAS.Properties.Resources.game_console_15;
            this.gamePlatform3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePlatform3.ConsoleName = "Fliperama (MAME)";
            this.gamePlatform3.ConsoleNamePositionX = 14;
            this.gamePlatform3.Location = new System.Drawing.Point(527, 3);
            this.gamePlatform3.Name = "gamePlatform3";
            this.gamePlatform3.Size = new System.Drawing.Size(256, 256);
            this.gamePlatform3.TabIndex = 2;
            this.gamePlatform3.Click += new System.EventHandler(this.gamePlatform3_Click);
            // 
            // gamePlatform4
            // 
            this.gamePlatform4.BackColor = System.Drawing.Color.Silver;
            this.gamePlatform4.BackgroundImage = global::GAS.Properties.Resources.game_controller;
            this.gamePlatform4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePlatform4.ConsoleName = "Nintendo 64";
            this.gamePlatform4.ConsoleNamePositionX = 55;
            this.gamePlatform4.Location = new System.Drawing.Point(789, 3);
            this.gamePlatform4.Name = "gamePlatform4";
            this.gamePlatform4.Size = new System.Drawing.Size(256, 256);
            this.gamePlatform4.TabIndex = 3;
            this.gamePlatform4.Click += new System.EventHandler(this.gamePlatform4_Click);
            // 
            // initialize
            // 
            this.initialize.Enabled = true;
            this.initialize.Interval = 1;
            this.initialize.Tick += new System.EventHandler(this.initialize_Tick);
            // 
            // snesGamePlatform1
            // 
            this.snesGamePlatform1.BackColor = System.Drawing.Color.Silver;
            this.snesGamePlatform1.BackgroundImage = global::GAS.Properties.Resources.game_controller_1;
            this.snesGamePlatform1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snesGamePlatform1.ConsoleName = "Super Nintendo";
            this.snesGamePlatform1.ConsoleNamePositionX = 28;
            this.snesGamePlatform1.Location = new System.Drawing.Point(3, 3);
            this.snesGamePlatform1.Name = "snesGamePlatform1";
            this.snesGamePlatform1.Size = new System.Drawing.Size(256, 256);
            this.snesGamePlatform1.TabIndex = 0;
            // 
            // snesGamePlatform2
            // 
            this.snesGamePlatform2.BackColor = System.Drawing.Color.Silver;
            this.snesGamePlatform2.BackgroundImage = global::GAS.Properties.Resources.game_controller_5;
            this.snesGamePlatform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snesGamePlatform2.ConsoleName = "Playstation 1";
            this.snesGamePlatform2.ConsoleNamePositionX = 28;
            this.snesGamePlatform2.Location = new System.Drawing.Point(265, 3);
            this.snesGamePlatform2.Name = "snesGamePlatform2";
            this.snesGamePlatform2.Size = new System.Drawing.Size(256, 256);
            this.snesGamePlatform2.TabIndex = 1;
            // 
            // snesGamePlatform3
            // 
            this.snesGamePlatform3.BackColor = System.Drawing.Color.Silver;
            this.snesGamePlatform3.BackgroundImage = global::GAS.Properties.Resources.game_controller_1;
            this.snesGamePlatform3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snesGamePlatform3.ConsoleName = "Super Nintendo";
            this.snesGamePlatform3.ConsoleNamePositionX = 28;
            this.snesGamePlatform3.Location = new System.Drawing.Point(527, 3);
            this.snesGamePlatform3.Name = "snesGamePlatform3";
            this.snesGamePlatform3.Size = new System.Drawing.Size(256, 256);
            this.snesGamePlatform3.TabIndex = 2;
            // 
            // snesGamePlatform4
            // 
            this.snesGamePlatform4.BackColor = System.Drawing.Color.Silver;
            this.snesGamePlatform4.BackgroundImage = global::GAS.Properties.Resources.game_controller_1;
            this.snesGamePlatform4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snesGamePlatform4.ConsoleName = "Super Nintendo";
            this.snesGamePlatform4.ConsoleNamePositionX = 28;
            this.snesGamePlatform4.Location = new System.Drawing.Point(789, 3);
            this.snesGamePlatform4.Name = "snesGamePlatform4";
            this.snesGamePlatform4.Size = new System.Drawing.Size(256, 256);
            this.snesGamePlatform4.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Principal";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamer All Stars";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnChat.ResumeLayout(false);
            this.pnChat.PerformLayout();
            this.flowConsoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInfo;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgMinimize;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Timer initialize;
        private System.Windows.Forms.FlowLayoutPanel flowConsoles;
        private Components.GamePlatform snesGamePlatform1;
        private Components.GamePlatform snesGamePlatform2;
        private Components.GamePlatform snesGamePlatform3;
        private Components.GamePlatform snesGamePlatform4;
        private Components.GamePlatform gamePlatform1;
        private Components.GamePlatform gamePlatform2;
        private Components.GamePlatform gamePlatform3;
        private Components.GamePlatform gamePlatform4;
        private System.Windows.Forms.Panel pnChat;
        private System.Windows.Forms.TextBox txtMessageHistory;
        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

