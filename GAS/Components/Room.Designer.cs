namespace GAS.Components
{
    partial class Room
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGameName = new System.Windows.Forms.Label();
            this.checkSync = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progress = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(66, 14);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(344, 31);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "OOOOOOOOOOOOOOO";
            // 
            // checkSync
            // 
            this.checkSync.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSync.BackColor = System.Drawing.Color.Transparent;
            this.checkSync.BackgroundImage = global::GAS.Properties.Resources.sign_error;
            this.checkSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkSync.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkSync.Location = new System.Drawing.Point(0, 0);
            this.checkSync.Name = "checkSync";
            this.checkSync.Size = new System.Drawing.Size(60, 60);
            this.checkSync.TabIndex = 0;
            this.checkSync.UseVisualStyleBackColor = false;
            this.checkSync.CheckedChanged += new System.EventHandler(this.checkSync_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(558, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progress.Location = new System.Drawing.Point(0, 0);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(0, 60);
            this.progress.TabIndex = 4;
            this.progress.TabStop = false;
            // 
            // Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.checkSync);
            this.Controls.Add(this.progress);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(576, 60);
            this.MinimumSize = new System.Drawing.Size(576, 60);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(576, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameName;
        public System.Windows.Forms.CheckBox checkSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox progress;
    }
}
