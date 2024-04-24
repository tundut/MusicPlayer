using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TagLib.Mpeg;
using TagLib.Riff;


namespace MusicPlayer
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

        }
        private LinkedList ll = new LinkedList();
        public Player player = new Player();
        public Timer timer = new Timer();
        public bool isMuted = false;
        public bool isLoop = false;
        public bool isRandom = false;
        public Random random = new Random();


        public void SetSongInfo()
        {
            lblTitle.Text = player.currentSong.title;
            lblArtist.Text = player.currentSong.artist;
            ptbSongImage.Image = player.currentSong.image;
            if (lblTitle.Size.Width > 150)
                lblTitle.Text = lblTitle.Text.Substring(0, 20) + "...";
            if (lblArtist.Size.Width > 100)
                lblArtist.Text = lblArtist.Text.Substring(0, 15) + "...";

            ptbDetail.Image = player.currentSong.image;
            DetailTitle.Text = "Title: " + player.currentSong.title;
            DetailArtist.Text = "Artist: " + player.currentSong.artist;
            DetailAlbum.Text = "Album: " + player.currentSong.album;
            DetailGenre.Text = "Genre: " + player.currentSong.genre;
            DetailLength.Text = "Length: " + player.currentSong.duration.ToString("m':'ss");
            lblEnd.Text = player.currentSong.duration.ToString("m':'ss");

            MainTitle.Text = player.currentSong.title;
            MainArtist.Text = player.currentSong.artist;
            if (MainTitle.Size.Width > 500)
                MainTitle.Text = MainTitle.Text.Substring(0, 23) + "...";
            ptbMain.Image = player.currentSong.image;

            if (MainTitle.Visible == true)
            {
                Color[] dominantColors = GetDominantColors(player.currentSong.image);
                guna2CustomGradientPanel1.FillColor = dominantColors[0];
                guna2CustomGradientPanel1.FillColor2 = dominantColors[1];
                guna2CustomGradientPanel1.FillColor3 = dominantColors[2];
                guna2CustomGradientPanel1.FillColor4 = dominantColors[3];
            }
        }
        public void Play()
        {
            player.PlaySong(player.currentSong);
            timer.Start();
            btnPlay.Image = Properties.Resources.icons8_pause_50;
            SetSongInfo();

            player.outputDevice.Volume = tbVolume.Value / 100f;
        }

        public static Color[] GetDominantColors(Image image)
        {
            using (Bitmap bitmap = new Bitmap(image))
            {
                Bitmap resizedBitmap = new Bitmap(bitmap, new Size(100, 100));

                var colors = new System.Collections.Generic.List<Color>();
                for (int y = 0; y < resizedBitmap.Height; y++)
                {
                    for (int x = 0; x < resizedBitmap.Width; x++)
                    {
                        Color pixelColor = resizedBitmap.GetPixel(x, y);
                        colors.Add(pixelColor);
                    }
                }

                var dominantColors = colors.GroupBy(c => c)
                                           .OrderByDescending(g => g.Count())
                                           .Take(4)
                                           .Select(g => g.Key)
                                           .ToArray();

                return dominantColors;
            }
        }



        #region Event


        private void tbDuration_Scroll(object sender, EventArgs e)
        {
            if (player.outputDevice != null && player.audioFile != null)
            {
                double progressPercentage = tbDuration.Value;
                double timeToSeek = (progressPercentage / 100) * player.audioFile.TotalTime.TotalSeconds;
                player.audioFile.CurrentTime = TimeSpan.FromSeconds(timeToSeek);
            }
            else
            {
                tbDuration.Value = 0;
            }

        }

        private void tbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            if (player.outputDevice != null && isMuted == false)
            {
                player.outputDevice.Volume = (float)tbVolume.Value / 100;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.outputDevice != null && player.audioFile != null)
            {
                double progressPercentage = (player.audioFile.CurrentTime.TotalSeconds / player.audioFile.TotalTime.TotalSeconds) * 100;
                tbDuration.Value = (int)progressPercentage;
            }
            if (player.outputDevice.PlaybackState == PlaybackState.Stopped || player.audioFile.CurrentTime >= player.audioFile.TotalTime)
            {
                timer.Stop();
                if (!isLoop)
                {
                    if (player.currentSong.next != null)
                    {
                        player.currentSong = player.currentSong.next;
                        player.PlaySong(player.currentSong);
                        timer.Start();
                        SetSongInfo();
                    }
                    else
                    {
                        player.currentSong = ll.head;
                        player.PlaySong(player.currentSong);
                        timer.Start();
                        SetSongInfo();
                        player.Pause();
                        btnPlay.Image = Properties.Resources.icons8_play_50;
                    }
                }
                else
                {
                    player.PlaySong(player.currentSong);
                    timer.Start();
                    SetSongInfo();
                }
            }
            TimeSpan currentTime = player.audioFile.CurrentTime;
            lblStart.Text = currentTime.ToString(@"m\:ss");

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (player.outputDevice.PlaybackState == PlaybackState.Playing)
            {
                player.Pause();
                btnPlay.Image = Properties.Resources.icons8_play_50;
            }
            else if (player.outputDevice.PlaybackState == PlaybackState.Paused)
            {
                player.Continue();
                btnPlay.Image = Properties.Resources.icons8_pause_50;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isRandom)
            {
                List<Song> list = ll.ToList(ll);
                if(list.Count == 1)
                {
                    return;
                }    
                int r = random.Next(0, list.Count);
                while (list[r] == player.currentSong)
                {
                    r = random.Next(0, list.Count);
                }
                player.currentSong = list[r];
                player.PlaySong(player.currentSong);
                SetSongInfo();

            }
            else if (player.currentSong != null)
            {
                player.Next();
                SetSongInfo();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (isRandom)
            {
                List<Song> list = ll.ToList(ll);
                if (list.Count == 1)
                {
                    return;
                }
                int r = random.Next(0, list.Count);
                while (list[r] == player.currentSong)
                {
                    r = random.Next(0, list.Count);
                }
                player.currentSong = list[r];
                player.PlaySong(player.currentSong);
                SetSongInfo();
            }
            else if (player.currentSong != null)
            {
                player.Previous();
                SetSongInfo();
            }
        }
        private void btnVolumn_Click(object sender, EventArgs e)
        {
            if (isMuted == false)
            {
                player.outputDevice.Volume = 0;
                btnVolumn.Image = Properties.Resources.icons8_mute_50;
                isMuted = true;
            }
            else
            {
                player.outputDevice.Volume = (float)tbVolume.Value / 100;
                btnVolumn.Image = Properties.Resources.icons8_voice_50;
                isMuted = false;
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (!isLoop)
            {
                btnLoop.Image = Properties.Resources.icons8_loop_64_on;
                isLoop = true;
            }
            else
            {
                btnLoop.Image = Properties.Resources.icons8_loop_64;
                isLoop = false;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (!isRandom)
            {
                btnRandom.Image = Properties.Resources.icons8_shuffle_64_on;
                isRandom = true;
            }
            else
            {
                btnRandom.Image = Properties.Resources.icons8_shuffle_64;
                isRandom = false;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aac|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Song song = new Song();
                SongComponent songComponent = new SongComponent(this);

                song.filename = ofd.FileName;
                if (ll.CheckDuplicate(song))
                {
                    MessageBox.Show("The song is already in the list", "Duplicate Song", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ll.GetSongInfo(song);
                    ll.Add(song);
                    songComponent.song = song;
                    songComponent.SetSongInfo(song);
                    flpSong.Controls.Add(songComponent);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.Black;
            btnPlaylist.FillColor = Color.Transparent;
            flpSong.Visible = false;
            btnImport.Visible = false;
            guna2TextBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            panel2.Visible = false;
            guna2CustomGradientPanel1.Width = 893;

            MainTitle.Visible = true;
            MainArtist.Visible = true;
            ptbMain.Visible = true;
            if (player.currentSong != null)
            {
                Color[] dominantColors = GetDominantColors(player.currentSong.image);
                guna2CustomGradientPanel1.FillColor = dominantColors[0];
                guna2CustomGradientPanel1.FillColor2 = dominantColors[1];
                guna2CustomGradientPanel1.FillColor3 = dominantColors[2];
                guna2CustomGradientPanel1.FillColor4 = dominantColors[3];
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            btnHome.FillColor = Color.Transparent;
            btnPlaylist.FillColor = Color.Black;
            flpSong.Visible = true;
            btnImport.Visible = true;
            guna2TextBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            panel2.Visible = true;
            guna2CustomGradientPanel1.Width = 670;

            MainTitle.Visible = false;
            MainArtist.Visible = false;
            ptbMain.Visible = false;

            if (player.currentSong != null)
            {
                guna2CustomGradientPanel1.FillColor = Color.FromArgb(18, 18, 18);
                guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(18, 18, 18);
                guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(18, 18, 18);
                guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(18, 18, 18);
            }
        }



        #endregion

    } 
}
