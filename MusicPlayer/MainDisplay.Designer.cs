namespace MusicPlayer
{
    partial class MainDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplay));
            this.tbDuration = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.MainTitle = new System.Windows.Forms.Label();
            this.MainArtist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSong = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DetailLength = new System.Windows.Forms.Label();
            this.DetailGenre = new System.Windows.Forms.Label();
            this.DetailAlbum = new System.Windows.Forms.Label();
            this.DetailArtist = new System.Windows.Forms.Label();
            this.DetailTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.ptbDetail = new System.Windows.Forms.PictureBox();
            this.ptbMain = new System.Windows.Forms.PictureBox();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptbSongImage = new System.Windows.Forms.PictureBox();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnVolumn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRandom = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLoop = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDuration
            // 
            this.tbDuration.BackColor = System.Drawing.Color.Transparent;
            this.tbDuration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.tbDuration.Location = new System.Drawing.Point(343, 805);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(737, 30);
            this.tbDuration.TabIndex = 2;
            this.tbDuration.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.tbDuration.Value = 0;
            this.tbDuration.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbDuration_Scroll);
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.Color.Transparent;
            this.tbVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.tbVolume.Location = new System.Drawing.Point(1209, 771);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(163, 35);
            this.tbVolume.TabIndex = 3;
            this.tbVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(84)))));
            this.tbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tbVolume_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(99, 778);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 25);
            this.lblTitle.TabIndex = 10;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lblArtist.Location = new System.Drawing.Point(101, 809);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(0, 15);
            this.lblArtist.TabIndex = 11;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 180);
            this.panel1.TabIndex = 13;
            // 
            // btnSetting
            // 
            this.btnSetting.BorderRadius = 20;
            this.btnSetting.CustomImages.Image = global::MusicPlayer.Properties.Resources.icons8_setting_48;
            this.btnSetting.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnSetting.Location = new System.Drawing.Point(18, 91);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(170, 50);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Setting";
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 20;
            this.btnAccount.CustomImages.Image = global::MusicPlayer.Properties.Resources.icons8_account_30;
            this.btnAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnAccount.Location = new System.Drawing.Point(18, 35);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(170, 50);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel3.Controls.Add(this.btnPlaylist);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(12, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 527);
            this.panel3.TabIndex = 14;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BorderRadius = 20;
            this.btnPlaylist.CustomImages.Image = global::MusicPlayer.Properties.Resources.icons8_playlist_50;
            this.btnPlaylist.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaylist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaylist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaylist.FillColor = System.Drawing.Color.Black;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnPlaylist.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnPlaylist.Location = new System.Drawing.Point(18, 102);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(170, 50);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.guna2CustomGradientPanel1;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.MainTitle);
            this.guna2CustomGradientPanel1.Controls.Add(this.MainArtist);
            this.guna2CustomGradientPanel1.Controls.Add(this.ptbMain);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnImport);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2TextBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.flpSong);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(218, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(893, 715);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.ForeColor = System.Drawing.Color.White;
            this.MainTitle.Location = new System.Drawing.Point(490, 504);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(128, 67);
            this.MainTitle.TabIndex = 17;
            this.MainTitle.Text = "Title";
            this.MainTitle.Visible = false;
            // 
            // MainArtist
            // 
            this.MainArtist.AutoSize = true;
            this.MainArtist.BackColor = System.Drawing.Color.Transparent;
            this.MainArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.MainArtist.Location = new System.Drawing.Point(496, 584);
            this.MainArtist.Name = "MainArtist";
            this.MainArtist.Size = new System.Drawing.Size(78, 35);
            this.MainArtist.TabIndex = 18;
            this.MainArtist.Text = "Artist";
            this.MainArtist.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(162, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title                                                                            " +
    " Artist                                                    Time";
            // 
            // flpSong
            // 
            this.flpSong.AutoScroll = true;
            this.flpSong.BackColor = System.Drawing.Color.Transparent;
            this.flpSong.Location = new System.Drawing.Point(20, 150);
            this.flpSong.Name = "flpSong";
            this.flpSong.Size = new System.Drawing.Size(870, 543);
            this.flpSong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(127, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________________________________________________________________" +
    "________";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.DetailLength);
            this.panel2.Controls.Add(this.DetailGenre);
            this.panel2.Controls.Add(this.DetailAlbum);
            this.panel2.Controls.Add(this.DetailArtist);
            this.panel2.Controls.Add(this.DetailTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ptbDetail);
            this.panel2.Location = new System.Drawing.Point(1117, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 715);
            this.panel2.TabIndex = 16;
            // 
            // DetailLength
            // 
            this.DetailLength.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.DetailLength.Location = new System.Drawing.Point(25, 620);
            this.DetailLength.Name = "DetailLength";
            this.DetailLength.Size = new System.Drawing.Size(250, 30);
            this.DetailLength.TabIndex = 6;
            this.DetailLength.Text = "Length";
            // 
            // DetailGenre
            // 
            this.DetailGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.DetailGenre.Location = new System.Drawing.Point(25, 557);
            this.DetailGenre.Name = "DetailGenre";
            this.DetailGenre.Size = new System.Drawing.Size(250, 50);
            this.DetailGenre.TabIndex = 5;
            this.DetailGenre.Text = "Genre";
            // 
            // DetailAlbum
            // 
            this.DetailAlbum.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.DetailAlbum.Location = new System.Drawing.Point(25, 492);
            this.DetailAlbum.Name = "DetailAlbum";
            this.DetailAlbum.Size = new System.Drawing.Size(250, 50);
            this.DetailAlbum.TabIndex = 4;
            this.DetailAlbum.Text = "Album";
            // 
            // DetailArtist
            // 
            this.DetailArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.DetailArtist.Location = new System.Drawing.Point(25, 426);
            this.DetailArtist.Name = "DetailArtist";
            this.DetailArtist.Size = new System.Drawing.Size(250, 50);
            this.DetailArtist.TabIndex = 3;
            this.DetailArtist.Text = "Artist";
            // 
            // DetailTitle
            // 
            this.DetailTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.DetailTitle.Location = new System.Drawing.Point(25, 360);
            this.DetailTitle.Name = "DetailTitle";
            this.DetailTitle.Size = new System.Drawing.Size(250, 50);
            this.DetailTitle.TabIndex = 2;
            this.DetailTitle.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Song details";
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 20;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 20;
            this.guna2Elipse5.TargetControl = this.ptbSongImage;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 20;
            this.guna2Elipse6.TargetControl = this.ptbDetail;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 20;
            this.guna2Elipse7.TargetControl = this.ptbMain;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lblStart.Location = new System.Drawing.Point(300, 809);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(31, 20);
            this.lblStart.TabIndex = 17;
            this.lblStart.Text = "-:--";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lblEnd.Location = new System.Drawing.Point(1086, 809);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(31, 20);
            this.lblEnd.TabIndex = 18;
            this.lblEnd.Text = "-:--";
            // 
            // ptbDetail
            // 
            this.ptbDetail.Location = new System.Drawing.Point(25, 25);
            this.ptbDetail.Name = "ptbDetail";
            this.ptbDetail.Size = new System.Drawing.Size(250, 250);
            this.ptbDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDetail.TabIndex = 0;
            this.ptbDetail.TabStop = false;
            // 
            // ptbMain
            // 
            this.ptbMain.Location = new System.Drawing.Point(55, 255);
            this.ptbMain.Name = "ptbMain";
            this.ptbMain.Size = new System.Drawing.Size(400, 400);
            this.ptbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMain.TabIndex = 6;
            this.ptbMain.TabStop = false;
            this.ptbMain.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderColor = System.Drawing.Color.Transparent;
            this.btnImport.BorderRadius = 25;
            this.btnImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = global::MusicPlayer.Properties.Resources.icons8_upload_26;
            this.btnImport.Location = new System.Drawing.Point(43, 102);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(50, 50);
            this.btnImport.TabIndex = 5;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 23;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Search";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.IconLeft = global::MusicPlayer.Properties.Resources.icons8_find_50;
            this.guna2TextBox1.Location = new System.Drawing.Point(43, 13);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(371, 48);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // ptbSongImage
            // 
            this.ptbSongImage.Location = new System.Drawing.Point(10, 761);
            this.ptbSongImage.Name = "ptbSongImage";
            this.ptbSongImage.Size = new System.Drawing.Size(80, 80);
            this.ptbSongImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSongImage.TabIndex = 9;
            this.ptbSongImage.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 20;
            this.btnHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(18, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(170, 50);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlay.FillColor = System.Drawing.Color.Black;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = global::MusicPlayer.Properties.Resources.icons8_play_50;
            this.btnPlay.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlay.Location = new System.Drawing.Point(687, 749);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.Black;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(631, 749);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnVolumn
            // 
            this.btnVolumn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolumn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolumn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolumn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolumn.FillColor = System.Drawing.Color.Black;
            this.btnVolumn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVolumn.ForeColor = System.Drawing.Color.White;
            this.btnVolumn.Image = global::MusicPlayer.Properties.Resources.icons8_voice_50;
            this.btnVolumn.Location = new System.Drawing.Point(1153, 764);
            this.btnVolumn.Name = "btnVolumn";
            this.btnVolumn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnVolumn.Size = new System.Drawing.Size(50, 50);
            this.btnVolumn.TabIndex = 12;
            this.btnVolumn.Click += new System.EventHandler(this.btnVolumn_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRandom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRandom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRandom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRandom.FillColor = System.Drawing.Color.Black;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.Image = global::MusicPlayer.Properties.Resources.icons8_shuffle_64;
            this.btnRandom.Location = new System.Drawing.Point(575, 749);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRandom.Size = new System.Drawing.Size(50, 50);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoop.FillColor = System.Drawing.Color.Black;
            this.btnLoop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoop.ForeColor = System.Drawing.Color.White;
            this.btnLoop.Image = global::MusicPlayer.Properties.Resources.icons8_loop_64;
            this.btnLoop.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLoop.Location = new System.Drawing.Point(799, 749);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLoop.Size = new System.Drawing.Size(50, 50);
            this.btnLoop.TabIndex = 6;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(743, 749);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 5;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1422, 853);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.ptbSongImage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnVolumn);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainDisplay";
            this.Text = "MusicPlayer";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSongImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TrackBar tbDuration;
        private Guna.UI2.WinForms.Guna2TrackBar tbVolume;
        private Guna.UI2.WinForms.Guna2CircleButton btnPlay;
        private Guna.UI2.WinForms.Guna2CircleButton btnNext;
        private Guna.UI2.WinForms.Guna2CircleButton btnLoop;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnRandom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptbSongImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private Guna.UI2.WinForms.Guna2CircleButton btnVolumn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.FlowLayoutPanel flpSong;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button btnPlaylist;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private System.Windows.Forms.PictureBox ptbDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DetailGenre;
        private System.Windows.Forms.Label DetailAlbum;
        private System.Windows.Forms.Label DetailArtist;
        private System.Windows.Forms.Label DetailTitle;
        private System.Windows.Forms.Label DetailLength;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private System.Windows.Forms.PictureBox ptbMain;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label MainArtist;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
    }
}
