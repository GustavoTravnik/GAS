namespace GAS.Components
{
    partial class GamePlatform
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lblConsoleName = new System.Windows.Forms.Label();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsoleName
            // 
            this.lblConsoleName.AutoSize = true;
            this.lblConsoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsoleName.ForeColor = System.Drawing.Color.White;
            this.lblConsoleName.Location = new System.Drawing.Point(3, 3);
            this.lblConsoleName.Name = "lblConsoleName";
            this.lblConsoleName.Size = new System.Drawing.Size(193, 29);
            this.lblConsoleName.TabIndex = 0;
            this.lblConsoleName.Text = "OOOOOOOOO";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Gray;
            this.pnHeader.Controls.Add(this.lblConsoleName);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(256, 35);
            this.pnHeader.TabIndex = 1;
            // 
            // GamePlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnHeader);
            this.DoubleBuffered = true;
            this.Name = "GamePlatform";
            this.Size = new System.Drawing.Size(256, 256);
            this.MouseEnter += new System.EventHandler(this.SnesGamePlatform_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SnesGamePlatform_MouseLeave);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        public System.Windows.Forms.Label lblConsoleName;
        private System.Windows.Forms.Panel pnHeader;
    }
}
