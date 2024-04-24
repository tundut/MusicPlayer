namespace MusicPlayer
{
    partial class SongComponent
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnItem = new Guna.UI2.WinForms.Guna2Panel();
            this.ptbSongImage = new System.Windows.Forms.PictureBox();
            this.pnItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(131, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.lblTitle.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(470, 31);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(50, 23);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist";
            this.lblArtist.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.lblArtist.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(712, 31);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 23);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "00:00";
            this.lblDuration.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.lblDuration.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.FillColor = System.Drawing.Color.Transparent;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlay.Location = new System.Drawing.Point(6, 15);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(774, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // pnItem
            // 
            this.pnItem.BorderRadius = 15;
            this.pnItem.Controls.Add(this.btnDelete);
            this.pnItem.Controls.Add(this.btnPlay);
            this.pnItem.Controls.Add(this.ptbSongImage);
            this.pnItem.Controls.Add(this.lblDuration);
            this.pnItem.Controls.Add(this.lblTitle);
            this.pnItem.Controls.Add(this.lblArtist);
            this.pnItem.FillColor = System.Drawing.Color.Transparent;
            this.pnItem.Location = new System.Drawing.Point(5, 5);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(830, 80);
            this.pnItem.TabIndex = 6;
            this.pnItem.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.pnItem.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // ptbSongImage
            // 
            this.ptbSongImage.Location = new System.Drawing.Point(75, 15);
            this.ptbSongImage.Name = "ptbSongImage";
            this.ptbSongImage.Size = new System.Drawing.Size(50, 50);
            this.ptbSongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSongImage.TabIndex = 0;
            this.ptbSongImage.TabStop = false;
            this.ptbSongImage.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.ptbSongImage.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            // 
            // SongComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnItem);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SongComponent";
            this.Size = new System.Drawing.Size(840, 90);
            this.Load += new System.EventHandler(this.SongComponent_Load);
            this.pnItem.ResumeLayout(false);
            this.pnItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbSongImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblDuration;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlay;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2Panel pnItem;
    }
}
