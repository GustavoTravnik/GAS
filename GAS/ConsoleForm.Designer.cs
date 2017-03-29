namespace GAS
{
    partial class ConsoleForm
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
            this.picConsole = new System.Windows.Forms.PictureBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.imgMinimize = new System.Windows.Forms.PictureBox();
            this.imgInfo = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnOptions = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSyncronize = new System.Windows.Forms.Button();
            this.flowRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.pnInitRoom = new System.Windows.Forms.Panel();
            this.flowEmulators = new System.Windows.Forms.FlowLayoutPanel();
            this.initialize = new System.Windows.Forms.Timer(this.components);
            this.snesGamePlatform1 = new GAS.Components.GamePlatform();
            this.snesGamePlatform2 = new GAS.Components.GamePlatform();
            this.snesGamePlatform3 = new GAS.Components.GamePlatform();
            this.snesGamePlatform4 = new GAS.Components.GamePlatform();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnOptions.SuspendLayout();
            this.pnInitRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Blue;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnHeader.Controls.Add(this.picConsole);
            this.pnHeader.Controls.Add(this.lblConsole);
            this.pnHeader.Controls.Add(this.imgClose);
            this.pnHeader.Controls.Add(this.imgMinimize);
            this.pnHeader.Controls.Add(this.imgInfo);
            this.pnHeader.Location = new System.Drawing.Point(5, 7);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(890, 48);
            this.pnHeader.TabIndex = 3;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // picConsole
            // 
            this.picConsole.BackColor = System.Drawing.Color.Transparent;
            this.picConsole.Image = global::GAS.Properties.Resources.star_alt;
            this.picConsole.Location = new System.Drawing.Point(0, -1);
            this.picConsole.Margin = new System.Windows.Forms.Padding(0);
            this.picConsole.Name = "picConsole";
            this.picConsole.Size = new System.Drawing.Size(48, 48);
            this.picConsole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConsole.TabIndex = 5;
            this.picConsole.TabStop = false;
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Font = new System.Drawing.Font("Pericles", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsole.ForeColor = System.Drawing.Color.White;
            this.lblConsole.Location = new System.Drawing.Point(52, 7);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(238, 32);
            this.lblConsole.TabIndex = 4;
            this.lblConsole.Text = "Gamer All Stars";
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
            this.pnMain.Controls.Add(this.pnOptions);
            this.pnMain.Controls.Add(this.flowRooms);
            this.pnMain.Controls.Add(this.pnInitRoom);
            this.pnMain.Location = new System.Drawing.Point(5, 58);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(890, 538);
            this.pnMain.TabIndex = 6;
            // 
            // pnOptions
            // 
            this.pnOptions.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnOptions.Controls.Add(this.button1);
            this.pnOptions.Controls.Add(this.btnSyncronize);
            this.pnOptions.Location = new System.Drawing.Point(3, 489);
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.Size = new System.Drawing.Size(599, 46);
            this.pnOptions.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(313, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop Syncronize";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSyncronize
            // 
            this.btnSyncronize.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSyncronize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncronize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyncronize.ForeColor = System.Drawing.Color.Lime;
            this.btnSyncronize.Location = new System.Drawing.Point(4, 5);
            this.btnSyncronize.Name = "btnSyncronize";
            this.btnSyncronize.Size = new System.Drawing.Size(283, 38);
            this.btnSyncronize.TabIndex = 0;
            this.btnSyncronize.Text = "Syncronize";
            this.btnSyncronize.UseVisualStyleBackColor = false;
            this.btnSyncronize.Click += new System.EventHandler(this.btnSyncronize_Click);
            // 
            // flowRooms
            // 
            this.flowRooms.AutoScroll = true;
            this.flowRooms.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowRooms.Location = new System.Drawing.Point(3, 3);
            this.flowRooms.MaximumSize = new System.Drawing.Size(599, 480);
            this.flowRooms.MinimumSize = new System.Drawing.Size(599, 480);
            this.flowRooms.Name = "flowRooms";
            this.flowRooms.Size = new System.Drawing.Size(599, 480);
            this.flowRooms.TabIndex = 2;
            // 
            // pnInitRoom
            // 
            this.pnInitRoom.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnInitRoom.Controls.Add(this.flowEmulators);
            this.pnInitRoom.Location = new System.Drawing.Point(608, 3);
            this.pnInitRoom.Name = "pnInitRoom";
            this.pnInitRoom.Size = new System.Drawing.Size(279, 532);
            this.pnInitRoom.TabIndex = 1;
            // 
            // flowEmulators
            // 
            this.flowEmulators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowEmulators.Location = new System.Drawing.Point(0, 0);
            this.flowEmulators.Name = "flowEmulators";
            this.flowEmulators.Size = new System.Drawing.Size(279, 532);
            this.flowEmulators.TabIndex = 0;
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
            // ConsoleForm
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
            this.Name = "ConsoleForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gamer All Stars";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnOptions.ResumeLayout(false);
            this.pnInitRoom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInfo;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.PictureBox imgMinimize;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox picConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Timer initialize;
        private Components.GamePlatform snesGamePlatform1;
        private Components.GamePlatform snesGamePlatform2;
        private Components.GamePlatform snesGamePlatform3;
        private Components.GamePlatform snesGamePlatform4;
        private System.Windows.Forms.Panel pnInitRoom;
        private System.Windows.Forms.FlowLayoutPanel flowRooms;
        private System.Windows.Forms.Panel pnOptions;
        private System.Windows.Forms.Button btnSyncronize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowEmulators;
    }
}

